namespace Example02
{
    partial class Bai2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ok = new Button();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(220, 124);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ok);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ok;
    }
}
