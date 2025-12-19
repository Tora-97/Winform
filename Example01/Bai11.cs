using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi bấm nút OK (Theo Slide 110)
        private void btOk_Click(object sender, EventArgs e)
        {
            // Hiển thị ngày dạng Dài (LongDate) lên tiêu đề Form
            // Ví dụ: "Saturday, September 30, 2017"
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // 2. Sự kiện khi thay đổi ngày trực tiếp trên DateTimePicker (Theo Slide 110)
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Hiển thị ngày dạng Ngắn (ShortDate) lên tiêu đề Form
            // Ví dụ: "30/09/2017"
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}