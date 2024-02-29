namespace attendence_system.Admin.userControl
{
    partial class UserControlAttendance
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
            tabPageViewAttendance = new TabPage();
            dataGridViewAttendance = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            labelSearchBy = new Label();
            comboBoxSearchBy = new ComboBox();
            labelSearch = new Label();
            textBoxSearchAttend = new TextBox();
            comboBoxClass = new ComboBox();
            panel2 = new Panel();
            labelClass = new Label();
            labelAddStudent = new Label();
            tabControlSetAttendance = new TabControl();
            tabPageViewAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlSetAttendance.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageViewAttendance
            // 
            tabPageViewAttendance.BackColor = Color.White;
            tabPageViewAttendance.Controls.Add(dataGridViewAttendance);
            tabPageViewAttendance.Controls.Add(pictureBox1);
            tabPageViewAttendance.Controls.Add(labelSearchBy);
            tabPageViewAttendance.Controls.Add(comboBoxSearchBy);
            tabPageViewAttendance.Controls.Add(labelSearch);
            tabPageViewAttendance.Controls.Add(textBoxSearchAttend);
            tabPageViewAttendance.Controls.Add(comboBoxClass);
            tabPageViewAttendance.Controls.Add(panel2);
            tabPageViewAttendance.Controls.Add(labelClass);
            tabPageViewAttendance.Controls.Add(labelAddStudent);
            tabPageViewAttendance.Location = new Point(4, 24);
            tabPageViewAttendance.Margin = new Padding(3, 2, 3, 2);
            tabPageViewAttendance.Name = "tabPageViewAttendance";
            tabPageViewAttendance.Padding = new Padding(3, 2, 3, 2);
            tabPageViewAttendance.Size = new Size(927, 415);
            tabPageViewAttendance.TabIndex = 1;
            tabPageViewAttendance.Text = "SetAttendance";
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
            dataGridViewAttendance.Location = new Point(31, 119);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAttendance.ShowCellErrors = false;
            dataGridViewAttendance.ShowEditingIcon = false;
            dataGridViewAttendance.ShowRowErrors = false;
            dataGridViewAttendance.Size = new Size(872, 318);
            dataGridViewAttendance.TabIndex = 50;
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.searchInstructor;
            pictureBox1.Location = new Point(969, 67);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // labelSearchBy
            // 
            labelSearchBy.Anchor = AnchorStyles.Top;
            labelSearchBy.AutoSize = true;
            labelSearchBy.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearchBy.Location = new Point(513, 28);
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
            comboBoxSearchBy.Location = new Point(607, 21);
            comboBoxSearchBy.Margin = new Padding(3, 2, 3, 2);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(124, 23);
            comboBoxSearchBy.TabIndex = 47;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelSearch.Location = new Point(489, 79);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(56, 16);
            labelSearch.TabIndex = 46;
            labelSearch.Text = "Search:";
            // 
            // textBoxSearchAttend
            // 
            textBoxSearchAttend.Anchor = AnchorStyles.Top;
            textBoxSearchAttend.Location = new Point(607, 72);
            textBoxSearchAttend.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchAttend.Name = "textBoxSearchAttend";
            textBoxSearchAttend.Size = new Size(124, 23);
            textBoxSearchAttend.TabIndex = 45;
            textBoxSearchAttend.TextChanged += textBoxSearchAttend_TextChanged;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "All" });
            comboBoxClass.Location = new Point(1388, 69);
            comboBoxClass.Margin = new Padding(3, 2, 3, 2);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(114, 23);
            comboBoxClass.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Location = new Point(1388, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 2);
            panel2.TabIndex = 37;
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClass.Location = new Point(1388, 45);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(50, 16);
            labelClass.TabIndex = 35;
            labelClass.Text = "Class :";
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.Transparent;
            labelAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelAddStudent.Location = new Point(34, 17);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(91, 16);
            labelAddStudent.TabIndex = 33;
            labelAddStudent.Text = "Attendance :";
            // 
            // tabControlSetAttendance
            // 
            tabControlSetAttendance.Controls.Add(tabPageViewAttendance);
            tabControlSetAttendance.Dock = DockStyle.Fill;
            tabControlSetAttendance.Location = new Point(0, 0);
            tabControlSetAttendance.Margin = new Padding(3, 2, 3, 2);
            tabControlSetAttendance.Name = "tabControlSetAttendance";
            tabControlSetAttendance.SelectedIndex = 0;
            tabControlSetAttendance.Size = new Size(935, 443);
            tabControlSetAttendance.TabIndex = 34;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlSetAttendance);
            Name = "UserControlAttendance";
            Size = new Size(935, 443);
            tabPageViewAttendance.ResumeLayout(false);
            tabPageViewAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlSetAttendance.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageViewAttendance;
        private DataGridView dataGridViewAttendance;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox pictureBox1;
        private Label labelSearchBy;
        private ComboBox comboBoxSearchBy;
        private Label labelSearch;
        private TextBox textBoxSearchAttend;
        private ComboBox comboBoxClass;
        private Panel panel2;
        private Label labelClass;
        private Label labelAddStudent;
        private TabControl tabControlSetAttendance;
    }
}
