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
            btnNewUser = new Button();
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
            btnSignInUp.Location = new Point(17, 6);
            btnSignInUp.Margin = new Padding(3, 2, 3, 2);
            btnSignInUp.Name = "btnSignInUp";
            btnSignInUp.Size = new Size(331, 35);
            btnSignInUp.TabIndex = 4;
            btnSignInUp.Text = "Sign In";
            btnSignInUp.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 17F);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(78, 137);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 31);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Create a new account";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("SimSun", 13F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.GrayText;
            txtPassword.Location = new Point(40, 247);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(331, 27);
            txtPassword.TabIndex = 16;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(40, 227);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 17;
            label2.Text = "Password";
            // 
            // txtName
            // 
            txtName.Font = new Font("SimSun", 13F, FontStyle.Bold);
            txtName.ForeColor = SystemColors.GrayText;
            txtName.Location = new Point(40, 195);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(331, 27);
            txtName.TabIndex = 14;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = SystemColors.GrayText;
            lblName.Location = new Point(40, 176);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 15;
            lblName.Text = "Name";
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.White;
            btnNewUser.Cursor = Cursors.Hand;
            btnNewUser.DialogResult = DialogResult.OK;
            btnNewUser.FlatAppearance.BorderColor = Color.White;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatAppearance.CheckedBackColor = Color.White;
            btnNewUser.FlatAppearance.MouseDownBackColor = Color.White;
            btnNewUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewUser.ForeColor = Color.FromArgb(15, 157, 88);
            btnNewUser.Location = new Point(190, 46);
            btnNewUser.Margin = new Padding(3, 2, 3, 2);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(158, 35);
            btnNewUser.TabIndex = 6;
            btnNewUser.Text = "Back";
            btnNewUser.TextAlign = ContentAlignment.MiddleRight;
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 112);
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
            btnExit.FlatAppearance.CheckedBackColor = Color.White;
            btnExit.FlatAppearance.MouseDownBackColor = Color.White;
            btnExit.FlatAppearance.MouseOverBackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(15, 157, 88);
            btnExit.Location = new Point(17, 46);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 35);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkPassword.Cursor = Cursors.Hand;
            chkPassword.ForeColor = SystemColors.GrayText;
            chkPassword.Location = new Point(255, 280);
            chkPassword.Margin = new Padding(3, 2, 3, 2);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(108, 19);
            chkPassword.TabIndex = 23;
            chkPassword.Text = "Show Password";
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtUserName.ForeColor = SystemColors.GrayText;
            txtUserName.Location = new Point(40, 301);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(331, 31);
            txtUserName.TabIndex = 18;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.ForeColor = SystemColors.GrayText;
            lblUserName.Location = new Point(40, 281);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(71, 19);
            lblUserName.TabIndex = 22;
            lblUserName.Text = "Username";
            // 
            // pnlGroup
            // 
            pnlGroup.Controls.Add(btnSignInUp);
            pnlGroup.Controls.Add(btnExit);
            pnlGroup.Controls.Add(btnNewUser);
            pnlGroup.Location = new Point(23, 347);
            pnlGroup.Margin = new Padding(3, 2, 3, 2);
            pnlGroup.Name = "pnlGroup";
            pnlGroup.Size = new Size(366, 82);
            pnlGroup.TabIndex = 21;
            // 
            // frmNewAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 446);
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
            Text = "New Account";
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
        private Button btnNewUser;
        private PictureBox pictureBox1;
        private Button btnExit;
        private CheckBox chkPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private Panel pnlGroup;
    }
}