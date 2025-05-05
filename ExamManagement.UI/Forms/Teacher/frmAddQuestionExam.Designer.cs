namespace ExamManagement.UI.Forms.Teacher
{
    partial class frmAddQuestionExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuestionExam));
            panel1 = new Panel();
            btnClose = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cmbThemes = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 47);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1177, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(522, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 665);
            dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbThemes);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 665);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(151, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(335, 33);
            comboBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(13, 29);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 15;
            label3.Text = "İmtahan adı:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20", "25" });
            comboBox1.Location = new Point(151, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(95, 33);
            comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(40, 130);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 6;
            label2.Text = "Sual sayı:";
            // 
            // cmbThemes
            // 
            cmbThemes.Font = new Font("Segoe UI", 11F);
            cmbThemes.FormattingEnabled = true;
            cmbThemes.Location = new Point(151, 92);
            cmbThemes.Name = "cmbThemes";
            cmbThemes.Size = new Size(335, 33);
            cmbThemes.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(56, 100);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 3;
            label1.Text = "Mövzu:";
            // 
            // button3
            // 
            button3.BackColor = Color.Pink;
            button3.Location = new Point(193, 259);
            button3.Name = "button3";
            button3.Size = new Size(137, 67);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(193, 186);
            button1.Name = "button1";
            button1.Size = new Size(137, 67);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmAddQuestionExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 712);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddQuestionExam";
            Text = "frmAddQuestionExam";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox cmbThemes;
        private Label label1;
        private ComboBox comboBox2;
        private Label label3;
        private Button button3;
        private Button button1;
    }
}