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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự KHÔNG phải là số (IsDigit)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            // 1. Lấy chuỗi trong TextBox và đổi sang số
            // (Lưu ý: Để an toàn nên dùng int.TryParse, nhưng ở đây ta làm theo slide dùng int.Parse)
            int year = int.Parse(tbYear.Text);

            // 2. Kiểm tra điều kiện: Nếu năm lớn hơn 2000 là SAI quy định
            if (year > 2000)
            {
                // 3. Giữ chân người dùng lại, không cho rời khỏi ô này
                e.Cancel = true;
                MessageBox.Show("Năm phải nhỏ hơn hoặc bằng 2000!");
            }
        }
    }
}
