using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagement.UI.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool isSignUp = false;

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (!isSignUp)
            {
                this.Size = new Size(472, 585);
                pnlGroup.Location = new Point(28, 450);
                btnNewUser.Text = "Back";
                lblTitle.Text = "Create a new account";
                btnSignInUp.Text = "Sign Up";
                lblName.Text = "Name";
                txtName.Text = "";
                txtPassword.Text = "";
                txtUserName.Text = "";
                lblUserName.Visible = true;
                txtUserName.Visible = true;
                isSignUp = true;
            }
            else
            {
                this.Size = new Size(472, 550);
                pnlGroup.Location = new Point(28, 411);
                btnNewUser.Text = "New user? [Sign up]";
                lblTitle.Text = "Log in to your account";
                btnSignInUp.Text = "Sign In";
                lblName.Text = "Username";
                txtName.Text = "";
                txtPassword.Text = "";
                txtUserName.Text = "";
                lblUserName.Visible = false;
                txtUserName.Visible = false;
                isSignUp = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

    }
}
