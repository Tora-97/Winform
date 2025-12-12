using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Bai8 : Form
    {
        // --- 1. KHAI BÁO BIẾN TOÀN CỤC (Slide 83) ---
        decimal memory = 0;        // Biến nhớ (cho MC, MR, MS...)
        decimal workingMemory = 0; // Biến lưu số hạng đầu tiên
        string opr = "";           // Biến lưu dấu phép tính (+, -, *, /)

        public Bai8()
        {
            InitializeComponent();

            // --- 2. GẮN SỰ KIỆN TỰ ĐỘNG (Slide 82) ---
            // Đoạn code này chạy vòng lặp, tìm tất cả nút bấm và nối chúng vào hàm Button_Click
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Click += new EventHandler(Button_Click);
                }
            }
        }

        // --- 3. HÀM XỬ LÝ CHUNG CHO TẤT CẢ CÁC NÚT (Button_Click) ---
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender; // Lấy nút vừa bị bấm

            // A. NHÓM SỐ VÀ DẤU CHẤM (0-9 và .) - Slide 84
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                // Nếu bấm dấu chấm mà màn hình đã có dấu chấm rồi thì thôi không thêm nữa
                if (bt.Text == "." && tbDisplay.Text.Contains("."))
                    return;

                tbDisplay.Text += bt.Text;
            }

            // B. NHÓM PHÉP TOÁN CƠ BẢN (+ - * /) - Slide 86
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(tbDisplay.Text);
                tbDisplay.Clear();
            }

            // C. NHÓM KẾT QUẢ (=) - Slide 87 & Slide 79
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(tbDisplay.Text);
                switch (opr)
                {
                    case "+": tbDisplay.Text = (workingMemory + secondValue).ToString(); break;
                    case "-": tbDisplay.Text = (workingMemory - secondValue).ToString(); break;
                    case "*": tbDisplay.Text = (workingMemory * secondValue).ToString(); break;
                    case "/":
                        if (secondValue != 0)
                            tbDisplay.Text = (workingMemory / secondValue).ToString();
                        else
                            MessageBox.Show("Lỗi chia cho 0");
                        break;
                }
            }

            // D. NHÓM TOÁN HỌC NÂNG CAO - Slide 88
            else if (bt.Text == "±") // Đổi dấu âm/dương
            {
                decimal val = decimal.Parse(tbDisplay.Text);
                tbDisplay.Text = (-val).ToString();
            }
            else if (bt.Text == "√") // Căn bậc 2
            {
                decimal val = decimal.Parse(tbDisplay.Text);
                tbDisplay.Text = ((decimal)Math.Sqrt((double)val)).ToString();
            }
            else if (bt.Text == "%") // Phần trăm
            {
                decimal val = decimal.Parse(tbDisplay.Text);
                tbDisplay.Text = (val / 100).ToString();
            }
            else if (bt.Text == "1/x") // Nghịch đảo
            {
                decimal val = decimal.Parse(tbDisplay.Text);
                tbDisplay.Text = (1 / val).ToString();
            }

            // E. NHÓM XÓA VÀ BỘ NHỚ - Slide 85, 89, 90
            else if (bt.Text == "←") // Backspace: Xóa 1 ký tự cuối
            {
                if (tbDisplay.TextLength > 0)
                    tbDisplay.Text = tbDisplay.Text.Remove(tbDisplay.TextLength - 1);
            }
            else if (bt.Text == "C") // Xóa tất cả, reset biến
            {
                workingMemory = 0;
                opr = "";
                tbDisplay.Clear();
            }
            else if (bt.Text == "CE") // Chỉ xóa số đang nhập
            {
                tbDisplay.Clear();
            }
            // Các nút Memory (Bộ nhớ)
            else if (bt.Text == "MC") memory = 0; // Xóa bộ nhớ
            else if (bt.Text == "MR") tbDisplay.Text = memory.ToString(); // Gọi bộ nhớ ra
            else if (bt.Text == "MS") { memory = decimal.Parse(tbDisplay.Text); tbDisplay.Clear(); } // Lưu vào bộ nhớ
            else if (bt.Text == "M+") memory += decimal.Parse(tbDisplay.Text); // Cộng dồn vào bộ nhớ
            else if (bt.Text == "M-") memory -= decimal.Parse(tbDisplay.Text); // Trừ bớt bộ nhớ
        }
    }
}