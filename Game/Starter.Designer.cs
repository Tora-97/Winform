namespace CatchTheEggGame
{
    partial class Starter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btStart = new Button();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.BackColor = Color.Transparent;
            btStart.BackgroundImageLayout = ImageLayout.Stretch;
            btStart.FlatAppearance.BorderSize = 0;
            btStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btStart.FlatStyle = FlatStyle.Flat;
            btStart.Location = new Point(265, 168);
            btStart.Name = "btStart";
            btStart.Size = new Size(311, 109);
            btStart.TabIndex = 1;
            btStart.UseVisualStyleBackColor = false;
            btStart.Click += btStart_Click;
            // 
            // Starter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Starter;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btStart);
            DoubleBuffered = true;
            Name = "Starter";
            Text = "Starter";
            ResumeLayout(false);
        }

        #endregion
        private Button btStart;
    }
}