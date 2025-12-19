using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO; // Thêm thư viện này để xử lý đường dẫn thông minh hơn

namespace CatchTheEggGame
{
    public partial class FormGame : Form
    {
        bool goLeft, goRight;
        int eggSpeed;
        int chickenSpeed;
        int score = 0;
        int level = 1;
        string currentMusic = "";
        Random rnd = new Random();

        public FormGame()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            picEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            picBasket.SizeMode = PictureBoxSizeMode.StretchImage;

            picChicken.BackColor = Color.Transparent;
            picEgg.BackColor = Color.Transparent;
            picBasket.BackColor = Color.Transparent;

            picChicken.Size = new Size(180, 150);
            picBasket.Size = new Size(150, 150);
            picEgg.Size = new Size(90, 105);

            gameTimer.Interval = 20;

            lblScore.AutoSize = true;
            lblScore.Font = new Font("Arial", 16, FontStyle.Bold);
            lblScore.BackColor = Color.Transparent;
            lblScore.ForeColor = Color.Red;

            gameTimer.Tick += GameTimerEvent;
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;

            gameTimer.Enabled = false;
            SetupLevel(1);
        }

        private void SetupLevel(int lvl)
        {
            level = lvl;
            string imagePath = "";
            string musicPath = "";
            string chickenPath = "";

            // --- ĐƯỜNG DẪN TƯƠNG ĐỐI (DATA) ---
            // Chúng ta không dùng C:\... nữa mà dùng "DATA\..."
            switch (level)
            {
                case 1:
                    eggSpeed = 5; chickenSpeed = 3;
                    imagePath = @"DATA\Images\round1.png";
                    musicPath = @"DATA\Music\man1.mp3";
                    chickenPath = @"DATA\Images\chicken1.png";
                    break;
                case 2:
                    eggSpeed = 8; chickenSpeed = 5;
                    imagePath = @"DATA\Images\round2.png";
                    musicPath = @"DATA\Music\man2.mp3";
                    chickenPath = @"DATA\Images\chicken2.png";
                    break;
                case 3:
                    eggSpeed = 12; chickenSpeed = 7;
                    imagePath = @"DATA\Images\round3.png";
                    musicPath = @"DATA\Music\man3.mp3";
                    chickenPath = @"DATA\Images\chicken3.png";
                    break;
                case 4:
                    eggSpeed = 16; chickenSpeed = 9;
                    imagePath = @"DATA\Images\round4.png";
                    musicPath = @"DATA\Music\man3.mp3";
                    chickenPath = @"DATA\Images\chicken4.png";
                    break;
                case 5:
                    eggSpeed = 20; chickenSpeed = 12;
                    imagePath = @"DATA\Images\round5.png";
                    musicPath = @"DATA\Music\man3.mp3";
                    chickenPath = @"DATA\Images\chicken4.png";
                    break;
            }

            // Xử lý nhạc
            if (musicPath != currentMusic)
            {
                try
                {
                    // Kiểm tra file tồn tại trước khi phát để tránh lỗi
                    if (File.Exists(musicPath))
                    {
                        MusicPlayer.PlayBackground(musicPath);
                        currentMusic = musicPath;
                    }
                }
                catch { }
            }

            // Xử lý ảnh nền
            try
            {
                if (File.Exists(imagePath))
                {
                    this.BackgroundImage = Image.FromFile(imagePath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch { }

            // Xử lý ảnh gà
            try
            {
                if (File.Exists(chickenPath))
                {
                    picChicken.Image = Image.FromFile(chickenPath);
                }
            }
            catch { }

            picChicken.Top = this.ClientSize.Height / 5;

            ResetEgg();
            if (gameTimer.Enabled == false) gameTimer.Start();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score + "  |  Level: " + level;
            lblScore.Left = this.ClientSize.Width - lblScore.Width - 20;
            lblScore.Top = 20;

            picChicken.Left += chickenSpeed;

            if (picChicken.Left <= 0 || picChicken.Left + picChicken.Width >= this.ClientSize.Width)
            {
                chickenSpeed = -chickenSpeed;
            }
            else if (rnd.Next(0, 100) < 2)
            {
                chickenSpeed = -chickenSpeed;
            }

            if (goLeft == true && picBasket.Left > 0) picBasket.Left -= 15;
            if (goRight == true && picBasket.Left + picBasket.Width < this.ClientSize.Width) picBasket.Left += 15;

            picEgg.Top += eggSpeed;

            if (picEgg.Top + picEgg.Height > this.ClientSize.Height)
            {
                GameOver();
            }

            if (picEgg.Bounds.IntersectsWith(picBasket.Bounds))
            {
                score++;
                try
                {
                    if (File.Exists(@"DATA\Music\egg.mp3"))
                        MusicPlayer.PlaySoundEffect(@"DATA\Music\egg.mp3");
                }
                catch { }

                if (score == 50)
                {
                    Victory();
                }
                else if (score % 10 == 0)
                {
                    SetupLevel(level + 1);
                }

                ResetEgg();
            }
        }

        private void Victory()
        {
            gameTimer.Stop();
            try { MusicPlayer.StopBackground(); } catch { }

            try
            {
                if (File.Exists(@"DATA\Music\victory.mp3"))
                    MusicPlayer.PlayBackground(@"DATA\Music\victory.mp3");
            }
            catch { }

            try
            {
                if (File.Exists(@"DATA\Images\victory.png"))
                    this.BackgroundImage = Image.FromFile(@"DATA\Images\victory.png");
            }
            catch { }

            picChicken.Visible = false;
            picEgg.Visible = false;
            picBasket.Visible = false;
            lblScore.Visible = false;

            MessageBox.Show("CHÚC MỪNG! BẠN ĐÃ CHIẾN THẮNG TOÀN BỘ GAME!", "Victory!");
            this.Close();
        }

        private void ResetEgg()
        {
            picEgg.Top = picChicken.Top + picChicken.Height;
            picEgg.Left = picChicken.Left + (picChicken.Width / 2) - (picEgg.Width / 2);
        }

        private void GameOver()
        {
            gameTimer.Stop();
            try { MusicPlayer.StopBackground(); } catch { }

            DialogResult kqua = MessageBox.Show("Game Over! Chơi lại từ đầu không?", "Thua rồi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kqua == DialogResult.Yes) RestartGame();
            else this.Close();
        }

        private void RestartGame()
        {
            score = 0;
            currentMusic = "";
            picChicken.Visible = true;
            picEgg.Visible = true;
            picBasket.Visible = true;
            lblScore.Visible = true;

            SetupLevel(1);
            this.Focus();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public static class MusicPlayer
        {
            [System.Runtime.InteropServices.DllImport("winmm.dll")]
            private static extern long mciSendString(string strCommand, System.Text.StringBuilder strReturn, int iReturnLength, System.IntPtr hwndCallback);

            public static void PlayBackground(string path)
            {
                StopBackground();
                // Đường dẫn tương đối cần được chuyển thành tuyệt đối để Windows Media chơi được
                string fullPath = Path.GetFullPath(path);

                string cmdOpen = "open \"" + fullPath + "\" type mpegvideo alias BgMusic";
                mciSendString(cmdOpen, null, 0, System.IntPtr.Zero);
                mciSendString("play BgMusic repeat", null, 0, System.IntPtr.Zero);
            }

            public static void StopBackground()
            {
                mciSendString("close BgMusic", null, 0, System.IntPtr.Zero);
            }

            public static void PlaySoundEffect(string path)
            {
                string fullPath = Path.GetFullPath(path);
                string cmdOpen = "open \"" + fullPath + "\" type mpegvideo alias SFX";
                mciSendString(cmdOpen, null, 0, System.IntPtr.Zero);
                mciSendString("play SFX from 0", null, 0, System.IntPtr.Zero);
            }
        }
    }
}