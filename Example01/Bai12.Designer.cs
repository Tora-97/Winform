namespace Example01
{
    partial class Bai12
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
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            dtpDob = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label3 = new Label();
            cbFaculty = new ComboBox();
            label4 = new Label();
            rtbStatus = new RichTextBox();
            btAdd = new Button();
            btExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // tbName
            // 
            tbName.Location = new Point(140, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(300, 31);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(140, 75);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(300, 31);
            dtpDob.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(140, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 80);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(180, 35);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(61, 29);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(30, 35);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 220);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 5;
            label3.Text = "Khoa";
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Kế toán", "Cơ khí", "Điện" });
            cbFaculty.Location = new Point(140, 217);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(300, 33);
            cbFaculty.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 270);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái";
            // 
            // rtbStatus
            // 
            rtbStatus.Location = new Point(140, 270);
            rtbStatus.Name = "rtbStatus";
            rtbStatus.Size = new Size(300, 150);
            rtbStatus.TabIndex = 8;
            rtbStatus.Text = "";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(192, 440);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(110, 40);
            btAdd.TabIndex = 9;
            btAdd.Text = "Thêm";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(330, 440);
            btExit.Name = "btExit";
            btExit.Size = new Size(110, 40);
            btExit.TabIndex = 10;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Bai12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 500);
            Controls.Add(btExit);
            Controls.Add(btAdd);
            Controls.Add(rtbStatus);
            Controls.Add(label4);
            Controls.Add(cbFaculty);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dtpDob);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "Bai12";
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
    }
}