using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace HoangLong
{
    public partial class Main : Form
    {
        string connStr = @"Server=DESKTOP-ETG0JM1;Database=QLSV;Trusted_Connection=True;TrustServerCertificate=True;";
        byte[] currentAvatar = null;

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ApplyModernStyle(this);
            StyleDataGridView();
            LoadClassList();
            this.dgvCustomer.RowEnter += dgvCustomer_RowEnter;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadClassList()
        {
            cbClass.Items.Clear();
            cbClass.Items.AddRange(new string[] { "CNTT01", "CNTT02", "KTPM01", "HMT01" });
            if (cbClass.Items.Count > 0) cbClass.SelectedIndex = 0;
        }

        private void ApplyModernStyle(Control parent)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 249, 250);
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                    if (btn.Name.ToLower().Contains("new")) btn.BackColor = Color.FromArgb(40, 167, 69);
                    else if (btn.Name.ToLower().Contains("edit")) btn.BackColor = Color.FromArgb(0, 123, 255);
                    else if (btn.Name.ToLower().Contains("delete")) btn.BackColor = Color.FromArgb(220, 53, 69);
                    else if (btn.Name.ToLower().Contains("excel")) btn.BackColor = Color.FromArgb(255, 152, 0);
                    else btn.BackColor = Color.FromArgb(63, 81, 181);
                }
                if (ctrl.HasChildren) ApplyModernStyle(ctrl);
            }
        }

        private void StyleDataGridView()
        {
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41);
            dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomer.ColumnHeadersHeight = 35;
            dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 244, 246);
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void LoadData()
        {
            try
            {
                dgvCustomer.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Id, FullName, ClassId, Gender, Grade, BirthYear, Email, Address, Avatar FROM Students";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        string birthStr = "01/01/" + r[5].ToString();
                        dgvCustomer.Rows.Add(r[0], r[1], r[2], (bool)r[3] ? "Nam" : "Nữ", r[4], birthStr, r[6], r[7], r[8]);
                    }
                }
                ResetFormFields();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message, "Lỗi SQL"); }
        }

        private void ResetFormFields()
        {
            tbId.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbId.Clear(); tbName.Clear(); tbGrade.Clear(); tbEmail.Clear(); tbAddress.Clear();
            pbAvatar.Image = null; currentAvatar = null;
            tbId.Focus();
        }

        private bool IsValidData(bool isEdit = false)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Mã SV và Email không được để trống!");
                return false;
            }

            Regex emailReg = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailReg.IsMatch(tbEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng (phải có @ và . )!");
                return false;
            }

            Regex reg = new Regex(@"^[a-zA-Z0-9\sÀ-ỹ]+$");
            if (!reg.IsMatch(tbName.Text) || (!string.IsNullOrWhiteSpace(tbAddress.Text) && !reg.IsMatch(tbAddress.Text)))
            {
                MessageBox.Show("Tên và Địa chỉ không được chứa ký tự đặc biệt!");
                return false;
            }

            int age = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.Date > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("Sinh viên phải từ 18 tuổi trở lên!");
                return false;
            }

            if (!double.TryParse(tbGrade.Text, out double grade) || grade < 0 || grade > 10)
            {
                MessageBox.Show("Điểm phải là số thực và nằm trong khoảng 0 - 10!");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = isEdit ? "SELECT COUNT(*) FROM Students WHERE Email = @email AND Id != @id"
                                    : "SELECT COUNT(*) FROM Students WHERE Id = @id OR Email = @email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", tbId.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Mã SV hoặc Email đã tồn tại!");
                    return false;
                }
            }
            return true;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (tbId.ReadOnly) { MessageBox.Show("Nhấn 'Làm mới' trước!"); return; }
            if (!IsValidData()) return;

            string sql = "INSERT INTO Students (Id, FullName, ClassId, Gender, Grade, BirthYear, Email, Address, Avatar) " +
                         "VALUES (@id, @name, @class, @gender, @grade, @by, @email, @address, @avatar)";
            ExecuteQuery(sql, true);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text)) return;
            if (!IsValidData(true)) return;

            string sql = "UPDATE Students SET FullName=@name, ClassId=@class, Gender=@gender, Grade=@grade, " +
                         "BirthYear=@by, Email=@email, Address=@address, Avatar=@avatar WHERE Id=@id";
            ExecuteQuery(sql, false);
        }

        private void ExecuteQuery(string sql, bool isNew)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", tbId.Text);
                    cmd.Parameters.AddWithValue("@name", tbName.Text);
                    cmd.Parameters.AddWithValue("@class", cbClass.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@gender", rbMale.Checked);
                    cmd.Parameters.AddWithValue("@grade", tbGrade.Text);
                    cmd.Parameters.AddWithValue("@by", dateTimePicker1.Value.Year);
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text);

                    cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar)).Value =
                        string.IsNullOrWhiteSpace(tbAddress.Text) ? (object)DBNull.Value : tbAddress.Text;

                    SqlParameter picParam = new SqlParameter("@avatar", SqlDbType.VarBinary);
                    picParam.Value = (currentAvatar == null) ? (object)DBNull.Value : currentAvatar;
                    cmd.Parameters.Add(picParam);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCustomer.Rows[e.RowIndex].Cells[0].Value == null) return;
            var row = dgvCustomer.Rows[e.RowIndex];
            tbId.Text = row.Cells[0].Value.ToString();
            tbId.ReadOnly = true;
            tbName.Text = row.Cells[1].Value.ToString();
            cbClass.SelectedItem = row.Cells[2].Value.ToString();
            rbMale.Checked = row.Cells[3].Value.ToString() == "Nam";
            rbFemale.Checked = !rbMale.Checked;
            tbGrade.Text = row.Cells[4].Value.ToString();

            string[] parts = row.Cells[5].Value.ToString().Split('/');
            if (parts.Length == 3 && int.TryParse(parts[2], out int year))
                dateTimePicker1.Value = new DateTime(year, 1, 1);

            tbEmail.Text = row.Cells[6].Value?.ToString() ?? "";
            tbEmail.ReadOnly = false;
            tbAddress.Text = row.Cells[7].Value?.ToString() ?? "";

            if (row.Cells[8].Value != DBNull.Value && row.Cells[8].Value != null)
            {
                currentAvatar = (byte[])row.Cells[8].Value;
                using (MemoryStream ms = new MemoryStream(currentAvatar)) { pbAvatar.Image = Image.FromStream(ms); }
            }
            else { pbAvatar.Image = null; currentAvatar = null; }
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet ws = wb.ActiveSheet;
                for (int i = 0; i < dgvCustomer.Columns.Count - 1; i++) ws.Cells[1, i + 1] = dgvCustomer.Columns[i].HeaderText;
                for (int i = 0; i < dgvCustomer.Rows.Count; i++)
                    for (int j = 0; j < dgvCustomer.Columns.Count - 1; j++)
                        ws.Cells[i + 2, j + 1] = dgvCustomer.Rows[i].Cells[j].Value?.ToString();
                app.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi Excel: " + ex.Message); }
        }

        private void btImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel|*.xlsx;*.xls" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Open(ofd.FileName);
                    Excel.Worksheet ws = wb.Sheets[1];
                    Excel.Range range = ws.UsedRange;
                    for (int i = 2; i <= range.Rows.Count; i++)
                    {
                        string exId = (range.Cells[i, 1] as Excel.Range).Text;
                        string exEmail = (range.Cells[i, 7] as Excel.Range).Text;
                        if (string.IsNullOrEmpty(exId)) continue;

                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Id=@id OR Email=@e", conn);
                            check.Parameters.AddWithValue("@id", exId);
                            check.Parameters.AddWithValue("@e", exEmail);
                            if ((int)check.ExecuteScalar() > 0) continue;

                            SqlCommand cmd = new SqlCommand("INSERT INTO Students (Id, FullName, ClassId, Gender, Grade, BirthYear, Email, Address) VALUES (@id, @n, @c, @g, @gr, @b, @e, @addr)", conn);
                            cmd.Parameters.AddWithValue("@id", exId);
                            cmd.Parameters.AddWithValue("@n", (range.Cells[i, 2] as Excel.Range).Text ?? "");
                            cmd.Parameters.AddWithValue("@c", (range.Cells[i, 3] as Excel.Range).Text ?? "");
                            cmd.Parameters.AddWithValue("@g", (range.Cells[i, 4] as Excel.Range).Text == "Nam");
                            cmd.Parameters.AddWithValue("@gr", (range.Cells[i, 5] as Excel.Range).Text ?? "0");
                            cmd.Parameters.AddWithValue("@b", (range.Cells[i, 6] as Excel.Range).Text ?? "2000");
                            cmd.Parameters.AddWithValue("@e", exEmail);

                            string addr = (range.Cells[i, 8] as Excel.Range).Text;
                            cmd.Parameters.AddWithValue("@addr", string.IsNullOrEmpty(addr) ? (object)DBNull.Value : addr);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    wb.Close(); app.Quit(); LoadData();
                    MessageBox.Show("Import hoàn tất!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi Import: " + ex.Message); }
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            currentAvatar = new byte[fs.Length];
                            fs.Read(currentAvatar, 0, (int)fs.Length);
                        }
                        using (MemoryStream ms = new MemoryStream(currentAvatar))
                        {
                            pbAvatar.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text)) return;
            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", tbId.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        private void btRead_Click(object sender, EventArgs e) { LoadData(); }
        private void btExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void Main_Load(object sender, EventArgs e) { }
    }
}