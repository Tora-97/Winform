namespace Example01
{
    partial class Bai13
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
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btSelect = new Button();
            btDeselect = new Button();
            SuspendLayout();
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.ItemHeight = 25;
            lbSong.Location = new Point(20, 50);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(300, 304);
            lbSong.TabIndex = 0;
            lbSong.MouseDoubleClick += lbSong_MouseDoubleClick;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.ItemHeight = 25;
            lbFavorite.Location = new Point(420, 50);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(300, 304);
            lbFavorite.TabIndex = 1;
            lbFavorite.MouseDoubleClick += lbFavorite_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 1;
            label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 20);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 0;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // btSelect
            // 
            btSelect.Location = new Point(340, 117);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(60, 40);
            btSelect.TabIndex = 2;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(340, 200);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(60, 40);
            btDeselect.TabIndex = 4;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // Bai13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 400);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Name = "Bai13";
            Text = "Music";
            Load += Bai13_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
    }
}