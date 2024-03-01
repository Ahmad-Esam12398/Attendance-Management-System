namespace attendence_system.Admin.userControl
{
    partial class UserControlAttendanceV2
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
            dataGridViewAttendance = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            labelSearchBy = new Label();
            comboBoxSearchBy = new ComboBox();
            labelSearch = new Label();
            textBoxSearchAttend = new TextBox();
            labelAddStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToAddRows = false;
            dataGridViewAttendance.AllowUserToDeleteRows = false;
            dataGridViewAttendance.AllowUserToResizeColumns = false;
            dataGridViewAttendance.AllowUserToResizeRows = false;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = Color.White;
            dataGridViewAttendance.BorderStyle = BorderStyle.None;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewAttendance.GridColor = SystemColors.InactiveCaption;
            dataGridViewAttendance.Location = new Point(56, 141);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAttendance.ShowCellErrors = false;
            dataGridViewAttendance.ShowEditingIcon = false;
            dataGridViewAttendance.ShowRowErrors = false;
            dataGridViewAttendance.Size = new Size(872, 318);
            dataGridViewAttendance.TabIndex = 56;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "phone";
            Column3.HeaderText = "Phone";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "gender";
            Column4.HeaderText = "Gender";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "class";
            Column5.HeaderText = "Class";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "date";
            Column6.HeaderText = "Date";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // labelSearchBy
            // 
            labelSearchBy.Anchor = AnchorStyles.Top;
            labelSearchBy.AutoSize = true;
            labelSearchBy.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearchBy.Location = new Point(519, 97);
            labelSearchBy.Name = "labelSearchBy";
            labelSearchBy.Size = new Size(76, 16);
            labelSearchBy.TabIndex = 55;
            labelSearchBy.Text = "Search By:";
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.Anchor = AnchorStyles.Top;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "name", "phone", "Both" });
            comboBoxSearchBy.Location = new Point(613, 90);
            comboBoxSearchBy.Margin = new Padding(3, 2, 3, 2);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(124, 23);
            comboBoxSearchBy.TabIndex = 54;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearch.Location = new Point(281, 97);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(56, 16);
            labelSearch.TabIndex = 53;
            labelSearch.Text = "Search:";
            // 
            // textBoxSearchAttend
            // 
            textBoxSearchAttend.Anchor = AnchorStyles.Top;
            textBoxSearchAttend.Location = new Point(375, 90);
            textBoxSearchAttend.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchAttend.Name = "textBoxSearchAttend";
            textBoxSearchAttend.Size = new Size(124, 23);
            textBoxSearchAttend.TabIndex = 52;
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.Transparent;
            labelAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelAddStudent.Location = new Point(59, 39);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(91, 16);
            labelAddStudent.TabIndex = 51;
            labelAddStudent.Text = "Attendance :";
            // 
            // UserControlAttendanceV2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridViewAttendance);
            Controls.Add(labelSearchBy);
            Controls.Add(comboBoxSearchBy);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearchAttend);
            Controls.Add(labelAddStudent);
            Name = "UserControlAttendanceV2";
            Size = new Size(945, 443);
            Load += UserControlAttendanceV2_Load;
           // Enter += UserControlAttendanceV2_Enter;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAttendance;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label labelSearchBy;
        private ComboBox comboBoxSearchBy;
        private Label labelSearch;
        private TextBox textBoxSearchAttend;
        private Label labelAddStudent;
    }
}
