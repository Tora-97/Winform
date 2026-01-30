using System;
using System.Windows.Forms;

namespace HoangLong
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm fLogin = new LoginForm();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}