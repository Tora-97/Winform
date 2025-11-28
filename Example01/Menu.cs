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
    }
}
