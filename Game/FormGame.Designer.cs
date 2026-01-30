namespace CatchTheEggGame
{
    partial class FormGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            picEgg = new PictureBox();
            picChicken = new PictureBox();
            picBasket = new PictureBox();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picEgg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBasket).BeginInit();
            SuspendLayout();
            // 
            // picEgg
            // 
            picEgg.BackColor = Color.Transparent;
            picEgg.Image = (Image)resources.GetObject("picEgg.Image");
            picEgg.Location = new Point(316, 175);
            picEgg.Name = "picEgg";
            picEgg.Size = new Size(100, 102);
            picEgg.SizeMode = PictureBoxSizeMode.Zoom;
            picEgg.TabIndex = 0;
            picEgg.TabStop = false;
            // 
            // picChicken
            // 
            picChicken.BackColor = Color.Transparent;
            picChicken.Image = (Image)resources.GetObject("picChicken.Image");
            picChicken.Location = new Point(295, 12);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(163, 157);
            picChicken.SizeMode = PictureBoxSizeMode.Zoom;
            picChicken.TabIndex = 1;
            picChicken.TabStop = false;
            // 
            // picBasket
            // 
            picBasket.Anchor = AnchorStyles.Bottom;
            picBasket.BackColor = Color.Transparent;
            picBasket.BackgroundImageLayout = ImageLayout.None;
            picBasket.Image = (Image)resources.GetObject("picBasket.Image");
            picBasket.Location = new Point(295, 311);
            picBasket.Name = "picBasket";
            picBasket.Size = new Size(163, 102);
            picBasket.SizeMode = PictureBoxSizeMode.Zoom;
            picBasket.TabIndex = 2;
            picBasket.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblScore.Location = new Point(12, 12);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(121, 38);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScore);
            Controls.Add(picBasket);
            Controls.Add(picChicken);
            Controls.Add(picEgg);
            Name = "FormGame";
            Text = "Game Hứng Trứng";
            ((System.ComponentModel.ISupportInitialize)picEgg).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBasket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picEgg;
        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.PictureBox picBasket;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}