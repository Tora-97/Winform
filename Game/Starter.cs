using System;
using System.Drawing; // Cần thư viện này để chỉnh Font
using System.Windows.Forms;

namespace CatchTheEggGame
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();

            // 1. Cho màn hình mở lên là Full luôn
            this.WindowState = FormWindowState.Maximized;

            // 2. Cài đặt ảnh nền co giãn
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // 3. Quan trọng: Chỉnh ảnh trong nút Start cũng co giãn theo nút
            btStart.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
            this.Hide();
            game.FormClosed += (s, args) => this.Show();
        }

        // --- HÀM TỰ ĐỘNG PHÓNG TO NÚT START ---
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Kiểm tra để tránh lỗi khi chưa vẽ xong nút
            if (btStart != null && this.ClientSize.Width > 0)
            {
                // 1. Tính toán kích thước nút dựa trên kích thước màn hình
                // Chiều rộng nút = 1/5 chiều rộng màn hình (20%)
                int newWidth = this.ClientSize.Width / 5;

                // Chiều cao nút = 1/2 chiều rộng nút (để giữ tỉ lệ hình chữ nhật đẹp)
                // Hoặc bạn có thể để = this.ClientSize.Height / 8;
                int newHeight = newWidth / 2;

                btStart.Size = new Size(newWidth, newHeight);

                // 2. Tính toán vị trí để nút luôn nằm GIỮA màn hình
                btStart.Left = (this.ClientSize.Width - btStart.Width) / 2;
                btStart.Top = (this.ClientSize.Height - btStart.Height) / 2;

                // 3. (Nâng cao) Phóng to cỡ CHỮ theo kích thước nút
                // Cỡ chữ = 1/4 chiều cao của nút
                float newFontSize = newHeight / 4;

                // Cập nhật Font mới
                btStart.Font = new Font(btStart.Font.FontFamily, newFontSize, FontStyle.Bold);
            }
        }
    }
}