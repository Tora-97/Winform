namespace Example01
{
    partial class Bai7
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button(); // Sửa lại tên biến cho thống nhất
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 22);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(301, 31);
            this.tbDisplay.TabIndex = 0;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 59);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(61, 55);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(90, 59);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 57);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(90, 122);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(61, 57);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 122);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 55);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(172, 124);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(61, 55);
            this.btnDot.TabIndex = 7;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(250, 61);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 57);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(172, 61);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 55);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(250, 124);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(61, 55);
            this.btnEqual.TabIndex = 8;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 189);

            // Thêm các control vào Form
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.tbDisplay);
            this.Name = "Bai7";

            // --- THAY ĐỔI TÊN FORM Ở ĐÂY ---
            this.Text = "Simple Calculator";

            // --- QUAN TRỌNG: PHẦN KẾT NỐI SỰ KIỆN ---
            // Code cũ của bạn thiếu toàn bộ phần này nên bấm không ăn
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // ----------------------------------------

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        // Đã xóa biến thừa btnEquals, chỉ giữ lại btnEqual
        private System.Windows.Forms.Button btnEqual;
    }
}