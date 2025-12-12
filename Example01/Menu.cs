using Example02;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Bai1 ex1 = new Bai1();
            ex1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Bai2 ex2 = new Bai2();
            ex2.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Bai3 ex3 = new Bai3();
            ex3.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Bai4 ex4 = new Bai4();
            ex4.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Bai5 ex5 = new Bai5();
            ex5.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Bai6 ex6 = new Bai6();
            ex6.Show();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Bai7 ex7 = new Bai7();
            ex7.Show();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Bai8 ex8 = new Bai8();
            ex8.Show();
        }
    }
}
