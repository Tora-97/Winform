using System;
using System.Windows.Forms;
using System.IO;

namespace Example02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\Winform\txt\Key_Logger.txt", true);
            sw.Write(e.KeyCode);
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấn nút OK!");
        }
    }
}