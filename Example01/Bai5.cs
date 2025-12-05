using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ TextBox và ép kiểu sang số nguyên (int)
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);

            // 2. Tính toán
            int kq = x + y;

            // 3. Hiển thị kết quả (Phải đổi ngược từ số sang chữ bằng .ToString)
            tbKetQua.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);

            int kq = x * y;

            tbKetQua.Text = kq.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.Close();
        }
    }
}
