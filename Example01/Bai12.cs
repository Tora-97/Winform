using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example01
{
    public partial class Bai12 : Form
    {
        int count = 0;

        public Bai12()
        {
            InitializeComponent();
            if (cbFaculty.Items.Count > 0) cbFaculty.SelectedIndex = 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            count++;
            string name = tbName.Text;
            string dob = dtpDob.Value.ToShortDateString();
            string gender = rbMale.Checked ? "Nam" : "Nữ";
            string faculty = cbFaculty.SelectedItem.ToString();

            string info = count + ". " + name + "\n" +
                          "   -Giới tính: " + gender + "\n" +
                          "   -Ngày sinh: " + dob + "\n" +
                          "   -Khoa: " + faculty + "\n\n";

            rtbStatus.AppendText(info);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}