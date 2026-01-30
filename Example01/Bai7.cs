using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Bai7 : Form
    {
        // Biến lưu trữ tạm thời
        decimal workingMemory = 0;
        string opr = "";

        public Bai7()
        {
            InitializeComponent();
        }

        // --- Xử lý bấm số ---
        private void btn0_Click(object sender, EventArgs e) { tbDisplay.Text += btn0.Text; }
        private void btn1_Click(object sender, EventArgs e) { tbDisplay.Text += btn1.Text; }
        private void btn2_Click(object sender, EventArgs e) { tbDisplay.Text += btn2.Text; }
        private void btn3_Click(object sender, EventArgs e) { tbDisplay.Text += btn3.Text; }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Chỉ cho phép nhập 1 dấu chấm
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += btnDot.Text;
            }
        }

        // --- Xử lý phép toán ---
        private void btnPlus_Click(object sender, EventArgs e)
        {
            opr = "+";
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            opr = "*";
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // --- Xử lý dấu bằng ---
        private void btnEqual_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            if (opr == "+")
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                tbDisplay.Text = (workingMemory * secondValue).ToString();
        }
    }
}