﻿namespace attendence_system.Admin.userControl
{
    partial class UserControlAddClass
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
            toolTip = new ToolTip(components);
            tabPageAddClass = new TabPage();
            btnAddClass = new Button();
            panel2 = new Panel();
            textBoxHMstudent = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabControlAddClass = new TabControl();
            tabPageSearchClass = new TabPage();
            labelTotalClasses = new Label();
            label6 = new Label();
            dataGridViewClass = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            textBoxSearchBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tabPageUpdateAndDelete = new TabPage();
            btnDeleteClass = new Button();
            btnUpdateClass = new Button();
            panel4 = new Panel();
            textBoxHMstudent1 = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            textBoxName1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            tabPageAddClass.SuspendLayout();
            tabControlAddClass.SuspendLayout();
            tabPageSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
            tabPageUpdateAndDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageAddClass
            // 
            tabPageAddClass.BackColor = Color.White;
            tabPageAddClass.Controls.Add(btnAddClass);
            tabPageAddClass.Controls.Add(panel2);
            tabPageAddClass.Controls.Add(textBoxHMstudent);
            tabPageAddClass.Controls.Add(label3);
            tabPageAddClass.Controls.Add(panel1);
            tabPageAddClass.Controls.Add(textBoxName);
            tabPageAddClass.Controls.Add(label2);
            tabPageAddClass.Controls.Add(label1);
            tabPageAddClass.Cursor = Cursors.IBeam;
            tabPageAddClass.Location = new Point(4, 4);
            tabPageAddClass.Name = "tabPageAddClass";
            tabPageAddClass.Padding = new Padding(3);
            tabPageAddClass.Size = new Size(934, 471);
            tabPageAddClass.TabIndex = 0;
            tabPageAddClass.Text = "Add Class";
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = Color.Navy;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAddClass.ForeColor = SystemColors.ControlLightLight;
            btnAddClass.Location = new Point(115, 362);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(124, 40);
            btnAddClass.TabIndex = 7;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(437, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 6;
            // 
            // textBoxHMstudent
            // 
            textBoxHMstudent.BorderStyle = BorderStyle.None;
            textBoxHMstudent.Font = new Font("Century Gothic", 10F);
            textBoxHMstudent.Location = new Point(437, 151);
            textBoxHMstudent.Name = "textBoxHMstudent";
            textBoxHMstudent.Size = new Size(270, 17);
            textBoxHMstudent.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(437, 106);
            label3.Name = "label3";
            label3.Size = new Size(134, 16);
            label3.TabIndex = 4;
            label3.Text = "How Many Student?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(115, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Century Gothic", 10F);
            textBoxName.Location = new Point(115, 151);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 17);
            textBoxName.TabIndex = 2;

         //   textBoxName.TextChanged += this.textBoxName_TextChanged;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(115, 106);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "Add Class";
            // 
            // tabControlAddClass
            // 
            tabControlAddClass.Alignment = TabAlignment.Bottom;
            tabControlAddClass.Controls.Add(tabPageAddClass);
            tabControlAddClass.Controls.Add(tabPageSearchClass);
            tabControlAddClass.Controls.Add(tabPageUpdateAndDelete);
            tabControlAddClass.Dock = DockStyle.Fill;
            tabControlAddClass.Location = new Point(0, 0);
            tabControlAddClass.Name = "tabControlAddClass";
            tabControlAddClass.SelectedIndex = 0;
            tabControlAddClass.Size = new Size(942, 501);
            tabControlAddClass.TabIndex = 0;
            tabControlAddClass.Leave += tabControlAddClass_Leave;
            // 
            // tabPageSearchClass
            // 
            tabPageSearchClass.BackColor = Color.White;
            tabPageSearchClass.Controls.Add(labelTotalClasses);
            tabPageSearchClass.Controls.Add(label6);
            tabPageSearchClass.Controls.Add(dataGridViewClass);
            tabPageSearchClass.Controls.Add(panel3);
            tabPageSearchClass.Controls.Add(textBoxSearchBox);
            tabPageSearchClass.Controls.Add(label4);
            tabPageSearchClass.Controls.Add(label5);
            tabPageSearchClass.Location = new Point(4, 4);
            tabPageSearchClass.Name = "tabPageSearchClass";
            tabPageSearchClass.Padding = new Padding(3);
            tabPageSearchClass.Size = new Size(934, 471);
            tabPageSearchClass.TabIndex = 1;
            tabPageSearchClass.Text = "Search Class";
            // 
            // labelTotalClasses
            // 
            labelTotalClasses.AutoSize = true;
            labelTotalClasses.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            labelTotalClasses.ForeColor = SystemColors.GrayText;
            labelTotalClasses.Location = new Point(837, 410);
            labelTotalClasses.Name = "labelTotalClasses";
            labelTotalClasses.Size = new Size(21, 15);
            labelTotalClasses.TabIndex = 10;
            labelTotalClasses.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(742, 410);
            label6.Name = "label6";
            label6.Size = new Size(91, 16);
            label6.TabIndex = 9;
            label6.Text = "TotalClasses:";
            // 
            // dataGridViewClass
            // 
            dataGridViewClass.AllowUserToAddRows = false;
            dataGridViewClass.AllowUserToDeleteRows = false;
            dataGridViewClass.AllowUserToResizeColumns = false;
            dataGridViewClass.AllowUserToResizeRows = false;
            dataGridViewClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClass.BackgroundColor = Color.White;
            dataGridViewClass.BorderStyle = BorderStyle.None;
            dataGridViewClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClass.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewClass.Location = new Point(6, 132);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewClass.ShowCellErrors = false;
            dataGridViewClass.ShowEditingIcon = false;
            dataGridViewClass.ShowRowErrors = false;
            dataGridViewClass.Size = new Size(872, 318);
            dataGridViewClass.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "How many student";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "TeacherName";
            Column4.Name = "Column4";
            // 
            // panel3
            // 
            panel3.Location = new Point(114, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 7;
            // 
            // textBoxSearchBox
            // 
            textBoxSearchBox.BorderStyle = BorderStyle.None;
            textBoxSearchBox.Font = new Font("Century Gothic", 10F);
            textBoxSearchBox.Location = new Point(114, 94);
            textBoxSearchBox.Name = "textBoxSearchBox";
            textBoxSearchBox.Size = new Size(270, 17);
            textBoxSearchBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(114, 58);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 5;
            label4.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(17, 17);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 4;
            label5.Text = "Search Class";
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.BackColor = Color.White;
            tabPageUpdateAndDelete.Controls.Add(btnDeleteClass);
            tabPageUpdateAndDelete.Controls.Add(btnUpdateClass);
            tabPageUpdateAndDelete.Controls.Add(panel4);
            tabPageUpdateAndDelete.Controls.Add(textBoxHMstudent1);
            tabPageUpdateAndDelete.Controls.Add(label7);
            tabPageUpdateAndDelete.Controls.Add(panel5);
            tabPageUpdateAndDelete.Controls.Add(textBoxName1);
            tabPageUpdateAndDelete.Controls.Add(label8);
            tabPageUpdateAndDelete.Controls.Add(label9);
            tabPageUpdateAndDelete.Location = new Point(4, 4);
            tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            tabPageUpdateAndDelete.Padding = new Padding(3);
            tabPageUpdateAndDelete.Size = new Size(934, 471);
            tabPageUpdateAndDelete.TabIndex = 2;
            tabPageUpdateAndDelete.Text = "Update and Delete";
            tabPageUpdateAndDelete.Leave += tabPageUpdateAndDelete_Leave;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.BackColor = Color.Red;
            btnDeleteClass.FlatAppearance.BorderSize = 0;
            btnDeleteClass.FlatStyle = FlatStyle.Flat;
            btnDeleteClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDeleteClass.ForeColor = SystemColors.ControlLightLight;
            btnDeleteClass.Location = new Point(245, 364);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(124, 40);
            btnDeleteClass.TabIndex = 17;
            btnDeleteClass.Text = "Delete";
            btnDeleteClass.UseVisualStyleBackColor = false;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // btnUpdateClass
            // 
            btnUpdateClass.BackColor = Color.Green;
            btnUpdateClass.FlatAppearance.BorderSize = 0;
            btnUpdateClass.FlatStyle = FlatStyle.Flat;
            btnUpdateClass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdateClass.ForeColor = SystemColors.ControlLightLight;
            btnUpdateClass.Location = new Point(104, 364);
            btnUpdateClass.Name = "btnUpdateClass";
            btnUpdateClass.Size = new Size(124, 40);
            btnUpdateClass.TabIndex = 16;
            btnUpdateClass.Text = "Update";
            btnUpdateClass.UseVisualStyleBackColor = false;
            btnUpdateClass.Click += btnUpdateClass_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(438, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 15;
            // 
            // textBoxHMstudent1
            // 
            textBoxHMstudent1.BorderStyle = BorderStyle.None;
            textBoxHMstudent1.Font = new Font("Century Gothic", 10F);
            textBoxHMstudent1.Location = new Point(438, 162);
            textBoxHMstudent1.Name = "textBoxHMstudent1";
            textBoxHMstudent1.Size = new Size(270, 17);
            textBoxHMstudent1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.Location = new Point(438, 117);
            label7.Name = "label7";
            label7.Size = new Size(134, 16);
            label7.TabIndex = 13;
            label7.Text = "How Many Student?";
            // 
            // panel5
            // 
            panel5.Location = new Point(116, 186);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 12;
            // 
            // textBoxName1
            // 
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Font = new Font("Century Gothic", 10F);
            textBoxName1.Location = new Point(116, 162);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(270, 17);
            textBoxName1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label8.Location = new Point(116, 117);
            label8.Name = "label8";
            label8.Size = new Size(54, 16);
            label8.TabIndex = 10;
            label8.Text = "Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(19, 29);
            label9.Name = "label9";
            label9.Size = new Size(141, 17);
            label9.TabIndex = 9;
            label9.Text = "Update And Delete ";
            // 
            // UserControlAddClass
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddClass);
            Font = new Font("Century Gothic", 9.75F);
            Name = "UserControlAddClass";
            Size = new Size(942, 501);
            tabPageAddClass.ResumeLayout(false);
            tabPageAddClass.PerformLayout();
            tabControlAddClass.ResumeLayout(false);
            tabPageSearchClass.ResumeLayout(false);
            tabPageSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabPage tabPageAddClass;
        private Panel panel2;
        private TextBox textBoxHMstudent;
        private TextBox textBoxName;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TabControl tabControlAddClass;
        private TabPage tabPageSearchClass;
        private DataGridView dataGridViewClass;
        private Panel panel3;
        private TextBox textBoxSearchBox;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label labelTotalClasses;
        private Label label6;
        private TabPage tabPageUpdateAndDelete;
        private Button btnDeleteClass;
        private Button btnUpdateClass;
        private Panel panel4;
        private TextBox textBoxHMstudent1;
        private Label label7;
        private Panel panel5;
        private TextBox textBoxName1;
        private Label label8;
        private Label label9;
        private Button btnAddClass;
    }
}
