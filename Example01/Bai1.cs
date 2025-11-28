using System;
using System.Drawing; // Để dùng Point
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Example01
{
    public partial class Bai1 : Form
    {
        string path = @"D:\form.xml";

        // Khai báo biến toàn cục để dùng chung
        InfoWindows iw = new InfoWindows();

        public Bai1()
        {
            InitializeComponent();
        }

        // --- Các hàm Write/Read giữ nguyên ---
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch { /* Bỏ qua lỗi nếu không ghi được */ }
        }

        public InfoWindows Read()
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch
            {
                return null; // Nếu lỗi (ví dụ chưa có file) thì trả về null
            }
        }

        // --- Sự kiện khi MỞ Form (Load) ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đọc file lên
            InfoWindows savedInfo = Read();

            // Kiểm tra xem có dữ liệu cũ không, nếu có thì mới gán
            if (savedInfo != null)
            {
                this.Width = savedInfo.Width;
                this.Height = savedInfo.Height;

                // Khôi phục vị trí cũ (Slide 39)
                this.Location = savedInfo.Location;
            }
        }

        // --- Sự kiện khi TẮT Form (FormClosing) - Thay thế ResizeEnd ---
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lấy kích thước và vị trí NGAY LÚC ĐANG TẮT
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location; // Lấy vị trí hiện tại

            // Ghi xuống file
            Write(iw);
        }
    }
}