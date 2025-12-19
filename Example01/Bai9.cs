using System;
using System.Collections; // Bắt buộc để dùng ArrayList
using System.Windows.Forms;

namespace Example01
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả (Slide 100)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01"; f.Name = "Công nghệ thông tin"; f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02"; f.Name = "Quản trị kinh doanh"; f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; f.Name = "Kế toán tài chính"; f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // 2. Sự kiện khi Form vừa hiện lên (Form Load)
        private void Bai9_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            cb_Faculty.DataSource = lst;       // Nguồn dữ liệu
            cb_Faculty.DisplayMember = "Name"; // Hiển thị tên khoa
            cb_Faculty.ValueMember = "Id";     // Giá trị ngầm là Mã khoa (Quan trọng!)
        }

        // 3. Sự kiện chọn: Lấy Mã Khoa (Id)
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu ComboBox đã có dữ liệu và đang chọn 1 dòng
            if (cb_Faculty.SelectedValue != null)
            {
                // Vì ValueMember ở trên đã set là "Id", nên SelectedValue sẽ trả về Id (K01, K02...)
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }

        // 4. Sự kiện nút OK: Lấy Tên Khoa (Name)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Cách 1: Theo Slide (Đổi ValueMember)
            // cb_Faculty.ValueMember = "Name"; 
            // string name = cb_Faculty.SelectedValue.ToString();

            // Cách 2 (Chuẩn hơn): Lấy trực tiếp từ Object đang chọn
            Faculty selectedFac = (Faculty)cb_Faculty.SelectedItem;
            string name = selectedFac.Name;

            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
        }
    }
}