namespace ExamManagement.UI.Forms.Teacher
{
    partial class frmİnfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmİnfo));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 534);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(408, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 138);
            panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(43, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 36);
            textBox2.TabIndex = 1;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 20);
            label3.Name = "label3";
            label3.Size = new Size(208, 41);
            label3.TabIndex = 0;
            label3.Text = "İmtahanlarım";
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(101, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 138);
            panel4.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CadetBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(43, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 36);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 20);
            label2.Name = "label2";
            label2.Size = new Size(151, 41);
            label2.TabIndex = 0;
            label2.Text = "Suallarım";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 20);
            label4.Name = "label4";
            label4.Size = new Size(192, 41);
            label4.TabIndex = 0;
            label4.Text = "İştirakçı sayı";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.IndianRed;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(43, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 36);
            textBox3.TabIndex = 1;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(708, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 138);
            panel3.TabIndex = 8;
            // 
            // frmİnfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 534);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmİnfo";
            Text = "frmİnfo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Panel panel4;
        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private TextBox textBox3;
        private Label label4;
    }
}