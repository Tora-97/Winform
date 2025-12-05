namespace Example01
{
    partial class Menu
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(17, 20);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(160, 108);
            btn1.TabIndex = 0;
            btn1.Text = "B1_ResizeWindow";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(237, 20);
            btn2.Margin = new Padding(4, 5, 4, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(160, 110);
            btn2.TabIndex = 1;
            btn2.Text = "B2_KeyLogger";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(451, 20);
            btn3.Margin = new Padding(4, 5, 4, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(160, 110);
            btn3.TabIndex = 2;
            btn3.Text = "B3_Button";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(666, 20);
            btn4.Margin = new Padding(4, 5, 4, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(160, 110);
            btn4.TabIndex = 3;
            btn4.Text = "B4_YearInput";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(886, 20);
            btn5.Margin = new Padding(4, 5, 4, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(160, 110);
            btn5.TabIndex = 4;
            btn5.Text = "B5_Calculation";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(17, 170);
            btn6.Margin = new Padding(4, 5, 4, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(160, 108);
            btn6.TabIndex = 5;
            btn6.Text = "B6_";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
    }
}