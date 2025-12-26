//using System;
//using System.Drawing;
//using System.Windows.Forms;
//using System.IO;
//using System.Drawing.Text;

//namespace CatchTheEggGame
//{
//    public partial class FormGame : Form
//    {
//        bool goLeft, goRight;

//        // --- BIẾN TỐC ĐỘ ---
//        int baseEggSpeed;
//        int eggSpeedY;
//        int eggSpeedX;

//        int chickenSpeed;
//        int score = 0;
//        int level = 1;
//        string currentMusic = "";
//        Random rnd = new Random();

//        System.Windows.Forms.Timer transitionTimer = new System.Windows.Forms.Timer();
//        int nextLevelPending = 1;
//        bool isFadingOut = true;

//        Form fBlack = new Form();
//        PictureBox picBoard = new PictureBox();
//        Font customFont = new Font("Comic Sans MS", 14, FontStyle.Bold);

//        public FormGame()
//        {
//            InitializeComponent();

//            this.DoubleBuffered = true;
//            this.SetStyle(ControlStyles.UserPaint |
//                          ControlStyles.AllPaintingInWmPaint |
//                          ControlStyles.OptimizedDoubleBuffer, true);
//            this.UpdateStyles();

//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.WindowState = FormWindowState.Maximized;
//            this.BackgroundImageLayout = ImageLayout.Stretch;

//            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
//            picEgg.SizeMode = PictureBoxSizeMode.StretchImage;
//            picBasket.SizeMode = PictureBoxSizeMode.StretchImage;

//            picChicken.BackColor = Color.Transparent;
//            picEgg.BackColor = Color.Transparent;
//            picBasket.BackColor = Color.Transparent;

//            picChicken.Size = new Size(180, 150);
//            picBasket.Size = new Size(150, 150);
//            picEgg.Size = new Size(60, 75);

//            picBoard.SizeMode = PictureBoxSizeMode.StretchImage;
//            picBoard.BackColor = Color.Transparent;
//            picBoard.Size = new Size(250, 120);
//            picBoard.Paint += PicBoard_Paint;
//            this.Controls.Add(picBoard);
//            picBoard.BringToFront();

//            gameTimer.Interval = 20;
//            gameTimer.Tick += GameTimerEvent;

//            transitionTimer.Interval = 20;
//            transitionTimer.Tick += TransitionTimerEvent;

//            lblScore.Visible = false;

//            this.KeyDown += KeyIsDown;
//            this.KeyUp += KeyIsUp;

//            gameTimer.Enabled = false;
//            SetupLevel(1);
//        }

//        private void PicBoard_Paint(object sender, PaintEventArgs e)
//        {
//            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
//            string textLine1 = "LEVEL " + level;
//            string textLine2 = "SCORE: " + score;

//            float x1 = (picBoard.Width - e.Graphics.MeasureString(textLine1, customFont).Width) / 2;
//            float x2 = (picBoard.Width - e.Graphics.MeasureString(textLine2, customFont).Width) / 2;
//            float y1 = 25;
//            float y2 = 60;

//            e.Graphics.DrawString(textLine1, customFont, Brushes.Black, x1 + 2, y1 + 2);
//            e.Graphics.DrawString(textLine2, customFont, Brushes.Black, x2 + 2, y2 + 2);
//            e.Graphics.DrawString(textLine1, customFont, Brushes.Yellow, x1, y1);
//            e.Graphics.DrawString(textLine2, customFont, Brushes.White, x2, y2);
//        }

//        private void StartLevelTransition(int nextLvl)
//        {
//            gameTimer.Stop();
//            nextLevelPending = nextLvl;
//            isFadingOut = true;

//            fBlack.BackColor = Color.Black;
//            fBlack.FormBorderStyle = FormBorderStyle.None;
//            fBlack.ShowInTaskbar = false;
//            fBlack.WindowState = FormWindowState.Maximized;
//            fBlack.TopMost = false;
//            fBlack.Show();

//            this.BringToFront();
//            this.Focus();

//            transitionTimer.Start();
//        }

