namespace attendence_system.Instructor.userControl
{
    public partial class setAttendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAddStudent = new Label();
            dataGridViewAttendance = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            labelClass = new Label();
            labelDate = new Label();
            comboBoxClass = new ComboBox();
            comboBoxDate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.Transparent;
            labelAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelAddStudent.Location = new Point(3, 13);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(144, 19);
            labelAddStudent.TabIndex = 2;
            labelAddStudent.Text = "Set Attendance :";
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(20, 103);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(892, 323);
            dataGridViewAttendance.TabIndex = 3;
            dataGridViewAttendance.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Location = new Point(498, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Location = new Point(150, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 18;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClass.Location = new Point(498, 29);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(63, 19);
            labelClass.TabIndex = 16;
            labelClass.Text = "Class :";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDate.Location = new Point(150, 29);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(57, 19);
            labelDate.TabIndex = 14;
            labelDate.Text = "Date :";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(498, 61);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 28);
            comboBoxClass.TabIndex = 20;
            // 
            // comboBoxDate
            // 
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(150, 61);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(270, 28);
            comboBoxDate.TabIndex = 21;
            // 
            // setAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBoxDate);
            Controls.Add(comboBoxClass);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelClass);
            Controls.Add(labelDate);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(labelAddStudent);
            Name = "setAttendance";
            Size = new Size(934, 464);
            Load += setAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddStudent;
        private DataGridView dataGridViewAttendance;
        private Panel panel2;
        private Panel panel1;
        private Label labelClass;
        private Label labelDate;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxDate;
    }
}
