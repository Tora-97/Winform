namespace HoangLong
{
    partial class Main
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
            this.btNew = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lớp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btImport = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(535, 620);
            this.btNew.Margin = new System.Windows.Forms.Padding(4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(83, 37);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mã,
            this.Tên,
            this.Lớp,
            this.gender,
            this.grade,
            this.by,
            this.email,
            this.address,
            this.Column1});
            this.dgvCustomer.Location = new System.Drawing.Point(-2, 13);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1058, 334);
            this.dgvCustomer.TabIndex = 1;
            // 
            // Mã
            // 
            this.Mã.DataPropertyName = "id";
            this.Mã.HeaderText = "Mã";
            this.Mã.MinimumWidth = 6;
            this.Mã.Name = "Mã";
            this.Mã.Width = 70;
            // 
            // Tên
            // 
            this.Tên.DataPropertyName = "n";
            this.Tên.HeaderText = "Tên";
            this.Tên.MinimumWidth = 6;
            this.Tên.Name = "Tên";
            this.Tên.Width = 105;
            // 
            // Lớp
            // 
            this.Lớp.DataPropertyName = "c";
            this.Lớp.HeaderText = "Lớp";
            this.Lớp.MinimumWidth = 6;
            this.Lớp.Name = "Lớp";
            this.Lớp.Width = 80;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "g";
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 90;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "gr";
            this.grade.HeaderText = "Điểm";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.Width = 105;
            // 
            // by
            // 
            this.by.DataPropertyName = "b";
            this.by.HeaderText = "Ngày sinh";
            this.by.MinimumWidth = 6;
            this.by.Name = "by";
            this.by.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "b";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // address
            // 
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "avatar";
            this.Column1.HeaderText = "Ảnh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(757, 620);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 37);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(645, 620);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(83, 37);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(867, 620);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(83, 37);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(13, 621);
            this.btRead.Margin = new System.Windows.Forms.Padding(4);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(128, 37);
            this.btRead.TabIndex = 5;
            this.btRead.Text = "Đọc dữ liệu";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(607, 383);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(73, 22);
            this.tbId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 527);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 480);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(809, 526);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(892, 526);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(45, 20);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 480);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày sinh";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(607, 432);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 22);
            this.tbName.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 480);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Điểm";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(823, 430);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(127, 22);
            this.tbGrade.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ảnh sinh viên";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(50, 382);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(229, 226);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 25;
            this.pbAvatar.TabStop = false;
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(148, 622);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(124, 38);
            this.btImport.TabIndex = 26;
            this.btImport.Text = "Nhập Excel";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImportExcel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(823, 380);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(127, 22);
            this.tbEmail.TabIndex = 28;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(607, 519);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 24);
            this.cbClass.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btExportExcel_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(297, 571);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(110, 37);
            this.btBrowse.TabIndex = 31;
            this.btBrowse.Text = "Chọn ảnh";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Địa chỉ";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(670, 578);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(225, 22);
            this.tbAddress.TabIndex = 33;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 671);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btNew);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lớp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn by;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAddress;
    }
}

