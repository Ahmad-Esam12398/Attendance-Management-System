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
            tabControlSetAttendance = new TabControl();
            tabPage2 = new TabPage();
            dataGridViewAttendance = new DataGridView();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            labelSearchBy = new Label();
            comboBoxSearchBy = new ComboBox();
            labelSearch = new Label();
            textBoxSearchValue = new TextBox();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            labelDateTo = new Label();
            panel3 = new Panel();
            comboBoxClass = new ComboBox();
            panel2 = new Panel();
            panel1 = new Panel();
            labelClass = new Label();
            labelDateFrom = new Label();
            labelAddStudent = new Label();
            tabPage1 = new TabPage();
            label1 = new Label();
            buttonSaveAs = new Button();
            comboBoxFileType = new ComboBox();
            label2 = new Label();
            tabControlSetAttendance.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlSetAttendance
            // 
            tabControlSetAttendance.Controls.Add(tabPage2);
            tabControlSetAttendance.Controls.Add(tabPage1);
            tabControlSetAttendance.Dock = DockStyle.Fill;
            tabControlSetAttendance.Location = new Point(0, 0);
            tabControlSetAttendance.Name = "tabControlSetAttendance";
            tabControlSetAttendance.SelectedIndex = 0;
            tabControlSetAttendance.Size = new Size(934, 464);
            tabControlSetAttendance.TabIndex = 33;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewAttendance);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(labelSearchBy);
            tabPage2.Controls.Add(comboBoxSearchBy);
            tabPage2.Controls.Add(labelSearch);
            tabPage2.Controls.Add(textBoxSearchValue);
            tabPage2.Controls.Add(dateTimePickerFrom);
            tabPage2.Controls.Add(dateTimePickerTo);
            tabPage2.Controls.Add(labelDateTo);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(comboBoxClass);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(labelClass);
            tabPage2.Controls.Add(labelDateFrom);
            tabPage2.Controls.Add(labelAddStudent);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(926, 431);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SetAttendance";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(-4, 145);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(927, 290);
            dataGridViewAttendance.TabIndex = 50;
            dataGridViewAttendance.CellContentClick += dataGridViewAttendance_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.searchInstructor;
            pictureBox1.Location = new Point(693, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.FromArgb(67, 3, 125);
            panel5.Location = new Point(499, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(151, 2);
            panel5.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Location = new Point(466, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 2);
            panel4.TabIndex = 39;
            // 
            // labelSearchBy
            // 
            labelSearchBy.Anchor = AnchorStyles.Top;
            labelSearchBy.AutoSize = true;
            labelSearchBy.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearchBy.Location = new Point(389, 23);
            labelSearchBy.Name = "labelSearchBy";
            labelSearchBy.Size = new Size(96, 19);
            labelSearchBy.TabIndex = 48;
            labelSearchBy.Text = "Search By:";
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.Anchor = AnchorStyles.Top;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "name", "phone", "Both" });
            comboBoxSearchBy.Location = new Point(499, 23);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(151, 28);
            comboBoxSearchBy.TabIndex = 47;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearch.Location = new Point(389, 90);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(71, 19);
            labelSearch.TabIndex = 46;
            labelSearch.Text = "Search:";
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Anchor = AnchorStyles.Top;
            textBoxSearchValue.Location = new Point(466, 87);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(221, 27);
            textBoxSearchValue.TabIndex = 45;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.Location = new Point(21, 87);
            dateTimePickerFrom.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(142, 27);
            dateTimePickerFrom.TabIndex = 44;
            dateTimePickerFrom.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged_1;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.Location = new Point(180, 87);
            dateTimePickerTo.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(142, 27);
            dateTimePickerTo.TabIndex = 43;
            dateTimePickerTo.Value = new DateTime(2024, 2, 28, 9, 33, 48, 0);
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDateTo.Location = new Point(180, 57);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(75, 19);
            labelDateTo.TabIndex = 42;
            labelDateTo.Text = "Date To:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 3, 125);
            panel3.Location = new Point(180, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 2);
            panel3.TabIndex = 41;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "All" });
            comboBoxClass.Location = new Point(759, 89);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(130, 28);
            comboBoxClass.TabIndex = 40;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Location = new Point(759, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 2);
            panel2.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Location = new Point(21, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 2);
            panel1.TabIndex = 36;
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClass.Location = new Point(759, 57);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(63, 19);
            labelClass.TabIndex = 35;
            labelClass.Text = "Class :";
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDateFrom.Location = new Point(21, 57);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(97, 19);
            labelDateFrom.TabIndex = 34;
            labelDateFrom.Text = "Date From:";
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.Transparent;
            labelAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelAddStudent.Location = new Point(3, 13);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(144, 19);
            labelAddStudent.TabIndex = 33;
            labelAddStudent.Text = "Set Attendance :";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonSaveAs);
            tabPage1.Controls.Add(comboBoxFileType);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(926, 431);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Export";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.Location = new Point(611, 61);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 37;
            label1.Text = "Save As:";
            // 
            // buttonSaveAs
            // 
            buttonSaveAs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSaveAs.Location = new Point(790, 99);
            buttonSaveAs.Name = "buttonSaveAs";
            buttonSaveAs.Size = new Size(113, 28);
            buttonSaveAs.TabIndex = 36;
            buttonSaveAs.Text = "Save";
            buttonSaveAs.UseVisualStyleBackColor = true;
            buttonSaveAs.Click += buttonSaveAs_Click;
            // 
            // comboBoxFileType
            // 
            comboBoxFileType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxFileType.FormattingEnabled = true;
            comboBoxFileType.Items.AddRange(new object[] { "PDF", "Excel", "CSV" });
            comboBoxFileType.Location = new Point(611, 99);
            comboBoxFileType.Name = "comboBoxFileType";
            comboBoxFileType.Size = new Size(151, 28);
            comboBoxFileType.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(6, 15);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 34;
            label2.Text = "Export Data:";
            // 
            // setAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlSetAttendance);
            Cursor = Cursors.Hand;
            Name = "setAttendance";
            Size = new Size(934, 464);
            Load += setAttendance_Load;
            tabControlSetAttendance.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private TabControl tabControlSetAttendance;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewAttendance;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel4;
        private Label labelSearchBy;
        private ComboBox comboBoxSearchBy;
        private Label labelSearch;
        private TextBox textBoxSearchValue;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label labelDateTo;
        private Panel panel3;
        private ComboBox comboBoxClass;
        private Panel panel2;
        private Panel panel1;
        private Label labelClass;
        private Label labelDateFrom;
        private Label labelAddStudent;
        private Button button1;
        private Button buttonSaveAs;
        private ComboBox comboBoxFileType;
        private Label label2;
        private Label label1;
    }
}
