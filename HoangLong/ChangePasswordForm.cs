using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoangLong
{
    public partial class ChangePasswordForm : Form
    {
        string connStr = @"Server=DESKTOP-ETG0JM1;Database=QLSV;Trusted_Connection=True;TrustServerCertificate=True;";

        public ChangePasswordForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.White;

            txtCurrentPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;

            btnUpdate.BackColor = Color.ForestGreen;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnBack.BackColor = Color.Silver;
            btnBack.FlatStyle = FlatStyle.Flat;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Accounts WHERE Username=@u AND Password=@p", conn);
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtCurrentPass.Text);

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        SqlCommand up = new SqlCommand("UPDATE Accounts SET Password=@p WHERE Username=@u", conn);
                        up.Parameters.AddWithValue("@u", txtUsername.Text);
                        up.Parameters.AddWithValue("@p", txtNewPass.Text);
                        up.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else MessageBox.Show("Mật khẩu cũ không chính xác!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }
        private void ChangePasswordForm_Load(object sender, EventArgs e) { }
    }
}