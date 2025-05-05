namespace ExamManagement.UI.Forms.Teacher
{
    partial class frmCreatExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatExam));
            panel1 = new Panel();
            btnClose = new PictureBox();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txtOption = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.TabIndex = 2;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtOption);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 665);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(151, 99);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(163, 32);
            dateTimePicker2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 15;
            label2.Text = "Bitmə tarixi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(151, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 32);
            dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 13;
            label1.Text = "Başlama tarixi:";
            // 
            // txtOption
            // 
            txtOption.Font = new Font("Segoe UI", 11F);
            txtOption.Location = new Point(151, 23);
            txtOption.Name = "txtOption";
            txtOption.Size = new Size(346, 32);
            txtOption.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(11, 26);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 11;
            label4.Text = "İmtahan adı:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(522, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 665);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Location = new Point(193, 233);
            button2.Name = "button2";
            button2.Size = new Size(137, 67);
            button2.TabIndex = 19;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleTurquoise;
            button5.Location = new Point(193, 160);
            button5.Name = "button5";
            button5.Size = new Size(137, 67);
            button5.TabIndex = 17;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            // 
            // frmCreatExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 712);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreatExam";
            Text = "frmCreatExam";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txtOption;
        private Label label4;
        private Button button2;
        private Button button5;
    }
}