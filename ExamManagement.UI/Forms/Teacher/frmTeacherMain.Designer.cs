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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherMain));
            pnlMenyu = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnResults = new Button();
            btnAddQuestion = new Button();
            btnCreateExam = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timerSaat = new System.Windows.Forms.Timer(components);
            pnlTitle = new Panel();
            pnlSaat = new Panel();
            lblSan = new Label();
            label3 = new Label();
            lblDeq = new Label();
            label1 = new Label();
            lblSaat = new Label();
            lblScroll = new Label();
            pnlMain = new Panel();
            button1 = new Button();
            pnlMenyu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitle.SuspendLayout();
            pnlSaat.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenyu
            // 
            pnlMenyu.BackColor = Color.FromArgb(39, 93, 43);
            pnlMenyu.Controls.Add(button1);
            pnlMenyu.Controls.Add(pictureBox1);
            pnlMenyu.Controls.Add(btnExit);
            pnlMenyu.Controls.Add(btnResults);
            pnlMenyu.Controls.Add(btnAddQuestion);
            pnlMenyu.Controls.Add(btnCreateExam);
            pnlMenyu.Dock = DockStyle.Left;
            pnlMenyu.Location = new Point(0, 0);
            pnlMenyu.Name = "pnlMenyu";
            pnlMenyu.Size = new Size(243, 765);
            pnlMenyu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(3, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(240, 47);
            btnExit.TabIndex = 4;
            btnExit.Text = "Çıxış";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnResults
            // 
            btnResults.Cursor = Cursors.Hand;
            btnResults.FlatAppearance.BorderSize = 0;
            btnResults.FlatStyle = FlatStyle.Flat;
            btnResults.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnResults.ForeColor = Color.White;
            btnResults.Image = (Image)resources.GetObject("btnResults.Image");
            btnResults.ImageAlign = ContentAlignment.MiddleLeft;
            btnResults.Location = new Point(3, 314);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(240, 47);
            btnResults.TabIndex = 3;
            btnResults.Text = "Nəticələr";
            btnResults.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Cursor = Cursors.Hand;
            btnAddQuestion.FlatAppearance.BorderSize = 0;
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Image = (Image)resources.GetObject("btnAddQuestion.Image");
            btnAddQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddQuestion.Location = new Point(3, 208);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(240, 47);
            btnAddQuestion.TabIndex = 2;
            btnAddQuestion.Text = "Sual əlavə et";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnCreateExam
            // 
            btnCreateExam.Cursor = Cursors.Hand;
            btnCreateExam.FlatAppearance.BorderSize = 0;
            btnCreateExam.FlatStyle = FlatStyle.Flat;
            btnCreateExam.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreateExam.ForeColor = Color.White;
            btnCreateExam.Image = (Image)resources.GetObject("btnCreateExam.Image");
            btnCreateExam.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateExam.Location = new Point(3, 155);
            btnCreateExam.Name = "btnCreateExam";
            btnCreateExam.Size = new Size(240, 47);
            btnCreateExam.TabIndex = 1;
            btnCreateExam.Text = "İmtahanlar";
            btnCreateExam.UseVisualStyleBackColor = true;
            btnCreateExam.Click += btnCreateExam_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // timerSaat
            // 
            timerSaat.Enabled = true;
            timerSaat.Tick += timerSaat_Tick;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(24, 57, 46);
            pnlTitle.Controls.Add(pnlSaat);
            pnlTitle.Controls.Add(lblScroll);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(243, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1229, 53);
            pnlTitle.TabIndex = 3;
            // 
            // pnlSaat
            // 
            pnlSaat.BackColor = Color.CadetBlue;
            pnlSaat.Controls.Add(lblSan);
            pnlSaat.Controls.Add(label3);
            pnlSaat.Controls.Add(lblDeq);
            pnlSaat.Controls.Add(label1);
            pnlSaat.Controls.Add(lblSaat);
            pnlSaat.Dock = DockStyle.Right;
            pnlSaat.Location = new Point(973, 0);
            pnlSaat.Name = "pnlSaat";
            pnlSaat.Size = new Size(256, 53);
            pnlSaat.TabIndex = 0;
            // 
            // lblSan
            // 
            lblSan.AutoSize = true;
            lblSan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSan.ForeColor = Color.White;
            lblSan.Location = new Point(166, 6);
            lblSan.Name = "lblSan";
            lblSan.Size = new Size(60, 46);
            lblSan.TabIndex = 4;
            lblSan.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(146, 6);
            label3.Name = "label3";
            label3.Size = new Size(29, 46);
            label3.TabIndex = 3;
            label3.Text = ":";
            // 
            // lblDeq
            // 
            lblDeq.AutoSize = true;
            lblDeq.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDeq.ForeColor = Color.White;
            lblDeq.Location = new Point(95, 6);
            lblDeq.Name = "lblDeq";
            lblDeq.Size = new Size(60, 46);
            lblDeq.TabIndex = 2;
            lblDeq.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 6);
            label1.Name = "label1";
            label1.Size = new Size(29, 46);
            label1.TabIndex = 1;
            label1.Text = ":";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSaat.ForeColor = Color.White;
            lblSaat.Location = new Point(26, 6);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(60, 46);
            lblSaat.TabIndex = 0;
            lblSaat.Text = "00";
            // 
            // lblScroll
            // 
            lblScroll.AutoSize = true;
            lblScroll.Font = new Font("Segoe UI", 20F);
            lblScroll.ForeColor = Color.White;
            lblScroll.Location = new Point(988, 3);
            lblScroll.Name = "lblScroll";
            lblScroll.Size = new Size(74, 46);
            lblScroll.TabIndex = 0;
            lblScroll.Text = "141";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(243, 53);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1229, 712);
            pnlMain.TabIndex = 5;
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
            button1.Location = new Point(0, 261);
            button1.Name = "button1";
            button1.Size = new Size(240, 47);
            button1.TabIndex = 5;
            button1.Text = "İmtahan tərtibatı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmTeacherMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 765);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Controls.Add(pnlMenyu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTeacherMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmTeacherMain_Load;
            pnlMenyu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlSaat.ResumeLayout(false);
            pnlSaat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenyu;
        private Button btnExit;
        private Button btnResults;
        private Button btnAddQuestion;
        private Button btnCreateExam;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerSaat;
        private Panel pnlTitle;
        private Panel pnlSaat;
        private Label lblSan;
        private Label label3;
        private Label lblDeq;
        private Label label1;
        private Label lblSaat;
        private Label lblScroll;
        private Panel pnlMain;
        private Button button1;
    }
}