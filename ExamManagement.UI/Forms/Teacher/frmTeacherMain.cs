using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ExamManagement.UI.Forms.Teacher
{
    public partial class frmTeacherMain : Form
    {
        public frmTeacherMain()
        {
            InitializeComponent();
        }
        string[] mesajlar = {
                "SH Sınaq – biliyin rəqəmsal tərəfdaşı!",
                "Daha güclü gələcək, daha yaxşı suallarla qurulur!",
                "Daha çox iştirakçı – daha çox uğur hekayəsi!"

            };

        int direction = -1;
        int mesajIndex = 0;
        private void OpenFormInPanel(Form form)
        {
            for (int i = pnlMain.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = pnlMain.Controls[i];
                if (ctrl is Form)
                {
                    pnlMain.Controls.RemoveAt(i);
                }
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void InitializeClock()
        {
            timerSaat.Interval = 1000; // 1 second
            timerSaat.Tick += timerSaat_Tick;
            timerSaat.Start();
        }
        private void frmTeacherMain_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new Teacher.frmİnfo());

            InitializeClock();

            lblScroll.Text = mesajlar[mesajIndex];
            lblScroll.Left = pnlMain.Width;

            timer1.Interval = 30;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblScroll.Left -= 1; // sola doğru 2 piksel hərəkət etsin

            // Yazı tam soldan çıxanda: yenisini göstər və sağdan başlasın
            if (lblScroll.Right < 0)
            {
                mesajIndex++;
                if (mesajIndex >= mesajlar.Length)
                    mesajIndex = 0;

                lblScroll.Text = mesajlar[mesajIndex];
                lblScroll.Left = pnlTitle.Width; // pnlMain yox, yazının içində olduğu panel
            }
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            lblSaat.Text = now.Hour.ToString("D2");
            lblDeq.Text = now.Minute.ToString("D2");
            lblSan.Text = now.Second.ToString("D2");
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Teacher.frmCreatExam());
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Teacher.frmCreateQuestion());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Teacher.frmAddQuestionExam());
        }
    }
}
