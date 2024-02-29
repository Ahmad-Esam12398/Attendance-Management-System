namespace attendence_system.Admin.userControl
{
    partial class UserControlAddStudent
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            tabPageSearchStudent = new TabPage();
            textBoxSearch = new TextBox();
            comboBoxSearchBy = new ComboBox();
            panel11 = new Panel();
            label7 = new Label();
            labelTotalStudents = new Label();
            label6 = new Label();
            dataGridViewStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            srearch = new Label();
            label8 = new Label();
            tabPageAddStudent = new TabPage();
            comboBoxGender = new ComboBox();
            panel4 = new Panel();
            label5 = new Label();
            panel12 = new Panel();
            textBoxphoneNumber = new TextBox();
            label14 = new Label();
            comboBoxClassStudent = new ComboBox();
            panel10 = new Panel();
            labelClassStudent = new Label();
            panel3 = new Panel();
            btnAddStudent = new Button();
            textBoxPassStudent = new TextBox();
            textBoxEmailstudent = new TextBox();
            textBoxNameStudent = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabControlAddStudent = new TabControl();
            tabPageUpdateAndDelete = new TabPage();
            comboBoxGender1 = new ComboBox();
            panel13 = new Panel();
            label15 = new Label();
            panel14 = new Panel();
            textBoxphoneNumber1 = new TextBox();
            label16 = new Label();
            comboBoxClasses1 = new ComboBox();
            panel8 = new Panel();
            label12 = new Label();
            panel6 = new Panel();
            btnDeleteStudent = new Button();
            textBoxpass1 = new TextBox();
            btnUpdateStudent = new Button();
            panel7 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label13 = new Label();
            textBoxEmail1 = new TextBox();
            textBoxName1 = new TextBox();
            label10 = new Label();
            panel9 = new Panel();
            tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            tabPageAddStudent.SuspendLayout();
            tabControlAddStudent.SuspendLayout();
            tabPageUpdateAndDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageSearchStudent
            // 
            tabPageSearchStudent.BackColor = Color.White;
            tabPageSearchStudent.Controls.Add(textBoxSearch);
            tabPageSearchStudent.Controls.Add(comboBoxSearchBy);
            tabPageSearchStudent.Controls.Add(panel11);
            tabPageSearchStudent.Controls.Add(label7);
            tabPageSearchStudent.Controls.Add(labelTotalStudents);
            tabPageSearchStudent.Controls.Add(label6);
            tabPageSearchStudent.Controls.Add(dataGridViewStudent);
            tabPageSearchStudent.Controls.Add(panel5);
            tabPageSearchStudent.Controls.Add(srearch);
            tabPageSearchStudent.Controls.Add(label8);
            tabPageSearchStudent.Location = new Point(4, 29);
            tabPageSearchStudent.Name = "tabPageSearchStudent";
            tabPageSearchStudent.Padding = new Padding(3);
            tabPageSearchStudent.Size = new Size(935, 438);
            tabPageSearchStudent.TabIndex = 1;
            tabPageSearchStudent.Text = "SrearchStudent ";
            tabPageSearchStudent.Enter += tabPageSearchStudent_Enter;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10F);
            textBoxSearch.Location = new Point(152, 82);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(270, 21);
            textBoxSearch.TabIndex = 58;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged_1;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Name", "Email", "Class" });
            comboBoxSearchBy.Location = new Point(518, 75);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(152, 29);
            comboBoxSearchBy.TabIndex = 57;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(518, 101);
            panel11.Name = "panel11";
            panel11.Size = new Size(151, 2);
            panel11.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.Location = new Point(518, 36);
            label7.Name = "label7";
            label7.Size = new Size(91, 19);
            label7.TabIndex = 54;
            label7.Text = "Search By";
            // 
            // labelTotalStudents
            // 
            labelTotalStudents.AutoSize = true;
            labelTotalStudents.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            labelTotalStudents.ForeColor = SystemColors.GrayText;
            labelTotalStudents.Location = new Point(862, 397);
            labelTotalStudents.Name = "labelTotalStudents";
            labelTotalStudents.Size = new Size(26, 17);
            labelTotalStudents.TabIndex = 17;
            labelTotalStudents.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(767, 397);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 16;
            label6.Text = "TotalStudent:";
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AllowUserToResizeColumns = false;
            dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.BackgroundColor = Color.White;
            dataGridViewStudent.BorderStyle = BorderStyle.None;
            dataGridViewStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6, Column4 });
            dataGridViewStudent.GridColor = SystemColors.InactiveCaption;
            dataGridViewStudent.Location = new Point(31, 119);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudent.ShowCellErrors = false;
            dataGridViewStudent.ShowEditingIcon = false;
            dataGridViewStudent.ShowRowErrors = false;
            dataGridViewStudent.Size = new Size(872, 318);
            dataGridViewStudent.TabIndex = 15;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick_1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "email";
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "class";
            Column5.HeaderText = "Class";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "phone";
            Column6.HeaderText = "phone";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "gender";
            Column4.HeaderText = "gender";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(152, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 14;
            // 
            // srearch
            // 
            srearch.AutoSize = true;
            srearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            srearch.Location = new Point(152, 45);
            srearch.Name = "srearch";
            srearch.Size = new Size(71, 19);
            srearch.TabIndex = 12;
            srearch.Text = "Search:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(31, 23);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 11;
            label8.Text = "Search Student";
            // 
            // tabPageAddStudent
            // 
            tabPageAddStudent.BackColor = Color.White;
            tabPageAddStudent.Controls.Add(comboBoxGender);
            tabPageAddStudent.Controls.Add(panel4);
            tabPageAddStudent.Controls.Add(label5);
            tabPageAddStudent.Controls.Add(panel12);
            tabPageAddStudent.Controls.Add(textBoxphoneNumber);
            tabPageAddStudent.Controls.Add(label14);
            tabPageAddStudent.Controls.Add(comboBoxClassStudent);
            tabPageAddStudent.Controls.Add(panel10);
            tabPageAddStudent.Controls.Add(labelClassStudent);
            tabPageAddStudent.Controls.Add(panel3);
            tabPageAddStudent.Controls.Add(btnAddStudent);
            tabPageAddStudent.Controls.Add(textBoxPassStudent);
            tabPageAddStudent.Controls.Add(textBoxEmailstudent);
            tabPageAddStudent.Controls.Add(textBoxNameStudent);
            tabPageAddStudent.Controls.Add(panel2);
            tabPageAddStudent.Controls.Add(label4);
            tabPageAddStudent.Controls.Add(label3);
            tabPageAddStudent.Controls.Add(panel1);
            tabPageAddStudent.Controls.Add(label2);
            tabPageAddStudent.Controls.Add(label1);
            tabPageAddStudent.Location = new Point(4, 30);
            tabPageAddStudent.Name = "tabPageAddStudent";
            tabPageAddStudent.Padding = new Padding(3);
            tabPageAddStudent.Size = new Size(935, 437);
            tabPageAddStudent.TabIndex = 0;
            tabPageAddStudent.Text = "Add Student";
            tabPageAddStudent.Click += tabPageAddStudent_Click;
            tabPageAddStudent.Leave += tabPageAddStudent_Leave;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "female", "male" });
            comboBoxGender.Location = new Point(147, 313);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(270, 29);
            comboBoxGender.TabIndex = 64;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(147, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(147, 284);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 62;
            label5.Text = "Gender:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Location = new Point(461, 343);
            panel12.Name = "panel12";
            panel12.Size = new Size(270, 2);
            panel12.TabIndex = 61;
            // 
            // textBoxphoneNumber
            // 
            textBoxphoneNumber.BackColor = Color.White;
            textBoxphoneNumber.BorderStyle = BorderStyle.None;
            textBoxphoneNumber.Font = new Font("Century Gothic", 10F);
            textBoxphoneNumber.Location = new Point(461, 320);
            textBoxphoneNumber.Name = "textBoxphoneNumber";
            textBoxphoneNumber.Size = new Size(270, 21);
            textBoxphoneNumber.TabIndex = 60;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label14.Location = new Point(461, 275);
            label14.Name = "label14";
            label14.Size = new Size(138, 19);
            label14.TabIndex = 59;
            label14.Text = "phone Number:";
            // 
            // comboBoxClassStudent
            // 
            comboBoxClassStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClassStudent.FlatStyle = FlatStyle.Flat;
            comboBoxClassStudent.FormattingEnabled = true;
            comboBoxClassStudent.Items.AddRange(new object[] { "---Name--", "name ", "class ", "email", "" });
            comboBoxClassStudent.Location = new Point(147, 215);
            comboBoxClassStudent.Name = "comboBoxClassStudent";
            comboBoxClassStudent.Size = new Size(270, 29);
            comboBoxClassStudent.TabIndex = 58;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(147, 247);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 53;
            // 
            // labelClassStudent
            // 
            labelClassStudent.AutoSize = true;
            labelClassStudent.BackColor = Color.White;
            labelClassStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelClassStudent.Location = new Point(147, 186);
            labelClassStudent.Name = "labelClassStudent";
            labelClassStudent.Size = new Size(58, 19);
            labelClassStudent.TabIndex = 51;
            labelClassStudent.Text = "Class:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(461, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 50;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.HotTrack;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAddStudent.ForeColor = SystemColors.ControlLightLight;
            btnAddStudent.Location = new Point(139, 382);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(124, 40);
            btnAddStudent.TabIndex = 42;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click_1;
            // 
            // textBoxPassStudent
            // 
            textBoxPassStudent.BackColor = Color.White;
            textBoxPassStudent.BorderStyle = BorderStyle.None;
            textBoxPassStudent.Font = new Font("Century Gothic", 10F);
            textBoxPassStudent.Location = new Point(461, 222);
            textBoxPassStudent.Name = "textBoxPassStudent";
            textBoxPassStudent.Size = new Size(270, 21);
            textBoxPassStudent.TabIndex = 47;
            // 
            // textBoxEmailstudent
            // 
            textBoxEmailstudent.BackColor = Color.White;
            textBoxEmailstudent.BorderStyle = BorderStyle.None;
            textBoxEmailstudent.Font = new Font("Century Gothic", 10F);
            textBoxEmailstudent.Location = new Point(461, 117);
            textBoxEmailstudent.Name = "textBoxEmailstudent";
            textBoxEmailstudent.Size = new Size(270, 21);
            textBoxEmailstudent.TabIndex = 40;
            // 
            // textBoxNameStudent
            // 
            textBoxNameStudent.BackColor = Color.White;
            textBoxNameStudent.BorderStyle = BorderStyle.None;
            textBoxNameStudent.Font = new Font("Century Gothic", 10F);
            textBoxNameStudent.Location = new Point(139, 117);
            textBoxNameStudent.Name = "textBoxNameStudent";
            textBoxNameStudent.Size = new Size(270, 21);
            textBoxNameStudent.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(461, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(461, 177);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 46;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(461, 72);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 39;
            label3.Text = "Email:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(139, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(139, 72);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 36;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(42, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 35;
            label1.Text = "Add Student";
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Controls.Add(tabPageAddStudent);
            tabControlAddStudent.Controls.Add(tabPageSearchStudent);
            tabControlAddStudent.Controls.Add(tabPageUpdateAndDelete);
            tabControlAddStudent.Location = new Point(0, 0);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(943, 471);
            tabControlAddStudent.TabIndex = 0;
            tabControlAddStudent.Enter += tabControlAddStudent_Enter;
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.BackColor = Color.White;
            tabPageUpdateAndDelete.Controls.Add(comboBoxGender1);
            tabPageUpdateAndDelete.Controls.Add(panel13);
            tabPageUpdateAndDelete.Controls.Add(label15);
            tabPageUpdateAndDelete.Controls.Add(panel14);
            tabPageUpdateAndDelete.Controls.Add(textBoxphoneNumber1);
            tabPageUpdateAndDelete.Controls.Add(label16);
            tabPageUpdateAndDelete.Controls.Add(comboBoxClasses1);
            tabPageUpdateAndDelete.Controls.Add(panel8);
            tabPageUpdateAndDelete.Controls.Add(label12);
            tabPageUpdateAndDelete.Controls.Add(panel6);
            tabPageUpdateAndDelete.Controls.Add(btnDeleteStudent);
            tabPageUpdateAndDelete.Controls.Add(textBoxpass1);
            tabPageUpdateAndDelete.Controls.Add(btnUpdateStudent);
            tabPageUpdateAndDelete.Controls.Add(panel7);
            tabPageUpdateAndDelete.Controls.Add(label11);
            tabPageUpdateAndDelete.Controls.Add(label9);
            tabPageUpdateAndDelete.Controls.Add(label13);
            tabPageUpdateAndDelete.Controls.Add(textBoxEmail1);
            tabPageUpdateAndDelete.Controls.Add(textBoxName1);
            tabPageUpdateAndDelete.Controls.Add(label10);
            tabPageUpdateAndDelete.Controls.Add(panel9);
            tabPageUpdateAndDelete.Location = new Point(4, 29);
            tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            tabPageUpdateAndDelete.Padding = new Padding(3);
            tabPageUpdateAndDelete.Size = new Size(935, 438);
            tabPageUpdateAndDelete.TabIndex = 2;
            tabPageUpdateAndDelete.Text = "Update&Delete";
          //  tabPageUpdateAndDelete.Enter += tabPageUpdateAndDelete_Enter;
            tabPageUpdateAndDelete.Leave += tabPageUpdateAndDelete_Leave;
            // 
            // comboBoxGender1
            // 
            comboBoxGender1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender1.FlatStyle = FlatStyle.Flat;
            comboBoxGender1.FormattingEnabled = true;
            comboBoxGender1.Items.AddRange(new object[] { "female", "male" });
            comboBoxGender1.Location = new Point(144, 281);
            comboBoxGender1.Name = "comboBoxGender1";
            comboBoxGender1.Size = new Size(270, 29);
            comboBoxGender1.TabIndex = 86;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Location = new Point(144, 313);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 2);
            panel13.TabIndex = 85;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label15.Location = new Point(144, 252);
            label15.Name = "label15";
            label15.Size = new Size(76, 19);
            label15.TabIndex = 84;
            label15.Text = "Gender:";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Location = new Point(476, 313);
            panel14.Name = "panel14";
            panel14.Size = new Size(270, 2);
            panel14.TabIndex = 83;
            // 
            // textBoxphoneNumber1
            // 
            textBoxphoneNumber1.BackColor = Color.White;
            textBoxphoneNumber1.BorderStyle = BorderStyle.None;
            textBoxphoneNumber1.Font = new Font("Century Gothic", 10F);
            textBoxphoneNumber1.Location = new Point(476, 290);
            textBoxphoneNumber1.Name = "textBoxphoneNumber1";
            textBoxphoneNumber1.Size = new Size(270, 21);
            textBoxphoneNumber1.TabIndex = 82;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label16.Location = new Point(476, 245);
            label16.Name = "label16";
            label16.Size = new Size(138, 19);
            label16.TabIndex = 81;
            label16.Text = "phone Number:";
            // 
            // comboBoxClasses1
            // 
            comboBoxClasses1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClasses1.FlatStyle = FlatStyle.Flat;
            comboBoxClasses1.FormattingEnabled = true;
            comboBoxClasses1.Items.AddRange(new object[] { "---Name--", "name ", "class ", "email", "" });
            comboBoxClasses1.Location = new Point(144, 193);
            comboBoxClasses1.Name = "comboBoxClasses1";
            comboBoxClasses1.Size = new Size(270, 29);
            comboBoxClasses1.TabIndex = 80;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(144, 225);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 79;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label12.Location = new Point(144, 164);
            label12.Name = "label12";
            label12.Size = new Size(58, 19);
            label12.TabIndex = 78;
            label12.Text = "Class:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(476, 225);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 77;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = Color.Red;
            btnDeleteStudent.FlatAppearance.BorderSize = 0;
            btnDeleteStudent.FlatStyle = FlatStyle.Flat;
            btnDeleteStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDeleteStudent.ForeColor = SystemColors.ControlLightLight;
            btnDeleteStudent.Location = new Point(261, 358);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(124, 40);
            btnDeleteStudent.TabIndex = 68;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // textBoxpass1
            // 
            textBoxpass1.BackColor = Color.White;
            textBoxpass1.BorderStyle = BorderStyle.None;
            textBoxpass1.Font = new Font("Century Gothic", 10F);
            textBoxpass1.Location = new Point(476, 202);
            textBoxpass1.Name = "textBoxpass1";
            textBoxpass1.Size = new Size(270, 21);
            textBoxpass1.TabIndex = 76;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.Green;
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdateStudent.ForeColor = SystemColors.ControlLightLight;
            btnUpdateStudent.Location = new Point(120, 358);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(124, 40);
            btnUpdateStudent.TabIndex = 67;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(476, 129);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(27, 26);
            label11.Name = "label11";
            label11.Size = new Size(169, 19);
            label11.TabIndex = 66;
            label11.Text = "Update And Delete ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(476, 157);
            label9.Name = "label9";
            label9.Size = new Size(92, 19);
            label9.TabIndex = 75;
            label9.Text = "Password:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label13.Location = new Point(144, 58);
            label13.Name = "label13";
            label13.Size = new Size(70, 19);
            label13.TabIndex = 69;
            label13.Text = "Name :";
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.BackColor = Color.White;
            textBoxEmail1.BorderStyle = BorderStyle.None;
            textBoxEmail1.Font = new Font("Century Gothic", 10F);
            textBoxEmail1.Location = new Point(476, 105);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(270, 21);
            textBoxEmail1.TabIndex = 73;
            // 
            // textBoxName1
            // 
            textBoxName1.BackColor = Color.White;
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Font = new Font("Century Gothic", 10F);
            textBoxName1.Location = new Point(144, 103);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(270, 21);
            textBoxName1.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.Location = new Point(476, 60);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 72;
            label10.Text = "Email:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(144, 127);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 71;
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddStudent);
            Font = new Font("Century Gothic", 9.75F);
            Name = "UserControlAddStudent";
            Size = new Size(934, 471);
            tabPageSearchStudent.ResumeLayout(false);
            tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            tabPageAddStudent.ResumeLayout(false);
            tabPageAddStudent.PerformLayout();
            tabControlAddStudent.ResumeLayout(false);
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private TabPage tabPageSearchStudent;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSearchBy;
        private Panel panel11;
        private Label label7;
        private Label labelTotalStudents;
        private Label label6;
        private DataGridView dataGridViewStudent;
        private Panel panel5;
        private Label srearch;
        private Label label8;
        private TabPage tabPageAddStudent;
        private ComboBox comboBoxClassStudent;
        private Panel panel10;
        private Label labelClassStudent;
        private Panel panel3;
        private Button btnAddStudent;
        private TextBox textBoxPassStudent;
        private TextBox textBoxEmailstudent;
        private TextBox textBoxNameStudent;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TabControl tabControlAddStudent;
        private TabPage tabPageUpdateAndDelete;
        private ComboBox comboBoxClasses1;
        private Panel panel8;
        private Label label12;
        private Panel panel6;
        private Button btnDeleteStudent;
        private TextBox textBoxpass1;
        private Button btnUpdateStudent;
        private Panel panel7;
        private Label label11;
        private Label label9;
        private Label label13;
        private TextBox textBoxEmail1;
        private TextBox textBoxName1;
        private Label label10;
        private Panel panel9;
        private ComboBox comboBoxGender;
        private Panel panel4;
        private Label label5;
        private Panel panel12;
        private TextBox textBoxphoneNumber;
        private Label label14;
        private ComboBox comboBoxGender1;
        private Panel panel13;
        private Label label15;
        private Panel panel14;
        private TextBox textBoxphoneNumber1;
        private Label label16;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
    }
}
