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
            Forms.frmNewAccount frm = new Forms.frmNewAccount();
            frm.Show();
            this.Hide();
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

        private void btnSignInIn_Click(object sender, EventArgs e)
        {
            Teacher.frmTeacherMain frm = new Teacher.frmTeacherMain();
            frm.Show();
        }
    }
}
