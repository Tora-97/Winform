namespace Example01
{
    partial class Bai3
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
            btn_ok = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ok.Location = new Point(78, 99);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(112, 34);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(63, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            txtName.Text = "nhập tên";
            txtName.TextChanged += txtName_TextChanged;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 286);
            Controls.Add(txtName);
            Controls.Add(btn_ok);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private TextBox txtName;
    }
}