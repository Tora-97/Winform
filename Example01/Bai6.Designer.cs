namespace Example01
{
    partial class Bai6
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
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            label3 = new Label();
            tbKetQua = new TextBox();
            this.btnSave = new Button();
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnMul = new Button();
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            this.btnPlus = new Button();
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnExit = new Button();
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Số X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = "Số Y";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(122, 18);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(833, 31);
            tbSoX.TabIndex = 2;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(122, 85);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(833, 31);
            tbSoY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 159);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(122, 159);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ScrollBars = ScrollBars.Vertical;
            tbKetQua.Size = new Size(833, 298);
            tbKetQua.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            this.btnMul.Location = new Point(750, 463);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new Size(112, 34);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "Nhân";
            this.btnMul.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(632, 463);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(112, 34);
            btnPlus.TabIndex = 8;
            btnPlus.Text = "Cộng";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(868, 463);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 504);
            Controls.Add(btnExit);
            Controls.Add(btnPlus);
            Controls.Add(this.btnMul);
            Controls.Add(btnSave);
            Controls.Add(tbKetQua);
            Controls.Add(label3);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private Label label3;
        private TextBox tbKetQua;
        private Button btnSave;
        private Button btnPlus;
        private Button btnMul;
        private Button btnExit;
    }
}