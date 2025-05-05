namespace ExamManagement.UI.Forms.Teacher
{
    partial class frmCreateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateQuestion));
            panel1 = new Panel();
            btnClose = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label5 = new Label();
            lboxOptions = new ListBox();
            txtOption = new TextBox();
            label4 = new Label();
            cmbPoint = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cmbThemes = new ComboBox();
            txtQuestion = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
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
            panel1.TabIndex = 3;
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
            dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lboxOptions);
            groupBox1.Controls.Add(txtOption);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbPoint);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbThemes);
            groupBox1.Controls.Add(txtQuestion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 665);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(464, 277);
            button4.Name = "button4";
            button4.Size = new Size(44, 84);
            button4.TabIndex = 13;
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            label5.Location = new Point(15, 375);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 12;
            label5.Text = "Cavablar:";
            // 
            // lboxOptions
            // 
            lboxOptions.FormattingEnabled = true;
            lboxOptions.Location = new Point(111, 375);
            lboxOptions.Name = "lboxOptions";
            lboxOptions.Size = new Size(347, 164);
            lboxOptions.TabIndex = 11;
            // 
            // txtOption
            // 
            txtOption.Font = new Font("Segoe UI", 11F);
            txtOption.Location = new Point(111, 277);
            txtOption.Multiline = true;
            txtOption.Name = "txtOption";
            txtOption.Size = new Size(347, 84);
            txtOption.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            label4.Location = new Point(29, 277);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 9;
            label4.Text = "Variant:";
            // 
            // cmbPoint
            // 
            cmbPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPoint.Font = new Font("Segoe UI", 11F);
            cmbPoint.FormattingEnabled = true;
            cmbPoint.Items.AddRange(new object[] { "1", "2", "3" });
            cmbPoint.Location = new Point(111, 208);
            cmbPoint.Name = "cmbPoint";
            cmbPoint.Size = new Size(77, 33);
            cmbPoint.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            label3.Location = new Point(62, 211);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 7;
            label3.Text = "Bal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            label2.Location = new Point(53, 59);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 6;
            label2.Text = "Sual:";
            // 
            // cmbThemes
            // 
            cmbThemes.Font = new Font("Segoe UI", 11F);
            cmbThemes.FormattingEnabled = true;
            cmbThemes.Location = new Point(111, 20);
            cmbThemes.Name = "cmbThemes";
            cmbThemes.Size = new Size(347, 33);
            cmbThemes.TabIndex = 5;
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Segoe UI", 11F);
            txtQuestion.Location = new Point(111, 59);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(347, 143);
            txtQuestion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 3;
            label1.Text = "Mövzu:";
            // 
            // button3
            // 
            button3.BackColor = Color.Pink;
            button3.Location = new Point(337, 567);
            button3.Name = "button3";
            button3.Size = new Size(137, 67);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Location = new Point(193, 567);
            button2.Name = "button2";
            button2.Size = new Size(137, 67);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(49, 567);
            button1.Name = "button1";
            button1.Size = new Size(137, 67);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(111, 249);
            label6.Name = "label6";
            label6.Size = new Size(209, 20);
            label6.TabIndex = 14;
            label6.Text = "Düzgün cavabı ilk daxil edin.";
            // 
            // frmCreateQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 712);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateQuestion";
            Text = "frmCreateQuestion";
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
        private Button button4;
        private Label label5;
        private ListBox lboxOptions;
        private TextBox txtOption;
        private Label label4;
        private ComboBox cmbPoint;
        private Label label3;
        private Label label2;
        private ComboBox cmbThemes;
        private TextBox txtQuestion;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
    }
}