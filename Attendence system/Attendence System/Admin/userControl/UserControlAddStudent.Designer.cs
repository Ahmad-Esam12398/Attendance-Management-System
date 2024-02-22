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
            tabPageAddStudent = new TabPage();
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
            comboBoxUpDelete = new ComboBox();
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
            tabPageSearchStudent.Controls.Add(textBox6);
            tabPageSearchStudent.Controls.Add(comboBoxSearchBy);
            tabPageSearchStudent.Controls.Add(panel11);
            tabPageSearchStudent.Controls.Add(label7);
            tabPageSearchStudent.Controls.Add(labelTotalStudents);
            tabPageSearchStudent.Controls.Add(label6);
            tabPageSearchStudent.Controls.Add(dataGridViewStudent);
            tabPageSearchStudent.Controls.Add(panel5);
            tabPageSearchStudent.Controls.Add(srearch);
            tabPageSearchStudent.Controls.Add(label8);
            tabPageSearchStudent.Location = new Point(4, 26);
            tabPageSearchStudent.Name = "tabPageSearchStudent";
            tabPageSearchStudent.Padding = new Padding(3);
            tabPageSearchStudent.Size = new Size(935, 441);
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
            textBoxSearch.Size = new Size(270, 17);
            textBoxSearch.TabIndex = 58;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
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
            comboBoxSearchBy.Size = new Size(152, 25);
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
            label7.Size = new Size(72, 16);
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
            labelTotalStudents.Size = new Size(21, 15);
            labelTotalStudents.TabIndex = 17;
            labelTotalStudents.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(767, 397);
            label6.Name = "label6";
            label6.Size = new Size(90, 16);
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
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dataGridViewStudent.Location = new Point(31, 119);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudent.ShowCellErrors = false;
            dataGridViewStudent.ShowEditingIcon = false;
            dataGridViewStudent.ShowRowErrors = false;
            dataGridViewStudent.Size = new Size(872, 318);
            dataGridViewStudent.TabIndex = 15;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
           // dataGridViewStudent.CellContentClick += dataGridViewStudent_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "class";
            Column5.HeaderText = "Class";
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Email";
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Password";
            Column4.HeaderText = "password";
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
            srearch.Location = new Point(152, 45);
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
            label8.Location = new Point(31, 23);
            label8.Name = "label8";
            label8.Size = new Size(94, 17);
            label8.TabIndex = 11;
            label8.Text = "Search Class";
            // 
            // tabPageAddStudent
            // 
            tabPageAddStudent.BackColor = Color.White;
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
            tabPageAddStudent.Location = new Point(4, 26);
            tabPageAddStudent.Name = "tabPageAddStudent";
            tabPageAddStudent.Padding = new Padding(3);
            tabPageAddStudent.Size = new Size(935, 441);
            tabPageAddStudent.TabIndex = 0;
            tabPageAddStudent.Text = "Add Student";
            tabPageAddStudent.Leave += tabPageAddStudent_Leave;
            // 
            // comboBoxClassStudent
            // 
            comboBoxClassStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClassStudent.FlatStyle = FlatStyle.Flat;
            comboBoxClassStudent.FormattingEnabled = true;
            comboBoxClassStudent.Items.AddRange(new object[] { "---Name--", "name ", "class ", "email", "" });
            comboBoxClassStudent.Location = new Point(147, 215);
            comboBoxClassStudent.Name = "comboBoxClassStudent";
            comboBoxClassStudent.Size = new Size(270, 25);
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
            textBoxPassStudent.Size = new Size(270, 17);
            textBoxPassStudent.TabIndex = 47;
            // 
            // textBoxEmailstudent
            // 
            textBoxEmailstudent.BackColor = Color.White;
            textBoxEmailstudent.BorderStyle = BorderStyle.None;
            textBoxEmailstudent.Font = new Font("Century Gothic", 10F);
            textBoxEmailstudent.Location = new Point(461, 117);
            textBoxEmailstudent.Name = "textBoxEmailstudent";
            textBoxEmailstudent.Size = new Size(270, 17);
            textBoxEmailstudent.TabIndex = 40;
            // 
            // textBoxNameStudent
            // 
            textBoxNameStudent.BackColor = Color.White;
            textBoxNameStudent.BorderStyle = BorderStyle.None;
            textBoxNameStudent.Font = new Font("Century Gothic", 10F);
            textBoxNameStudent.Location = new Point(139, 117);
            textBoxNameStudent.Name = "textBoxNameStudent";
            textBoxNameStudent.Size = new Size(270, 17);
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
            label4.Size = new Size(71, 16);
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
            label2.Location = new Point(139, 72);
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
            label1.Location = new Point(42, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
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
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpDelete);
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
            comboBoxUpDelete.Size = new Size(270, 25);
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
            label12.Location = new Point(158, 199);
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
            textBoxpass1.Location = new Point(442, 235);
            textBoxpass1.Name = "textBoxpass1";
            textBoxpass1.Size = new Size(270, 17);
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
            btnUpdateStudent.Click += btnUpdateStudent_Click;
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
            label11.Location = new Point(30, 33);
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
            label9.Location = new Point(442, 190);
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
            label13.Location = new Point(150, 85);
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
            label10.Location = new Point(442, 85);
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
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
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
        private ComboBox comboBoxUpDelete;
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
    }
}
