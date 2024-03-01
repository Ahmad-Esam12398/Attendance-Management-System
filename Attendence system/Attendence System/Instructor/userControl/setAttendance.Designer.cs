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
            tabPage1 = new TabPage();
            label3 = new Label();
            buttonSave = new Button();
            comboBoxExtension = new ComboBox();
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(926, 431);
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
            dataGridViewAttendance.Location = new Point(21, 148);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.ShowCellErrors = false;
            dataGridViewAttendance.ShowEditingIcon = false;
            dataGridViewAttendance.ShowRowErrors = false;
            dataGridViewAttendance.Size = new Size(869, 260);
            dataGridViewAttendance.TabIndex = 50;
            dataGridViewAttendance.CellContentClick += dataGridViewAttendance_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.searchInstructor;
            pictureBox1.Location = new Point(651, 92);
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
            panel5.Size = new Size(151, 3);
            panel5.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Location = new Point(430, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 3);
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
            comboBoxSearchBy.Location = new Point(498, 23);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(151, 28);
            comboBoxSearchBy.TabIndex = 47;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearch.Location = new Point(358, 96);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(71, 19);
            labelSearch.TabIndex = 46;
            labelSearch.Text = "Search:";
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Anchor = AnchorStyles.Top;
            textBoxSearchValue.Location = new Point(429, 87);
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
            dateTimePickerTo.Location = new Point(181, 87);
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
            labelDateTo.Location = new Point(181, 57);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(75, 19);
            labelDateTo.TabIndex = 42;
            labelDateTo.Text = "Date To:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 3, 125);
            panel3.Location = new Point(181, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 3);
            panel3.TabIndex = 41;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "All" });
            comboBoxClass.Location = new Point(702, 87);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(130, 28);
            comboBoxClass.TabIndex = 40;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Location = new Point(702, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 3);
            panel2.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Location = new Point(21, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 3);
            panel1.TabIndex = 36;
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClass.Location = new Point(702, 55);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(buttonSave);
            tabPage1.Controls.Add(comboBoxExtension);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(926, 431);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Export";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(271, 124);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 2;
            label3.Text = "Save As:";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold);
            buttonSave.Location = new Point(544, 119);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(113, 38);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxExtension
            // 
            comboBoxExtension.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxExtension.FormattingEnabled = true;
            comboBoxExtension.Items.AddRange(new object[] { "PDF", "Excel", "CSV" });
            comboBoxExtension.Location = new Point(366, 124);
            comboBoxExtension.Name = "comboBoxExtension";
            comboBoxExtension.Size = new Size(151, 28);
            comboBoxExtension.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // buttonSaveAs
            // 
            buttonSaveAs.Location = new Point(0, 0);
            buttonSaveAs.Name = "buttonSaveAs";
            buttonSaveAs.Size = new Size(75, 23);
            buttonSaveAs.TabIndex = 0;
            // 
            // comboBoxFileType
            // 
            comboBoxFileType.Location = new Point(0, 0);
            comboBoxFileType.Name = "comboBoxFileType";
            comboBoxFileType.Size = new Size(121, 28);
            comboBoxFileType.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
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
        private Button button1;
        private Button buttonSaveAs;
        private ComboBox comboBoxFileType;
        private Label label2;
        private Label label1;
        private Button buttonSave;
        private ComboBox comboBoxExtension;
        private Label label3;
    }
}