//        private void TransitionTimerEvent(object sender, EventArgs e)
//        {
//            if (isFadingOut)
//            {
//                this.Opacity -= 0.05;
//                if (this.Opacity <= 0)
//                {
//                    this.Opacity = 0;
//                    isFadingOut = false;
//                    SetupLevel(nextLevelPending);
//                }
//            }
//            else
//            {
//                this.Opacity += 0.05;
//                if (this.Opacity >= 1)
//                {
//                    this.Opacity = 1;
//                    transitionTimer.Stop();
//                    fBlack.Hide();
//                    gameTimer.Start();
//                }
//            }
//        }

//        private void SetupLevel(int lvl)
//        {
//            level = lvl;
//            string imagePath = "";
//            string musicPath = "";
//            string chickenPath = "";
//            string boardPath = @"DATA\Images\board.png";

//            switch (level)
//            {
//                case 1:
//                    baseEggSpeed = 10; chickenSpeed = 3;
//                    imagePath = @"DATA\Images\round1.png";
//                    musicPath = @"DATA\Music\nhac.mp3";
//                    chickenPath = @"DATA\Images\chicken1.png";
//                    break;
//                case 2:
//                    baseEggSpeed = 13; chickenSpeed = 5;
//                    imagePath = @"DATA\Images\round2.png";
//                    musicPath = @"DATA\Music\nhac.mp3";
//                    chickenPath = @"DATA\Images\chicken2.png";
//                    break;
//                case 3:
//                    baseEggSpeed = 16; chickenSpeed = 7;
//                    imagePath = @"DATA\Images\round3.png";
//                    musicPath = @"DATA\Music\nhac.mp3";
//                    chickenPath = @"DATA\Images\chicken3.png";
//                    break;
//                case 4:
//                    baseEggSpeed = 19; chickenSpeed = 9;
//                    imagePath = @"DATA\Images\round4.png";
//                    musicPath = @"DATA\Music\nhac.mp3";
//                    chickenPath = @"DATA\Images\chicken4.png";
//                    break;
//                case 5:
//                    baseEggSpeed = 22; chickenSpeed = 12;
//                    imagePath = @"DATA\Images\round5.png";
//                    musicPath = @"DATA\Music\nhac.mp3";
//                    chickenPath = @"DATA\Images\chicken4.png";
//                    break;
//            }

//            if (musicPath != currentMusic)
//            {
//                try
//                {
//                    if (File.Exists(musicPath))
//                    {
//                        MusicPlayer.PlayBackground(musicPath);
//                        currentMusic = musicPath;
//                    }
//                }
//                catch { }
//            }

//            try
//            {
//                if (File.Exists(imagePath))
//                {
//                    this.BackgroundImage = Image.FromFile(imagePath);
//                    this.BackgroundImageLayout = ImageLayout.Stretch;
//                }
//            }
//            catch { }

//            try
//            {
//                if (File.Exists(chickenPath)) picChicken.Image = Image.FromFile(chickenPath);
//            }
//            catch { }

//            try
//            {
//                if (File.Exists(boardPath)) picBoard.Image = Image.FromFile(boardPath);
//            }
//            catch { }

//            try
//            {
//                if (File.Exists(@"DATA\Images\egg.png"))
//                    picEgg.Image = Image.FromFile(@"DATA\Images\egg.png");
//            }
//            catch { }

//            picChicken.Top = this.ClientSize.Height / 8;
//            ResetEgg();

//            if (transitionTimer.Enabled == false && this.Opacity == 1)
//            {
//                gameTimer.Start();
//            }
//        }

//        private void GameTimerEvent(object sender, EventArgs e)
//        {
//            picBoard.Left = this.ClientSize.Width - picBoard.Width - 20;
//            picBoard.Top = 20;
//            picBoard.Invalidate();

//            picChicken.Left += chickenSpeed;
//            if (picChicken.Left <= 0 || picChicken.Left + picChicken.Width >= this.ClientSize.Width)
//            {
//                chickenSpeed = -chickenSpeed;
//            }
//            else if (rnd.Next(0, 100) < 2)
//            {
//                chickenSpeed = -chickenSpeed;
//            }

//            if (goLeft == true && picBasket.Left > 0) picBasket.Left -= 15;
//            if (goRight == true && picBasket.Left + picBasket.Width < this.ClientSize.Width) picBasket.Left += 15;

//            picEgg.Top += eggSpeedY;
//            picEgg.Left += eggSpeedX;

