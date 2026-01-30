using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoangLong
{
    public partial class LoginForm : Form
    {
        string connStr = @"Server=DESKTOP-ETG0JM1;Database=QLSV;Trusted_Connection=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
            StyleForm();
            this.AcceptButton = btnLogin;
        }

        private void StyleForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Login - Quản Lý Sinh Viên";
            this.BackColor = Color.White;

            txtPass.UseSystemPasswordChar = true;

            btnLogin.BackColor = Color.FromArgb(63, 81, 181);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;

            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(120, 120, 120);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(230, 230, 230);

            btnOpenChangePass.FlatStyle = FlatStyle.Flat;
            btnOpenChangePass.FlatAppearance.BorderSize = 0;
            btnOpenChangePass.ForeColor = Color.Gray;
            btnOpenChangePass.Font = new Font("Segoe UI", 8, FontStyle.Underline);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text)) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Accounts WHERE Username=@user AND Password=@pass";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", txtUser.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void btnOpenChangePass_Click(object sender, EventArgs e) { new ChangePasswordForm().ShowDialog(); }
        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}