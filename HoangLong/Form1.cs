using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoangLong
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=.;Database=sale;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvCustomer.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name, class, gender, birthyear FROM SinhVien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        bool genderBit = reader.IsDBNull(3) ? false : reader.GetBoolean(3);
                        string genderText = genderBit ? "Male" : "Female";

                        string dateDisplay = reader.IsDBNull(4) ? "" : Convert.ToDateTime(reader[4]).ToShortDateString();

                        dgvCustomer.Rows.Add(
                            reader[0],
                            reader[1],
                            reader[2],
                            genderText,
                            dateDisplay
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message);
            }
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0 || dgvCustomer.Rows[idx].Cells[0].Value == null) return;

            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
            tbClass.Text = dgvCustomer.Rows[idx].Cells[2].Value.ToString();

            string genderValue = dgvCustomer.Rows[idx].Cells[3].Value?.ToString();
            if (genderValue == "Male") rbMale.Checked = true;
            else rbFemale.Checked = true;

            string dateValue = dgvCustomer.Rows[idx].Cells[4].Value?.ToString();
            if (DateTime.TryParse(dateValue, out DateTime dt))
            {
                dateTimePicker1.Value = dt;
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(tbId.Text) || !int.TryParse(tbId.Text, out _))
            {
                MessageBox.Show("Mã sinh viên phải là số!");
                tbId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Tên không được để trống!");
                tbName.Focus();
                return false;
            }
            return true;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            int id = int.Parse(tbId.Text);
            if (IsIdExists(id))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại! Vui lòng nhập mã khác.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbId.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO SinhVien (id, name, class, gender, birthyear) " +
                                   "VALUES (@id, @name, @class, @gender, @by)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", tbName.Text);
                    cmd.Parameters.AddWithValue("@class", tbClass.Text);
                    cmd.Parameters.AddWithValue("@gender", rbMale.Checked);
                    cmd.Parameters.AddWithValue("@by", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                }
                string genderText = rbMale.Checked ? "Male" : "Female";
                dgvCustomer.Rows.Add(id, tbName.Text, tbClass.Text, genderText, dateTimePicker1.Value.ToShortDateString());

                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE SinhVien SET name=@name, class=@class, gender=@gender, birthyear=@by WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(tbId.Text));
                    cmd.Parameters.AddWithValue("@name", tbName.Text);
                    cmd.Parameters.AddWithValue("@class", tbClass.Text);
                    cmd.Parameters.AddWithValue("@gender", rbMale.Checked);
                    cmd.Parameters.AddWithValue("@by", dateTimePicker1.Value);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        if (dgvCustomer.CurrentRow != null)
                        {
                            int idx = dgvCustomer.CurrentRow.Index;
                            dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
                            dgvCustomer.Rows[idx].Cells[2].Value = tbClass.Text;
                            dgvCustomer.Rows[idx].Cells[3].Value = rbMale.Checked ? "Male" : "Female";
                            dgvCustomer.Rows[idx].Cells[4].Value = dateTimePicker1.Value.ToShortDateString();
                        }
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text)) return;

            DialogResult dr = MessageBox.Show("Xác nhận xóa sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", tbId.Text);
                        cmd.ExecuteNonQuery();
                    }

                    if (dgvCustomer.CurrentRow != null)
                        dgvCustomer.Rows.RemoveAt(dgvCustomer.CurrentRow.Index);

                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
        private bool IsIdExists(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SinhVien WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}