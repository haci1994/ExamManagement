namespace ExamManagement.UI.Forms.Teacher
{
    partial class frmTeacherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherMain));
            pnlMenyu = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlTitle = new Panel();
            lblTeacherName = new Label();
            label1 = new Label();
            pnlMain = new Panel();
            pnlMenyu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenyu
            // 
            pnlMenyu.BackColor = Color.FromArgb(39, 93, 43);
            pnlMenyu.Controls.Add(pictureBox1);
            pnlMenyu.Controls.Add(button4);
            pnlMenyu.Controls.Add(button3);
            pnlMenyu.Controls.Add(button2);
            pnlMenyu.Controls.Add(button1);
            pnlMenyu.Dock = DockStyle.Left;
            pnlMenyu.Location = new Point(0, 40);
            pnlMenyu.Margin = new Padding(3, 2, 3, 2);
            pnlMenyu.Name = "pnlMenyu";
            pnlMenyu.Size = new Size(224, 534);
            pnlMenyu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 236);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(219, 35);
            button4.TabIndex = 4;
            button4.Text = "Çıxış";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 196);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(219, 35);
            button3.TabIndex = 3;
            button3.Text = "Nəticələr";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 156);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(219, 35);
            button2.TabIndex = 2;
            button2.Text = "Sual əlavə et";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 116);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(219, 35);
            button1.TabIndex = 1;
            button1.Text = "İmtahan yarat";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(24, 57, 46);
            pnlTitle.Controls.Add(lblTeacherName);
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Margin = new Padding(3, 2, 3, 2);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1288, 40);
            pnlTitle.TabIndex = 2;
            // 
            // lblTeacherName
            // 
            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new Font("Segoe UI", 20F);
            lblTeacherName.ForeColor = Color.White;
            lblTeacherName.Location = new Point(721, 1);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(84, 37);
            lblTeacherName.TabIndex = 1;
            lblTeacherName.Text = "Samir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(458, 1);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Xoş gəldiniz Müəllim";
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(224, 40);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1064, 534);
            pnlMain.TabIndex = 4;
            // 
            // frmTeacherMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 574);
            Controls.Add(pnlMain);
            Controls.Add(pnlMenyu);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTeacherMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmTeacherMain_Load;
            pnlMenyu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenyu;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlTitle;
        private Label lblTeacherName;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlMain;
    }
}