//            if (picEgg.Left <= 0 || picEgg.Left + picEgg.Width >= this.ClientSize.Width)
//            {
//                eggSpeedX = -eggSpeedX;
//            }

//            if (picEgg.Top + picEgg.Height > this.ClientSize.Height)
//            {
//                GameOverWithEffect();
//            }

//            if (picEgg.Bounds.IntersectsWith(picBasket.Bounds))
//            {
//                score++;
//                try
//                {
//                    if (File.Exists(@"DATA\Music\egg.mp3"))
//                        MusicPlayer.PlaySoundEffect(@"DATA\Music\egg.mp3");
//                }
//                catch { }

//                if (score == 70) Victory();
//                else if (score == 10) StartLevelTransition(2);
//                else if (score == 25) StartLevelTransition(3);
//                else if (score == 40) StartLevelTransition(4);
//                else if (score == 55) StartLevelTransition(5);

//                ResetEgg();
//            }
//        }

//        private void GameOverWithEffect()
//        {
//            gameTimer.Stop();
//            try { MusicPlayer.StopBackground(); } catch { }

//            try
//            {
//                if (File.Exists(@"DATA\Images\broken_egg.png"))
//                {
//                    picEgg.Image = Image.FromFile(@"DATA\Images\broken_egg.png");
//                }
//            }
//            catch { }

//            picEgg.Top = this.ClientSize.Height - picEgg.Height - 10;
//            Application.DoEvents();
//            System.Threading.Thread.Sleep(500);

//            DialogResult kqua = MessageBox.Show("Game Over! Trứng vỡ rồi! Chơi lại không?", "Thua rồi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

//            if (kqua == DialogResult.Yes) RestartGame();
//            else this.Close();
//        }

//        private void ResetEgg()
//        {
//            try
//            {
//                if (File.Exists(@"DATA\Images\egg.png"))
//                    picEgg.Image = Image.FromFile(@"DATA\Images\egg.png");
//            }
//            catch { }

//            picEgg.Top = picChicken.Top + picChicken.Height;
//            picEgg.Left = picChicken.Left + (picChicken.Width / 2) - (picEgg.Width / 2);
//            double minAngle = (Math.PI / 2) - (Math.PI / 8);
//            double angleRange = Math.PI / 4;

//            double angle = minAngle + (rnd.NextDouble() * angleRange);

//            eggSpeedX = (int)(baseEggSpeed * Math.Cos(angle));
//            eggSpeedY = (int)(baseEggSpeed * Math.Sin(angle));

//            // Đảm bảo tốc độ rơi tối thiểu
//            if (eggSpeedY < 3) eggSpeedY = 3;
//        }

//        private void Victory()
//        {
//            gameTimer.Stop();
//            try { MusicPlayer.StopBackground(); } catch { }

//            try
//            {
//                if (File.Exists(@"DATA\Music\victory.mp3"))
//                    MusicPlayer.PlayBackground(@"DATA\Music\victory.mp3");
//            }
//            catch { }

//            try
//            {
//                if (File.Exists(@"DATA\Images\victory.png"))
//                    this.BackgroundImage = Image.FromFile(@"DATA\Images\victory.png");
//            }
//            catch { }

//            picChicken.Visible = false;
//            picEgg.Visible = false;
//            picBasket.Visible = false;
//            picBoard.Visible = false;

//            MessageBox.Show("CHÚC MỪNG! BẠN ĐÃ CHIẾN THẮNG!", "Victory!");
//            this.Close();
//        }

//        private void RestartGame()
//        {
//            score = 0;
//            currentMusic = "";
//            this.Opacity = 1;
//            fBlack.Hide();

//            picChicken.Visible = true;
//            picEgg.Visible = true;
//            picBasket.Visible = true;
//            picBoard.Visible = true;

//            SetupLevel(1);
//            gameTimer.Start();
//            this.Focus();
//        }

//        private void KeyIsDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Left) goLeft = true;
//            if (e.KeyCode == Keys.Right) goRight = true;
//        }

//        private void KeyIsUp(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Left) goLeft = false;
//            if (e.KeyCode == Keys.Right) goRight = false;
//        }

//        protected override CreateParams CreateParams
//        {
//            get
//            {
//                CreateParams handleParam = base.CreateParams;
//                handleParam.ExStyle |= 0x02000000;
//                return handleParam;
//            }
//        }

