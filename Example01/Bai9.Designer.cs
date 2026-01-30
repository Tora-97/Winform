namespace Example01
{
    partial class Bai9
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Chỉ cho chọn, không cho gõ
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(12, 12);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(300, 33);
            this.cb_Faculty.TabIndex = 0;
            // Dòng này rất quan trọng để sự kiện SelectedIndexChanged hoạt động
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged);

            // 
            // tbDisplay (Hiển thị kết quả)
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 60);
            this.tbDisplay.Multiline = true; // Cho phép hiện nhiều dòng
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(300, 100);
            this.tbDisplay.TabIndex = 1;

            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(200, 180);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(112, 34);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);

            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Bai9";
            this.Text = "ComboBox Class Demo";

            this.Load += new System.EventHandler(this.Bai9_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btOK;
    }
}