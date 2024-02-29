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
            buttonExportCSV = new Button();
            buttonExportExcel = new Button();
            buttonExportPDF = new Button();
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
            tabControlSetAttendance.Margin = new Padding(3, 2, 3, 2);
            tabControlSetAttendance.Name = "tabControlSetAttendance";
            tabControlSetAttendance.SelectedIndex = 0;
            tabControlSetAttendance.Size = new Size(817, 348);
            tabControlSetAttendance.TabIndex = 33;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(809, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SetAttendance";
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToAddRows = false;
            dataGridViewAttendance.AllowUserToDeleteRows = false;
            dataGridViewAttendance.AllowUserToResizeColumns = false;
            dataGridViewAttendance.AllowUserToResizeRows = false;
            dataGridViewAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = Color.White;
            dataGridViewAttendance.BorderStyle = BorderStyle.None;
            dataGridViewAttendance.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.EnableHeadersVisualStyles = false;
            dataGridViewAttendance.Location = new Point(18, 111);
            dataGridViewAttendance.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.ShowCellErrors = false;
            dataGridViewAttendance.ShowEditingIcon = false;
            dataGridViewAttendance.ShowRowErrors = false;
            dataGridViewAttendance.Size = new Size(760, 195);
            dataGridViewAttendance.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.searchInstructor;
            pictureBox1.Location = new Point(570, 69);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.FromArgb(67, 3, 125);
            panel5.Location = new Point(437, 45);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(132, 2);
            panel5.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Location = new Point(376, 90);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(193, 2);
            panel4.TabIndex = 39;
            // 
            // labelSearchBy
            // 
            labelSearchBy.Anchor = AnchorStyles.Top;
            labelSearchBy.AutoSize = true;
            labelSearchBy.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearchBy.Location = new Point(340, 17);
            labelSearchBy.Name = "labelSearchBy";
            labelSearchBy.Size = new Size(76, 16);
            labelSearchBy.TabIndex = 48;
            labelSearchBy.Text = "Search By:";
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.Anchor = AnchorStyles.Top;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "name", "phone", "Both" });
            comboBoxSearchBy.Location = new Point(436, 17);
            comboBoxSearchBy.Margin = new Padding(3, 2, 3, 2);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(133, 23);
            comboBoxSearchBy.TabIndex = 47;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearch.Location = new Point(313, 72);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(56, 16);
            labelSearch.TabIndex = 46;
            labelSearch.Text = "Search:";
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Anchor = AnchorStyles.Top;
            textBoxSearchValue.Location = new Point(375, 65);
            textBoxSearchValue.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(194, 23);
            textBoxSearchValue.TabIndex = 45;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.Location = new Point(18, 65);
            dateTimePickerFrom.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFrom.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(125, 23);
            dateTimePickerFrom.TabIndex = 44;
            dateTimePickerFrom.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged_1;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.Location = new Point(158, 65);
            dateTimePickerTo.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerTo.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(125, 23);
            dateTimePickerTo.TabIndex = 43;
            dateTimePickerTo.Value = new DateTime(2024, 2, 28, 9, 33, 48, 0);
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDateTo.Location = new Point(158, 43);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(59, 16);
            labelDateTo.TabIndex = 42;
            labelDateTo.Text = "Date To:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 3, 125);
            panel3.Location = new Point(158, 92);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 2);
            panel3.TabIndex = 41;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "All" });
            comboBoxClass.Location = new Point(614, 65);
            comboBoxClass.Margin = new Padding(3, 2, 3, 2);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(114, 23);
            comboBoxClass.TabIndex = 40;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Location = new Point(614, 90);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 2);
            panel2.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Location = new Point(18, 92);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 2);
            panel1.TabIndex = 36;
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClass.Location = new Point(614, 41);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(50, 16);
            labelClass.TabIndex = 35;
            labelClass.Text = "Class :";
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelDateFrom.Location = new Point(18, 43);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(76, 16);
            labelDateFrom.TabIndex = 34;
            labelDateFrom.Text = "Date From:";
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.Transparent;
            labelAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelAddStudent.Location = new Point(4, 20);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(114, 16);
            labelAddStudent.TabIndex = 33;
            labelAddStudent.Text = "Set Attendance :";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonExportCSV);
            tabPage1.Controls.Add(buttonExportExcel);
            tabPage1.Controls.Add(buttonExportPDF);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(809, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Export";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExportCSV
            // 
            buttonExportCSV.Location = new Point(114, 213);
            buttonExportCSV.Margin = new Padding(3, 2, 3, 2);
            buttonExportCSV.Name = "buttonExportCSV";
            buttonExportCSV.Size = new Size(165, 58);
            buttonExportCSV.TabIndex = 2;
            buttonExportCSV.Text = "CSV";
            buttonExportCSV.UseVisualStyleBackColor = true;
            buttonExportCSV.Click += buttonExportCSV_Click;
            // 
            // buttonExportExcel
            // 
            buttonExportExcel.Location = new Point(114, 109);
            buttonExportExcel.Margin = new Padding(3, 2, 3, 2);
            buttonExportExcel.Name = "buttonExportExcel";
            buttonExportExcel.Size = new Size(165, 77);
            buttonExportExcel.TabIndex = 1;
            buttonExportExcel.Text = "Excel";
            buttonExportExcel.UseVisualStyleBackColor = true;
            buttonExportExcel.Click += buttonExportExcel_Click;
            // 
            // buttonExportPDF
            // 
            buttonExportPDF.Location = new Point(386, 109);
            buttonExportPDF.Margin = new Padding(3, 2, 3, 2);
            buttonExportPDF.Name = "buttonExportPDF";
            buttonExportPDF.Size = new Size(196, 77);
            buttonExportPDF.TabIndex = 0;
            buttonExportPDF.Text = "PDF";
            buttonExportPDF.UseVisualStyleBackColor = true;
            buttonExportPDF.Click += buttonExportPDF_Click;
            // 
            // setAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlSetAttendance);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "setAttendance";
            Size = new Size(817, 348);
            Load += setAttendance_Load;
            tabControlSetAttendance.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage1.ResumeLayout(false);
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
        private Button buttonExportExcel;
        private Button buttonExportPDF;
        private Button button1;
        private Button buttonExportCSV;
    }
}
