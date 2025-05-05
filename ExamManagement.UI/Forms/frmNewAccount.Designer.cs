namespace ExamManagement.UI.Forms
{
    partial class frmNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccount));
            btnSignInUp = new Button();
            lblTitle = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            lblName = new Label();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            chkPassword = new CheckBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            pnlGroup = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGroup.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignInUp
            // 
            btnSignInUp.BackColor = Color.FromArgb(15, 157, 88);
            btnSignInUp.Cursor = Cursors.Hand;
            btnSignInUp.FlatAppearance.BorderSize = 0;
            btnSignInUp.FlatStyle = FlatStyle.Flat;
            btnSignInUp.Font = new Font("Segoe UI", 12F);
            btnSignInUp.ForeColor = Color.White;
            btnSignInUp.Location = new Point(19, 8);
            btnSignInUp.Name = "btnSignInUp";
            btnSignInUp.Size = new Size(378, 47);
            btnSignInUp.TabIndex = 4;
            btnSignInUp.Text = "Qeydiyyatdan keç";
            btnSignInUp.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 17F);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(70, 188);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 40);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Yeni tələbə hesabı yaradın";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("SimSun", 13F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.GrayText;
            txtPassword.Location = new Point(46, 334);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(378, 32);
            txtPassword.TabIndex = 16;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(46, 308);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 17;
            label2.Text = "Şifrə";
            // 
            // txtName
            // 
            txtName.Font = new Font("SimSun", 13F, FontStyle.Bold);
            txtName.ForeColor = SystemColors.GrayText;
            txtName.Location = new Point(46, 266);
            txtName.Name = "txtName";
            txtName.Size = new Size(378, 32);
            txtName.TabIndex = 14;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = SystemColors.GrayText;
            lblName.Location = new Point(46, 240);
            lblName.Name = "lblName";
            lblName.Size = new Size(31, 23);
            lblName.TabIndex = 15;
            lblName.Text = "Ad";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.DialogResult = DialogResult.OK;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.White;
            btnBack.FlatAppearance.MouseOverBackColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(15, 157, 88);
            btnBack.Location = new Point(217, 61);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 47);
            btnBack.TabIndex = 6;
            btnBack.Text = "Geri";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
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
            btnExit.Size = new Size(87, 47);
            btnExit.TabIndex = 9;
            btnExit.Text = "Çıxış";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkPassword.Cursor = Cursors.Hand;
            chkPassword.ForeColor = SystemColors.GrayText;
            chkPassword.Location = new Point(292, 379);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(119, 24);
            chkPassword.TabIndex = 23;
            chkPassword.Text = "Şifrəni göstər";
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtUserName.ForeColor = SystemColors.GrayText;
            txtUserName.Location = new Point(46, 406);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(378, 36);
            txtUserName.TabIndex = 18;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.ForeColor = SystemColors.GrayText;
            lblUserName.Location = new Point(46, 380);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(105, 23);
            lblUserName.TabIndex = 22;
            lblUserName.Text = "İstifadəçi adı";
            // 
            // pnlGroup
            // 
            pnlGroup.Controls.Add(btnSignInUp);
            pnlGroup.Controls.Add(btnExit);
            pnlGroup.Controls.Add(btnBack);
            pnlGroup.Location = new Point(27, 457);
            pnlGroup.Name = "pnlGroup";
            pnlGroup.Size = new Size(418, 109);
            pnlGroup.TabIndex = 21;
            // 
            // frmNewAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 582);
            Controls.Add(lblTitle);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(chkPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(pnlGroup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewAccount";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignInUp;
        private Label lblTitle;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtName;
        private Label lblName;
        private Button btnBack;
        private PictureBox pictureBox1;
        private Button btnExit;
        private CheckBox chkPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private Panel pnlGroup;
    }
}