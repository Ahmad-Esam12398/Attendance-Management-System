namespace attendence_system.Admin.userControl
{
    partial class UserControlAddTeacher
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
            tabControlAddTeacher = new TabControl();
            tabPageAddTeacher = new TabPage();
            comboBoxClassTeacher = new ComboBox();
            panel10 = new Panel();
            labelClassStudent = new Label();
            panel3 = new Panel();
            btnAddStudent = new Button();
            textBoxPassTeacher = new TextBox();
            textBoxEmailTeacher = new TextBox();
            textBoxTeacherName = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchTeacher = new TabPage();
            textBoxSearch = new TextBox();
            textBox6 = new TextBox();
            comboBoxSearchBy = new ComboBox();
            panel11 = new Panel();
            label7 = new Label();
            labelTotalStudents = new Label();
            label6 = new Label();
            dataGridViewStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            srearch = new Label();
            label8 = new Label();
            tabPageUpdateAndDelete = new TabPage();
            comboBoxUpDelete = new ComboBox();
            panel8 = new Panel();
            label12 = new Label();
            panel6 = new Panel();
            btnDeleteTeacher = new Button();
            textBoxpass1 = new TextBox();
            btnUpdateTeachers = new Button();
            panel7 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label13 = new Label();
            textBoxEmail1 = new TextBox();
            textBoxName1 = new TextBox();
            label10 = new Label();
            panel9 = new Panel();
            userControlChangeUserData1 = new Instructor.UserControlChangeUserData();
            tabControlAddTeacher.SuspendLayout();
            tabPageAddTeacher.SuspendLayout();
            tabPageSearchTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            tabPageUpdateAndDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddTeacher
            // 
            tabControlAddTeacher.Controls.Add(tabPageAddTeacher);
            tabControlAddTeacher.Controls.Add(tabPageSearchTeacher);
            tabControlAddTeacher.Controls.Add(tabPageUpdateAndDelete);
            tabControlAddTeacher.Location = new Point(-4, 0);
            tabControlAddTeacher.Name = "tabControlAddTeacher";
            tabControlAddTeacher.SelectedIndex = 0;
            tabControlAddTeacher.Size = new Size(943, 471);
            tabControlAddTeacher.TabIndex = 1;
            // 
            // tabPageAddTeacher
            // 
            tabPageAddTeacher.BackColor = Color.White;
            tabPageAddTeacher.Controls.Add(userControlChangeUserData1);
            tabPageAddTeacher.Controls.Add(comboBoxClassTeacher);
            tabPageAddTeacher.Controls.Add(panel10);
            tabPageAddTeacher.Controls.Add(labelClassStudent);
            tabPageAddTeacher.Controls.Add(panel3);
            tabPageAddTeacher.Controls.Add(btnAddStudent);
            tabPageAddTeacher.Controls.Add(textBoxPassTeacher);
            tabPageAddTeacher.Controls.Add(textBoxEmailTeacher);
            tabPageAddTeacher.Controls.Add(textBoxTeacherName);
            tabPageAddTeacher.Controls.Add(panel2);
            tabPageAddTeacher.Controls.Add(label4);
            tabPageAddTeacher.Controls.Add(label3);
            tabPageAddTeacher.Controls.Add(panel1);
            tabPageAddTeacher.Controls.Add(label2);
            tabPageAddTeacher.Controls.Add(label1);
            tabPageAddTeacher.Location = new Point(4, 24);
            tabPageAddTeacher.Name = "tabPageAddTeacher";
            tabPageAddTeacher.Padding = new Padding(3);
            tabPageAddTeacher.Size = new Size(935, 443);
            tabPageAddTeacher.TabIndex = 0;
            tabPageAddTeacher.Text = "Add Teacher";
            // 
            // comboBoxClassTeacher
            // 
            comboBoxClassTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClassTeacher.FlatStyle = FlatStyle.Flat;
            comboBoxClassTeacher.FormattingEnabled = true;
            comboBoxClassTeacher.Items.AddRange(new object[] { "---Name--", "name ", "class ", "email", "" });
            comboBoxClassTeacher.Location = new Point(147, 215);
            comboBoxClassTeacher.Name = "comboBoxClassTeacher";
            comboBoxClassTeacher.Size = new Size(270, 23);
            comboBoxClassTeacher.TabIndex = 58;
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
            labelClassStudent.Location = new Point(150, 189);
            labelClassStudent.Name = "labelClassStudent";
            labelClassStudent.Size = new Size(46, 16);
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
            btnAddStudent.Text = "Add Teacher";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddTeacher_Click;
            // 
            // textBoxPassTeacher
            // 
            textBoxPassTeacher.BackColor = Color.White;
            textBoxPassTeacher.BorderStyle = BorderStyle.None;
            textBoxPassTeacher.Font = new Font("Century Gothic", 10F);
            textBoxPassTeacher.Location = new Point(461, 222);
            textBoxPassTeacher.Name = "textBoxPassTeacher";
            textBoxPassTeacher.Size = new Size(270, 17);
            textBoxPassTeacher.TabIndex = 47;
            // 
            // textBoxEmailTeacher
            // 
            textBoxEmailTeacher.BackColor = Color.White;
            textBoxEmailTeacher.BorderStyle = BorderStyle.None;
            textBoxEmailTeacher.Font = new Font("Century Gothic", 10F);
            textBoxEmailTeacher.Location = new Point(461, 117);
            textBoxEmailTeacher.Name = "textBoxEmailTeacher";
            textBoxEmailTeacher.Size = new Size(270, 17);
            textBoxEmailTeacher.TabIndex = 40;
            // 
            // textBoxTeacherName
            // 
            textBoxTeacherName.BackColor = Color.White;
            textBoxTeacherName.BorderStyle = BorderStyle.None;
            textBoxTeacherName.Font = new Font("Century Gothic", 10F);
            textBoxTeacherName.Location = new Point(139, 117);
            textBoxTeacherName.Name = "textBoxTeacherName";
            textBoxTeacherName.Size = new Size(270, 17);
            textBoxTeacherName.TabIndex = 37;
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
            label4.Location = new Point(464, 180);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 46;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(464, 75);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
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
            label2.Location = new Point(142, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 36;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(45, 37);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 35;
            label1.Text = "Add Teacher";
            // 
            // tabPageSearchTeacher
            // 
            tabPageSearchTeacher.BackColor = Color.White;
            tabPageSearchTeacher.Controls.Add(textBoxSearch);
            tabPageSearchTeacher.Controls.Add(textBox6);
            tabPageSearchTeacher.Controls.Add(comboBoxSearchBy);
            tabPageSearchTeacher.Controls.Add(panel11);
            tabPageSearchTeacher.Controls.Add(label7);
            tabPageSearchTeacher.Controls.Add(labelTotalStudents);
            tabPageSearchTeacher.Controls.Add(label6);
            tabPageSearchTeacher.Controls.Add(dataGridViewStudent);
            tabPageSearchTeacher.Controls.Add(panel5);
            tabPageSearchTeacher.Controls.Add(srearch);
            tabPageSearchTeacher.Controls.Add(label8);
            tabPageSearchTeacher.Location = new Point(4, 24);
            tabPageSearchTeacher.Name = "tabPageSearchTeacher";
            tabPageSearchTeacher.Padding = new Padding(3);
            tabPageSearchTeacher.Size = new Size(935, 443);
            tabPageSearchTeacher.TabIndex = 1;
            tabPageSearchTeacher.Text = "SrearchTeacher";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10F);
            textBoxSearch.Location = new Point(152, 82);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(270, 17);
            textBoxSearch.TabIndex = 58;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Century Gothic", 10F);
            textBox6.Location = new Point(400, 77);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 17);
            textBox6.TabIndex = 55;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Name", "Email", "Class" });
            comboBoxSearchBy.Location = new Point(518, 75);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(152, 23);
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
            label7.Location = new Point(521, 39);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 54;
            label7.Text = "Search By";
            // 
            // labelTotalStudents
            // 
            labelTotalStudents.AutoSize = true;
            labelTotalStudents.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            labelTotalStudents.ForeColor = SystemColors.GrayText;
            labelTotalStudents.Location = new Point(865, 400);
            labelTotalStudents.Name = "labelTotalStudents";
            labelTotalStudents.Size = new Size(21, 15);
            labelTotalStudents.TabIndex = 17;
            labelTotalStudents.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(759, 399);
            label6.Name = "label6";
            label6.Size = new Size(100, 16);
            label6.TabIndex = 16;
            label6.Text = "TotalTeachers:";
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
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dataGridViewStudent.Location = new Point(31, 119);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudent.ShowCellErrors = false;
            dataGridViewStudent.ShowEditingIcon = false;
            dataGridViewStudent.ShowRowErrors = false;
            dataGridViewStudent.Size = new Size(872, 318);
            dataGridViewStudent.TabIndex = 15;
            dataGridViewStudent.CellContentClick += dataGridViewTeacher_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "class";
            Column5.HeaderText = "Class";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Email";
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Password";
            Column4.HeaderText = "password";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
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
            srearch.Location = new Point(155, 48);
            srearch.Name = "srearch";
            srearch.Size = new Size(56, 16);
            srearch.TabIndex = 12;
            srearch.Text = "Search:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(34, 26);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 11;
            label8.Text = "Search ";
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.BackColor = Color.White;
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpDelete);
            tabPageUpdateAndDelete.Controls.Add(panel8);
            tabPageUpdateAndDelete.Controls.Add(label12);
            tabPageUpdateAndDelete.Controls.Add(panel6);
            tabPageUpdateAndDelete.Controls.Add(btnDeleteTeacher);
            tabPageUpdateAndDelete.Controls.Add(textBoxpass1);
            tabPageUpdateAndDelete.Controls.Add(btnUpdateTeachers);
            tabPageUpdateAndDelete.Controls.Add(panel7);
            tabPageUpdateAndDelete.Controls.Add(label11);
            tabPageUpdateAndDelete.Controls.Add(label9);
            tabPageUpdateAndDelete.Controls.Add(label13);
            tabPageUpdateAndDelete.Controls.Add(textBoxEmail1);
            tabPageUpdateAndDelete.Controls.Add(textBoxName1);
            tabPageUpdateAndDelete.Controls.Add(label10);
            tabPageUpdateAndDelete.Controls.Add(panel9);
            tabPageUpdateAndDelete.Location = new Point(4, 24);
            tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            tabPageUpdateAndDelete.Padding = new Padding(3);
            tabPageUpdateAndDelete.Size = new Size(935, 443);
            tabPageUpdateAndDelete.TabIndex = 2;
            tabPageUpdateAndDelete.Text = "Update&Delete";
            // 
            // comboBoxUpDelete
            // 
            comboBoxUpDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpDelete.FlatStyle = FlatStyle.Flat;
            comboBoxUpDelete.FormattingEnabled = true;
            comboBoxUpDelete.Items.AddRange(new object[] { "---Name--", "name ", "class ", "email", "" });
            comboBoxUpDelete.Location = new Point(144, 228);
            comboBoxUpDelete.Name = "comboBoxUpDelete";
            comboBoxUpDelete.Size = new Size(270, 23);
            comboBoxUpDelete.TabIndex = 80;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(144, 260);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 79;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label12.Location = new Point(161, 202);
            label12.Name = "label12";
            label12.Size = new Size(46, 16);
            label12.TabIndex = 78;
            label12.Text = "Class:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(442, 258);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 77;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.BackColor = Color.Red;
            btnDeleteTeacher.FlatAppearance.BorderSize = 0;
            btnDeleteTeacher.FlatStyle = FlatStyle.Flat;
            btnDeleteTeacher.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDeleteTeacher.ForeColor = SystemColors.ControlLightLight;
            btnDeleteTeacher.Location = new Point(261, 358);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(124, 40);
            btnDeleteTeacher.TabIndex = 68;
            btnDeleteTeacher.Text = "Delete";
            btnDeleteTeacher.UseVisualStyleBackColor = false;
            // 
            // textBoxpass1
            // 
            textBoxpass1.BackColor = Color.White;
            textBoxpass1.BorderStyle = BorderStyle.None;
            textBoxpass1.Font = new Font("Century Gothic", 10F);
            textBoxpass1.Location = new Point(442, 235);
            textBoxpass1.Name = "textBoxpass1";
            textBoxpass1.Size = new Size(270, 17);
            textBoxpass1.TabIndex = 76;
            // 
            // btnUpdateTeachers
            // 
            btnUpdateTeachers.BackColor = Color.Green;
            btnUpdateTeachers.FlatAppearance.BorderSize = 0;
            btnUpdateTeachers.FlatStyle = FlatStyle.Flat;
            btnUpdateTeachers.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdateTeachers.ForeColor = SystemColors.ControlLightLight;
            btnUpdateTeachers.Location = new Point(120, 358);
            btnUpdateTeachers.Name = "btnUpdateTeachers";
            btnUpdateTeachers.Size = new Size(124, 40);
            btnUpdateTeachers.TabIndex = 67;
            btnUpdateTeachers.Text = "Update";
            btnUpdateTeachers.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(442, 154);
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
            label11.Location = new Point(33, 36);
            label11.Name = "label11";
            label11.Size = new Size(141, 17);
            label11.TabIndex = 66;
            label11.Text = "Update And Delete ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(445, 193);
            label9.Name = "label9";
            label9.Size = new Size(71, 16);
            label9.TabIndex = 75;
            label9.Text = "Password:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label13.Location = new Point(153, 88);
            label13.Name = "label13";
            label13.Size = new Size(54, 16);
            label13.TabIndex = 69;
            label13.Text = "Name :";
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.BackColor = Color.White;
            textBoxEmail1.BorderStyle = BorderStyle.None;
            textBoxEmail1.Font = new Font("Century Gothic", 10F);
            textBoxEmail1.Location = new Point(442, 130);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(270, 17);
            textBoxEmail1.TabIndex = 73;
            // 
            // textBoxName1
            // 
            textBoxName1.BackColor = Color.White;
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Font = new Font("Century Gothic", 10F);
            textBoxName1.Location = new Point(134, 130);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(270, 17);
            textBoxName1.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.Location = new Point(445, 88);
            label10.Name = "label10";
            label10.Size = new Size(47, 16);
            label10.TabIndex = 72;
            label10.Text = "Email:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(134, 154);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 71;
            // 
            // userControlChangeUserData1
            // 
            userControlChangeUserData1.BackColor = Color.White;
            userControlChangeUserData1.Location = new Point(0, 0);
            userControlChangeUserData1.Margin = new Padding(3, 2, 3, 2);
            userControlChangeUserData1.Name = "userControlChangeUserData1";
            userControlChangeUserData1.Size = new Size(935, 441);
            userControlChangeUserData1.TabIndex = 2;
            // 
            // UserControlAddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddTeacher);
            Name = "UserControlAddTeacher";
            Size = new Size(934, 471);
            tabControlAddTeacher.ResumeLayout(false);
            tabPageAddTeacher.ResumeLayout(false);
            tabPageAddTeacher.PerformLayout();
            tabPageSearchTeacher.ResumeLayout(false);
            tabPageSearchTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddTeacher;
        private TabPage tabPageAddTeacher;
        private ComboBox comboBoxClassTeacher;
        private Panel panel10;
        private Label labelClassStudent;
        private Panel panel3;
        private Button btnAddStudent;
        private TextBox textBoxPassTeacher;
        private TextBox textBoxEmailTeacher;
        private TextBox textBoxTeacherName;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TabPage tabPageSearchTeacher;
        private TextBox textBoxSearch;
        private TextBox textBox6;
        private ComboBox comboBoxSearchBy;
        private Panel panel11;
        private Label label7;
        private Label labelTotalStudents;
        private Label label6;
        private DataGridView dataGridViewStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel5;
        private Label srearch;
        private Label label8;
        private TabPage tabPageUpdateAndDelete;
        private ComboBox comboBoxUpDelete;
        private Panel panel8;
        private Label label12;
        private Panel panel6;
        private Button btnDeleteTeacher;
        private TextBox textBoxpass1;
        private Button btnUpdateTeachers;
        private Panel panel7;
        private Label label11;
        private Label label9;
        private Label label13;
        private TextBox textBoxEmail1;
        private TextBox textBoxName1;
        private Label label10;
        private Panel panel9;
        private Instructor.UserControlChangeUserData userControlChangeUserData1;
    }
}
