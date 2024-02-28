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
            labelDateFrom = new Label();
            comboBoxClass = new ComboBox();
            panel3 = new Panel();
            labelDateTo = new Label();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            textBoxSearchValue = new TextBox();
            labelSearch = new Label();
            comboBoxSearchBy = new ComboBox();
            labelSearchBy = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dataGridViewAttendance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(0, 148);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(934, 316);
            dataGridViewAttendance.TabIndex = 3;
            dataGridViewAttendance.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Location = new Point(773, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 2);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Location = new Point(20, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 2);
            panel1.TabIndex = 18;
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClass.Location = new Point(773, 44);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(63, 19);
            labelClass.TabIndex = 16;
            labelClass.Text = "Class :";
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDateFrom.Location = new Point(20, 44);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(97, 19);
            labelDateFrom.TabIndex = 14;
            labelDateFrom.Text = "Date From:";
            // 
            // comboBoxClass
            // 
            comboBoxClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "All" });
            comboBoxClass.Location = new Point(773, 76);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(130, 28);
            comboBoxClass.TabIndex = 20;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 3, 125);
            panel3.Location = new Point(179, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 2);
            panel3.TabIndex = 22;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDateTo.Location = new Point(179, 44);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(75, 19);
            labelDateTo.TabIndex = 24;
            labelDateTo.Text = "Date To:";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.Location = new Point(179, 74);
            dateTimePickerTo.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(142, 27);
            dateTimePickerTo.TabIndex = 26;
            dateTimePickerTo.Value = new DateTime(2024, 2, 28, 9, 33, 48, 0);
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.Location = new Point(20, 74);
            dateTimePickerFrom.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(142, 27);
            dateTimePickerFrom.TabIndex = 27;
            dateTimePickerFrom.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Anchor = AnchorStyles.Top;
            textBoxSearchValue.Location = new Point(517, 10);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(221, 27);
            textBoxSearchValue.TabIndex = 28;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearch.Location = new Point(440, 13);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(71, 19);
            labelSearch.TabIndex = 29;
            labelSearch.Text = "Search:";
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.Anchor = AnchorStyles.Top;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "name", "phone", "Both" });
            comboBoxSearchBy.Location = new Point(542, 73);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(151, 28);
            comboBoxSearchBy.TabIndex = 30;
            // 
            // labelSearchBy
            // 
            labelSearchBy.Anchor = AnchorStyles.Top;
            labelSearchBy.AutoSize = true;
            labelSearchBy.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearchBy.Location = new Point(440, 82);
            labelSearchBy.Name = "labelSearchBy";
            labelSearchBy.Size = new Size(96, 19);
            labelSearchBy.TabIndex = 31;
            labelSearchBy.Text = "Search By:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Location = new Point(517, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 2);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.FromArgb(67, 3, 125);
            panel5.Location = new Point(542, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(151, 2);
            panel5.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.searchInstructor;
            pictureBox1.Location = new Point(698, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // setAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(labelSearchBy);
            Controls.Add(comboBoxSearchBy);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearchValue);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(dateTimePickerTo);
            Controls.Add(labelDateTo);
            Controls.Add(panel3);
            Controls.Add(comboBoxClass);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelClass);
            Controls.Add(labelDateFrom);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(labelAddStudent);
            Cursor = Cursors.Hand;
            Name = "setAttendance";
            Size = new Size(934, 464);
            Load += setAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddStudent;
        private DataGridView dataGridViewAttendance;
        private Panel panel2;
        private Panel panel1;
        private Label labelClass;
        private Label labelDateFrom;
        private ComboBox comboBoxClass;
        private Panel panel3;
        private Label labelDateTo;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private TextBox textBoxSearchValue;
        private Label labelSearch;
        private ComboBox comboBoxSearchBy;
        private Label labelSearchBy;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
    }
}
