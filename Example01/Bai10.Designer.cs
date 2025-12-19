namespace Example01
{
    partial class Bai10
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName (Ô nhập tên)
            // 
            this.tbName.Location = new System.Drawing.Point(20, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 31);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Nguyễn Văn A"; // Giá trị mặc định cho giống Slide
            // 
            // groupBox1 (Khung Giới tính)
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rbMale (Radio Nam)
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true; // Mặc định chọn Nam
            this.rbMale.Location = new System.Drawing.Point(40, 40);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale (Radio Nữ)
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(180, 40);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 29);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount (CheckBox Giảm giá)
            // 
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Location = new System.Drawing.Point(20, 190);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(111, 29);
            this.ckDiscount.TabIndex = 2;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;
            // --- KẾT NỐI SỰ KIỆN CHECKBOX ---
            this.ckDiscount.CheckedChanged += new System.EventHandler(this.ckDiscount_CheckedChanged);
            // 
            // tbDiscount (Ô nhập % giảm giá)
            // 
            this.tbDiscount.Enabled = false; // Mặc định bị khóa (theo logic code)
            this.tbDiscount.Location = new System.Drawing.Point(140, 188);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(180, 31);
            this.tbDiscount.TabIndex = 3;
            // 
            // tbResult (Ô kết quả)
            // 
            this.tbResult.Location = new System.Drawing.Point(20, 240);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(300, 100);
            this.tbResult.TabIndex = 4;
            // 
            // btRun (Nút Tính tiền)
            // 
            this.btRun.Location = new System.Drawing.Point(60, 360);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(110, 40);
            this.btRun.TabIndex = 5;
            this.btRun.Text = "Tính tiền";
            this.btRun.UseVisualStyleBackColor = true;
            // --- KẾT NỐI SỰ KIỆN TÍNH TIỀN ---
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btExit (Nút Thoát)
            // 
            this.btExit.Location = new System.Drawing.Point(190, 360);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 40);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // --- KẾT NỐI SỰ KIỆN THOÁT ---
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 430);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbName);
            this.Name = "Bai10";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
    }
}