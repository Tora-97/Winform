using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Example01
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            this.btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // Định vị ô Kết quả giãn đều theo 4 phía (Trên, Dưới, Trái, Phải)
            this.tbKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Cài đặt vị trí xuất hiện của Form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đặt tiêu đề cho Form (Lưu ý: Slide ghi sai chính tả là "Caculator", đúng là "Calculator")
            this.Text = "Caculator";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text); // Ép kiểu dữ liệu nhập vào thành số nguyên
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;

            // Cộng dồn kết quả vào ô hiển thị. 
            // "\r\n" nghĩa là xuống dòng.
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        // 2. Xử lý nút NHÂN
        private void btnMul_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;

            // Hiển thị phép nhân và xuống dòng
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        // 3. Xử lý nút LƯU
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tạo file tên là "Caculator.txt"
            // Tham số 'true' nghĩa là ghi nối tiếp (append). 
            // Nếu để 'false', nó sẽ xóa nội dung cũ và ghi mới.
            StreamWriter sw = new StreamWriter("Caculator.txt", true);

            sw.Write(tbKetQua.Text); // Ghi toàn bộ nội dung trong ô kết quả vào file

            sw.Close(); // Quan trọng: Phải đóng file sau khi ghi xong

            MessageBox.Show("Đã lưu thành công!"); // Thông báo cho người dùng
        }

        // 4. Xử lý nút THOÁT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form
        }
    }
}
