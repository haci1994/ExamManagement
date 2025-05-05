namespace ExamManagement.UI.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnSignInIn = new Button();
            lblName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            lblTitle = new Label();
            btnNewUser = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            pnlGroup = new Panel();
            chkPassword = new CheckBox();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignInIn
            // 
            btnSignInIn.BackColor = Color.FromArgb(15, 157, 88);
            btnSignInIn.Cursor = Cursors.Hand;
            btnSignInIn.FlatAppearance.BorderSize = 0;
            btnSignInIn.FlatStyle = FlatStyle.Flat;
            btnSignInIn.Font = new Font("Segoe UI", 12F);
            btnSignInIn.ForeColor = Color.White;
            btnSignInIn.Location = new Point(19, 8);
            btnSignInIn.Name = "btnSignInIn";
            btnSignInIn.Size = new Size(378, 47);
            btnSignInIn.TabIndex = 4;
            btnSignInIn.Text = "Daxil ol";
            btnSignInIn.UseVisualStyleBackColor = false;
            btnSignInIn.Click += btnSignInIn_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = SystemColors.GrayText;
            lblName.Location = new Point(47, 315);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 23);
            lblName.TabIndex = 1;
            lblName.Text = "İstifadəçi adı";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("SimSun", 13F, FontStyle.Bold);
            txtUserName.ForeColor = SystemColors.GrayText;
            txtUserName.Location = new Point(47, 341);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(378, 32);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("SimSun", 13F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.GrayText;
            txtPassword.Location = new Point(47, 409);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(378, 32);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(47, 383);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 3;
            label2.Text = "Şifrə";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 17F);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(90, 184);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 40);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Hesabınıza daxil olun";
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.White;
            btnNewUser.Cursor = Cursors.Hand;
            btnNewUser.DialogResult = DialogResult.OK;
            btnNewUser.FlatAppearance.BorderColor = Color.White;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatAppearance.MouseDownBackColor = Color.White;
            btnNewUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewUser.ForeColor = Color.FromArgb(15, 157, 88);
            btnNewUser.Location = new Point(291, 61);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(106, 47);
            btnNewUser.TabIndex = 6;
            btnNewUser.Text = "Qeydiyyat";
            btnNewUser.TextAlign = ContentAlignment.MiddleRight;
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.White;
            btnExit.FlatAppearance.MouseOverBackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(15, 157, 88);
            btnExit.Location = new Point(19, 61);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(62, 47);
            btnExit.TabIndex = 9;
            btnExit.Text = "Çıxış";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlGroup
            // 
            pnlGroup.Controls.Add(btnSignInIn);
            pnlGroup.Controls.Add(btnExit);
            pnlGroup.Controls.Add(btnNewUser);
            pnlGroup.Location = new Point(28, 490);
            pnlGroup.Name = "pnlGroup";
            pnlGroup.Size = new Size(418, 109);
            pnlGroup.TabIndex = 10;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkPassword.Cursor = Cursors.Hand;
            chkPassword.ForeColor = SystemColors.GrayText;
            chkPassword.Location = new Point(293, 454);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(119, 24);
            chkPassword.TabIndex = 13;
            chkPassword.Text = "Şifrəni göstər";
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(54, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 40);
            panel1.TabIndex = 14;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(74, 8);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tələbə";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(207, 8);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Müəllim";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 622);
            Controls.Add(panel1);
            Controls.Add(chkPassword);
            Controls.Add(pnlGroup);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlGroup.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignInIn;
        private Label lblName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Label lblTitle;
        private Button btnNewUser;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Panel pnlGroup;
        private CheckBox chkPassword;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}