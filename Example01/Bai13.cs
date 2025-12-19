using System;
using System.Windows.Forms;
using System.Collections; // Bắt buộc để dùng ArrayList

namespace Example01
{
    public partial class Bai13 : Form
    {
        public Bai13()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả (Theo Slide 123)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418; s.Name = "Giấc mơ Chapi"; s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616; s.Name = "Đôi mắt Pleiku"; s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172; s.Name = "Em muốn sống bên anh trọn đời"; s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        // 2. Sự kiện Form Load: Đổ dữ liệu vào ListBox (Theo Slide 124)
        // Bạn cần vào Design, click đúp vào tiêu đề Form để tạo hàm này nếu chưa có
        private void Bai13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Đổ dữ liệu Class vào ListBox
            lbSong.DataSource = lst;
            lbSong.DisplayMember = "Name"; // Chỉ hiển thị Tên bài hát
            lbSong.ValueMember = "Id";     // Giá trị ngầm là ID
        }

        // 3. Nút Chọn (>): Lấy thông tin chi tiết và đưa sang phải
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                // Ép kiểu item đang chọn từ Object về Class Song
                Song s = (Song)lbSong.SelectedItem;

                // Tạo chuỗi hiển thị đầy đủ: "Mã - Tên - Tác giả"
                string fullInfo = s.Id + " - " + s.Name + " - " + s.Author;

                // Thêm vào danh sách yêu thích
                lbFavorite.Items.Add(fullInfo);

                // LƯU Ý: Khi dùng DataSource, ta KHÔNG được dùng lbSong.Items.RemoveAt(...)
                // Nên bài này ta chỉ Copy sang thôi, không Xóa bên trái.
            }
        }

        // 4. Nút Chọn Tất Cả (>>): Duyệt và đưa hết sang phải
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các phần tử trong ListBox
            foreach (Song s in lbSong.Items)
            {
                string fullInfo = s.Id + " - " + s.Name + " - " + s.Author;
                lbFavorite.Items.Add(fullInfo);
            }
        }

        // 5. Nút Bỏ chọn (<): Xóa khỏi danh sách yêu thích
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                // Bên phải chỉ là chuỗi (String) bình thường nên xóa được
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // 6. Nút Bỏ chọn Tất cả (<<)
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            lbFavorite.Items.Clear();
        }

        // Sự kiện Click đúp (Giữ nguyên logic gọi lại nút bấm)
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btSelect_Click(sender, e);
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btDeselect_Click(sender, e);
        }

        private void Bai13_Load_1(object sender, EventArgs e)
        {
            // Lấy danh sách bài hát từ code
            ArrayList lst = GetData();

            // Đổ vào ListBox
            lbSong.DataSource = lst;       // Nguồn dữ liệu
            lbSong.DisplayMember = "Name"; // Chỉ hiện Tên bài hát
            lbSong.ValueMember = "Id";     // Giá trị ẩn là ID
        }
    }
}