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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }
        // 1. Sự kiện khi check vào ô "Giảm giá"
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;  // Nếu check thì cho nhập số
            else
                tbDiscount.Enabled = false; // Bỏ check thì khóa ô nhập
        }

        // 2. Sự kiện bấm nút "Tính tiền"
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            // Kiểm tra giới tính
            if (rbMale.Checked == true)
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";

            // Kiểm tra giảm giá
            // Code trong Slide để cứng là 5, nhưng thực tế nên lấy từ ô nhập liệu
            if (ckDiscount.Checked == true)
            {
                // disc = 5; // Code gốc trong Slide 106

                // Code cải tiến: Lấy giá trị thực tế từ ô tbDiscount (nếu người dùng nhập 7)
                int.TryParse(tbDiscount.Text, out disc);
            }

            // Hiển thị kết quả
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // Sự kiện nút Thoát (Tự thêm)
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
