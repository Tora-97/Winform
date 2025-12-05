namespace Example01
{
    partial class Bai5
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
            label1 = new Label();
            label2 = new Label();
            tbKetQua = new TextBox();
            label3 = new Label();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Số X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 111);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "Số y";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(170, 178);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(350, 31);
            tbKetQua.TabIndex = 5;
            tbKetQua.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 181);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // btCong
            // 
            btCong.Location = new Point(67, 263);
            btCong.Name = "btCong";
            btCong.Size = new Size(112, 34);
            btCong.TabIndex = 6;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(238, 263);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(112, 34);
            btNhan.TabIndex = 7;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(498, 263);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 34);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(170, 39);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(350, 31);
            tbSoX.TabIndex = 9;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(170, 108);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(350, 31);
            tbSoY.TabIndex = 10;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 331);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Bai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tbKetQua;
        private Label label3;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
        private TextBox tbSoX;
        private TextBox tbSoY;
    }
}