//        public static class MusicPlayer
//        {
//            [System.Runtime.InteropServices.DllImport("winmm.dll")]
//            private static extern long mciSendString(string strCommand, System.Text.StringBuilder strReturn, int iReturnLength, System.IntPtr hwndCallback);

//            public static void PlayBackground(string path)
//            {
//                StopBackground();
//                string fullPath = Path.GetFullPath(path);
//                string cmdOpen = "open \"" + fullPath + "\" type mpegvideo alias BgMusic";
//                mciSendString(cmdOpen, null, 0, System.IntPtr.Zero);
//                mciSendString("play BgMusic repeat", null, 0, System.IntPtr.Zero);
//                mciSendString("setaudio BgMusic volume to 200", null, 0, System.IntPtr.Zero);
//            }

//            public static void StopBackground()
//            {
//                mciSendString("close BgMusic", null, 0, System.IntPtr.Zero);
//            }

//            public static void PlaySoundEffect(string path)
//            {
//                string fullPath = Path.GetFullPath(path);
//                string cmdOpen = "open \"" + fullPath + "\" type mpegvideo alias SFX";
//                mciSendString(cmdOpen, null, 0, System.IntPtr.Zero);
//                mciSendString("play SFX from 0", null, 0, System.IntPtr.Zero);
//                mciSendString("setaudio SFX volume to 800", null, 0, System.IntPtr.Zero);
//            }
//        }
//    }
//}
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace CatchTheEggGame
{
    public partial class FormGame : Form
    {
        bool goLeft, goRight;

        // --- BIẾN TỐC ĐỘ ---
        int baseEggSpeed;
        int eggSpeedY;
        int eggSpeedX;

        int chickenSpeed;
        int score = 0;
        int level = 1;
        string currentMusic = "";
        Random rnd = new Random();

        System.Windows.Forms.Timer transitionTimer = new System.Windows.Forms.Timer();
        int nextLevelPending = 1;
        bool isFadingOut = true;

        Form fBlack = new Form();
        PictureBox picBoard = new PictureBox();
        Font customFont = new Font("Comic Sans MS", 14, FontStyle.Bold);

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
            picEgg.Size = new Size(60, 75);

            picBoard.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoard.BackColor = Color.Transparent;
            picBoard.Size = new Size(250, 120);
            picBoard.Paint += PicBoard_Paint;
            this.Controls.Add(picBoard);
            picBoard.BringToFront();

            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;

            transitionTimer.Interval = 20;
            transitionTimer.Tick += TransitionTimerEvent;

            lblScore.Visible = false;

            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;

            gameTimer.Enabled = false;
            SetupLevel(1);
        }

        private void PicBoard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            string textLine1 = "LEVEL " + level;
            string textLine2 = "SCORE: " + score;

            float x1 = (picBoard.Width - e.Graphics.MeasureString(textLine1, customFont).Width) / 2;
            float x2 = (picBoard.Width - e.Graphics.MeasureString(textLine2, customFont).Width) / 2;
            float y1 = 25;
            float y2 = 60;

            e.Graphics.DrawString(textLine1, customFont, Brushes.Black, x1 + 2, y1 + 2);
            e.Graphics.DrawString(textLine2, customFont, Brushes.Black, x2 + 2, y2 + 2);
            e.Graphics.DrawString(textLine1, customFont, Brushes.Yellow, x1, y1);
            e.Graphics.DrawString(textLine2, customFont, Brushes.White, x2, y2);
        }

        private void StartLevelTransition(int nextLvl)
        {
            gameTimer.Stop();
            nextLevelPending = nextLvl;
            isFadingOut = true;

            fBlack.BackColor = Color.Black;
            fBlack.FormBorderStyle = FormBorderStyle.None;
            fBlack.ShowInTaskbar = false;
            fBlack.WindowState = FormWindowState.Maximized;
            fBlack.TopMost = false;
            fBlack.Show();

            this.BringToFront();
            this.Focus();

            transitionTimer.Start();
        }

        private void TransitionTimerEvent(object sender, EventArgs e)
        {
            if (isFadingOut)
            {
                this.Opacity -= 0.05;
                if (this.Opacity <= 0)
                {
                    this.Opacity = 0;
                    isFadingOut = false;
                    SetupLevel(nextLevelPending);
                }
            }
            else
            {
                this.Opacity += 0.05;
                if (this.Opacity >= 1)
                {
                    this.Opacity = 1;
                    transitionTimer.Stop();
                    fBlack.Hide();
                    gameTimer.Start();
                }
            }
        }

        private void SetupLevel(int lvl)
        {
            level = lvl;
            string imagePath = "";
            string musicPath = "";
            string chickenPath = "";
            string boardPath = @"C:\Users\Tora\Pictures\CatchTheEgg\board.png";

            switch (level)
            {
                case 1:
                    baseEggSpeed = 10; chickenSpeed = 3;
                    imagePath = @"C:\Users\Tora\Pictures\CatchTheEgg\round1.png";
                    musicPath = @"C:\Users\Tora\Music\CatchTheEgg\nhac.mp3";
                    chickenPath = @"C:\Users\Tora\Pictures\CatchTheEgg\chicken1.png";
                    break;
                case 2:
                    baseEggSpeed = 13; chickenSpeed = 5;
                    imagePath = @"C:\Users\Tora\Pictures\CatchTheEgg\round2.png";
                    musicPath = @"C:\Users\Tora\Music\CatchTheEgg\nhac.mp3";
                    chickenPath = @"C:\Users\Tora\Pictures\CatchTheEgg\chicken2.png";
                    break;
                case 3:
                    baseEggSpeed = 16; chickenSpeed = 7;
                    imagePath = @"C:\Users\Tora\Pictures\CatchTheEgg\round3.png";
                    musicPath = @"C:\Users\Tora\Music\CatchTheEgg\nhac.mp3";
                    chickenPath = @"C:\Users\Tora\Pictures\CatchTheEgg\chicken3.png";
                    break;
                case 4:
                    baseEggSpeed = 19; chickenSpeed = 9;
                    imagePath = @"C:\Users\Tora\Pictures\CatchTheEgg\round4.png";
                    musicPath = @"C:\Users\Tora\Music\CatchTheEgg\nhac.mp3";
                    chickenPath = @"C:\Users\Tora\Pictures\CatchTheEgg\chicken4.png";
                    break;
                case 5:
                    baseEggSpeed = 22; chickenSpeed = 12;
                    imagePath = @"C:\Users\Tora\Pictures\CatchTheEgg\round5.png";
                    musicPath = @"C:\Users\Tora\Music\CatchTheEgg\nhac.mp3";
                    chickenPath = @"C:\Users\Tora\Pictures\CatchTheEgg\chicken4.png";
                    break;
            }

            if (musicPath != currentMusic)
            {
                try
                {
                    if (File.Exists(musicPath))
                    {
                        MusicPlayer.PlayBackground(musicPath);
                        currentMusic = musicPath;
                    }
                }
                catch { }
            }

            try
            {
                if (File.Exists(imagePath))
                {
                    this.BackgroundImage = Image.FromFile(imagePath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch { }

            try
            {
                if (File.Exists(chickenPath)) picChicken.Image = Image.FromFile(chickenPath);
            }
            catch { }

            try
            {
                if (File.Exists(boardPath)) picBoard.Image = Image.FromFile(boardPath);
            }
            catch { }

            try
            {
                if (File.Exists(@"C:\Users\Tora\Pictures\CatchTheEgg\egg.png"))
                    picEgg.Image = Image.FromFile(@"C:\Users\Tora\Pictures\CatchTheEgg\egg.png");
            }
            catch { }

            picChicken.Top = this.ClientSize.Height / 8;
            ResetEgg();

            if (transitionTimer.Enabled == false && this.Opacity == 1)
            {
                gameTimer.Start();
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            picBoard.Left = this.ClientSize.Width - picBoard.Width - 20;
            picBoard.Top = 20;
            picBoard.Invalidate();

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

            picEgg.Top += eggSpeedY;
            picEgg.Left += eggSpeedX;

            if (picEgg.Left <= 0 || picEgg.Left + picEgg.Width >= this.ClientSize.Width)
            {
                eggSpeedX = -eggSpeedX;
            }

            if (picEgg.Top + picEgg.Height > this.ClientSize.Height)
            {
                GameOverWithEffect();
            }

            if (picEgg.Bounds.IntersectsWith(picBasket.Bounds))
            {
                score++;
                try
                {
                    if (File.Exists(@"C:\Users\Tora\Music\CatchTheEgg\egg.mp3"))
                        MusicPlayer.PlaySoundEffect(@"C:\Users\Tora\Music\CatchTheEgg\egg.mp3");
                }
                catch { }

                if (score == 70) Victory();
                else if (score == 10) StartLevelTransition(2);
                else if (score == 25) StartLevelTransition(3);
                else if (score == 40) StartLevelTransition(4);
                else if (score == 55) StartLevelTransition(5);

                ResetEgg();
            }
        }

        private void GameOverWithEffect()
        {
            gameTimer.Stop();
            try { MusicPlayer.StopBackground(); } catch { }

            try
            {
                if (File.Exists(@"C:\Users\Tora\Pictures\CatchTheEgg\broken_egg.png"))
                {
                    picEgg.Image = Image.FromFile(@"C:\Users\Tora\Pictures\CatchTheEgg\broken_egg.png");
                }
            }
            catch { }

            picEgg.Top = this.ClientSize.Height - picEgg.Height - 10;
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            DialogResult kqua = MessageBox.Show("Game Over! Trứng vỡ rồi! Chơi lại không?", "Thua rồi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (kqua == DialogResult.Yes) RestartGame();
            else this.Close();
        }

        private void ResetEgg()
        {
            try
            {
                if (File.Exists(@"C:\Users\Tora\Pictures\CatchTheEgg\egg.png"))
                    picEgg.Image = Image.FromFile(@"C:\Users\Tora\Pictures\CatchTheEgg\egg.png");
            }
            catch { }

            picEgg.Top = picChicken.Top + picChicken.Height;
            picEgg.Left = picChicken.Left + (picChicken.Width / 2) - (picEgg.Width / 2);

            // --- GÓC RƠI HẸP (45 ĐỘ) ---
            double minAngle = (Math.PI / 2) - (Math.PI / 8);
            double angleRange = Math.PI / 4;

            double angle = minAngle + (rnd.NextDouble() * angleRange);

            eggSpeedX = (int)(baseEggSpeed * Math.Cos(angle));
            eggSpeedY = (int)(baseEggSpeed * Math.Sin(angle));

            // Đảm bảo tốc độ rơi tối thiểu
            if (eggSpeedY < 3) eggSpeedY = 3;
        }

        private void Victory()
        {
            gameTimer.Stop();
            try { MusicPlayer.StopBackground(); } catch { }

            try
            {
                if (File.Exists(@"C:\Users\Tora\Music\CatchTheEgg\victory.mp3"))
                    MusicPlayer.PlayBackground(@"C:\Users\Tora\Music\CatchTheEgg\victory.mp3");
            }
            catch { }

            try
            {
                if (File.Exists(@"C:\Users\Tora\Pictures\CatchTheEgg\victory.png"))
                    this.BackgroundImage = Image.FromFile(@"C:\Users\Tora\Pictures\CatchTheEgg\victory.png");
            }
            catch { }

            picChicken.Visible = false;
            picEgg.Visible = false;
            picBasket.Visible = false;
            picBoard.Visible = false;

            MessageBox.Show("CHÚC MỪNG! BẠN ĐÃ CHIẾN THẮNG!", "Victory!");
            this.Close();
        }

        private void RestartGame()
        {
            score = 0;
            currentMusic = "";
            this.Opacity = 1;
            fBlack.Hide();

            picChicken.Visible = true;
            picEgg.Visible = true;
            picBasket.Visible = true;
            picBoard.Visible = true;

            SetupLevel(1);
            gameTimer.Start();
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
                string fullPath = Path.GetFullPath(path);
                string cmdOpen = "open \"" + fullPath + "\" type mpegvideo alias BgMusic";
                mciSendString(cmdOpen, null, 0, System.IntPtr.Zero);
                mciSendString("play BgMusic repeat", null, 0, System.IntPtr.Zero);
                mciSendString("setaudio BgMusic volume to 200", null, 0, System.IntPtr.Zero);
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
                mciSendString("setaudio SFX volume to 800", null, 0, System.IntPtr.Zero);
            }
        }
    }
}