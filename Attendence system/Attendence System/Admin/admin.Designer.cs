namespace AttendanceManagmentProject.Admin
{
    partial class admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            panel1 = new Panel();
            panel4 = new Panel();
            panelAddTeacher = new Panel();
            butnAddTeacher = new Button();
            pictureBox9 = new PictureBox();
            panelAddClass = new Panel();
            butnAddClass = new Button();
            pictureBox8 = new PictureBox();
            panelAddstudent = new Panel();
            buttonAddStudent = new Button();
            pictureBox7 = new PictureBox();
            panelAttendance = new Panel();
            buttonAttendance = new Button();
            pictureBox6 = new PictureBox();
            PanelDashboard = new Panel();
            buttonDashboard = new Button();
            pictureBox5 = new PictureBox();
            panelSide = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            labelTime = new Label();
            panelBack = new Panel();
            panelExpand = new Panel();
            panel10 = new Panel();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            pictureBox3 = new PictureBox();
            panelTop = new Panel();
            labelRole = new Label();
            labelR = new Label();
            LabelUserName = new Label();
            labelUN = new Label();
            pictureBox2 = new PictureBox();
            pictureBoxExpand = new PictureBox();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            userControlDashboard1 = new attendence_system.Admin.userControl.UserControlDashboard();
            userControlAddClass1 = new attendence_system.Admin.userControl.UserControlAddClass();
            userControlAddStudent1 = new attendence_system.Admin.userControl.UserControlAddStudent();
            userControlAddTeacher1 = new attendence_system.Admin.userControl.UserControlAddTeacher();
            userControlAttendanceV2 = new attendence_system.Admin.userControl.UserControlAttendanceV2();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panelAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panelAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panelAddstudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            PanelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 562);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Controls.Add(panelAddTeacher);
            panel4.Controls.Add(panelAddClass);
            panel4.Controls.Add(panelAddstudent);
            panel4.Controls.Add(panelAttendance);
            panel4.Controls.Add(PanelDashboard);
            panel4.Controls.Add(panelSide);
            panel4.Cursor = Cursors.Hand;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 385);
            panel4.TabIndex = 0;
            // 
            // panelAddTeacher
            // 
            panelAddTeacher.Controls.Add(butnAddTeacher);
            panelAddTeacher.Controls.Add(pictureBox9);
            panelAddTeacher.Location = new Point(29, 289);
            panelAddTeacher.Name = "panelAddTeacher";
            panelAddTeacher.Size = new Size(200, 75);
            panelAddTeacher.TabIndex = 4;
            // 
            // butnAddTeacher
            // 
            butnAddTeacher.BackColor = Color.Transparent;
            butnAddTeacher.FlatAppearance.BorderSize = 0;
            butnAddTeacher.FlatStyle = FlatStyle.Flat;
            butnAddTeacher.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            butnAddTeacher.ForeColor = Color.White;
            butnAddTeacher.Location = new Point(73, 12);
            butnAddTeacher.Name = "butnAddTeacher";
            butnAddTeacher.Size = new Size(124, 50);
            butnAddTeacher.TabIndex = 1;
            butnAddTeacher.Text = "Add Teacher";
            butnAddTeacher.UseVisualStyleBackColor = false;
            butnAddTeacher.Click += butnAddTeacher_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(0, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(67, 49);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // panelAddClass
            // 
            panelAddClass.Controls.Add(butnAddClass);
            panelAddClass.Controls.Add(pictureBox8);
            panelAddClass.Location = new Point(29, 195);
            panelAddClass.Name = "panelAddClass";
            panelAddClass.Size = new Size(200, 75);
            panelAddClass.TabIndex = 3;
            // 
            // butnAddClass
            // 
            butnAddClass.BackColor = Color.Transparent;
            butnAddClass.FlatAppearance.BorderSize = 0;
            butnAddClass.FlatStyle = FlatStyle.Flat;
            butnAddClass.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            butnAddClass.ForeColor = Color.White;
            butnAddClass.Location = new Point(73, 12);
            butnAddClass.Name = "butnAddClass";
            butnAddClass.Size = new Size(113, 50);
            butnAddClass.TabIndex = 1;
            butnAddClass.Text = "Add Class";
            butnAddClass.UseVisualStyleBackColor = false;
            butnAddClass.Click += buttonAddClass_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(67, 23, 125);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(9, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(61, 53);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // panelAddstudent
            // 
            panelAddstudent.Controls.Add(buttonAddStudent);
            panelAddstudent.Controls.Add(pictureBox7);
            panelAddstudent.Location = new Point(29, 382);
            panelAddstudent.Name = "panelAddstudent";
            panelAddstudent.Size = new Size(200, 75);
            panelAddstudent.TabIndex = 2;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = Color.Transparent;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Location = new Point(73, 12);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(124, 50);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // panelAttendance
            // 
            panelAttendance.Controls.Add(buttonAttendance);
            panelAttendance.Controls.Add(pictureBox6);
            panelAttendance.Location = new Point(29, 96);
            panelAttendance.Name = "panelAttendance";
            panelAttendance.Size = new Size(200, 75);
            panelAttendance.TabIndex = 2;
            // 
            // buttonAttendance
            // 
            buttonAttendance.BackColor = Color.Transparent;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Location = new Point(73, 12);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(113, 50);
            buttonAttendance.TabIndex = 1;
            buttonAttendance.Text = "Attendance";
            buttonAttendance.UseVisualStyleBackColor = false;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // PanelDashboard
            // 
            PanelDashboard.Controls.Add(buttonDashboard);
            PanelDashboard.Controls.Add(pictureBox5);
            PanelDashboard.Location = new Point(29, 6);
            PanelDashboard.Name = "PanelDashboard";
            PanelDashboard.Size = new Size(200, 66);
            PanelDashboard.TabIndex = 1;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(73, 12);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(113, 50);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(10, 66);
            panelSide.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(67, 3, 125);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 177);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 136);
            label4.Name = "label4";
            label4.Size = new Size(239, 23);
            label4.TabIndex = 3;
            label4.Text = "Attendance Managment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 154);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelTime.ForeColor = Color.FromArgb(67, 3, 125);
            labelTime.Location = new Point(17, 29);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(33, 23);
            labelTime.TabIndex = 1;
            labelTime.Text = "{?}";
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBox3);
            panelBack.Controls.Add(panelTop);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(287, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1046, 173);
            panelBack.TabIndex = 1;
            panelBack.Paint += panelBack_Paint;
            // 
            // panelExpand
            // 
            panelExpand.BackColor = Color.FromArgb(67, 3, 105);
            panelExpand.Controls.Add(panel10);
            panelExpand.Location = new Point(796, 58);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(150, 115);
            panelExpand.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(buttonLogOut);
            panel10.Controls.Add(buttonMinimize);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(150, 116);
            panel10.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.ForeColor = Color.FromArgb(67, 23, 105);
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(0, 68);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(147, 46);
            buttonLogOut.TabIndex = 1;
            buttonLogOut.Text = "   Log Out ";
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click_1;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = Color.FromArgb(67, 23, 105);
            buttonMinimize.Image = (Image)resources.GetObject("buttonMinimize.Image");
            buttonMinimize.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMinimize.Location = new Point(0, 13);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(147, 53);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.Text = "   Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(783, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(67, 3, 125);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(labelR);
            panelTop.Controls.Add(LabelUserName);
            panelTop.Controls.Add(labelUN);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 68);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1046, 105);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(131, 77);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(33, 23);
            labelRole.TabIndex = 5;
            labelRole.Text = "{?}";
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelR.ForeColor = Color.White;
            labelR.Location = new Point(17, 77);
            labelR.Name = "labelR";
            labelR.Size = new Size(55, 23);
            labelR.TabIndex = 4;
            labelR.Text = "Role:";
            // 
            // LabelUserName
            // 
            LabelUserName.AutoSize = true;
            LabelUserName.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            LabelUserName.ForeColor = Color.White;
            LabelUserName.Location = new Point(131, 35);
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(33, 23);
            LabelUserName.TabIndex = 3;
            LabelUserName.Text = "{?}";
            // 
            // labelUN
            // 
            labelUN.AutoSize = true;
            labelUN.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelUN.ForeColor = Color.White;
            labelUN.Location = new Point(17, 35);
            labelUN.Name = "labelUN";
            labelUN.Size = new Size(103, 23);
            labelUN.TabIndex = 2;
            labelUN.Text = "Welcome:";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 52);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(889, 36);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(43, 26);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 9;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick_1;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.BackColor = Color.White;
            userControlDashboard1.Dock = DockStyle.Fill;
            userControlDashboard1.Font = new Font("Century Gothic", 9.75F);
            userControlDashboard1.Location = new Point(287, 173);
            userControlDashboard1.Margin = new Padding(4, 4, 4, 4);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(1046, 389);
            userControlDashboard1.TabIndex = 0;
            // 
            // userControlAddClass1
            // 
            userControlAddClass1.BackColor = Color.White;
            userControlAddClass1.Dock = DockStyle.Fill;
            userControlAddClass1.Font = new Font("Century Gothic", 9.75F);
            userControlAddClass1.Location = new Point(287, 173);
            userControlAddClass1.Margin = new Padding(4, 4, 4, 4);
            userControlAddClass1.Name = "userControlAddClass1";
            userControlAddClass1.Size = new Size(1046, 389);
            userControlAddClass1.TabIndex = 0;
            userControlAddClass1.Visible = false;
            // 
            // userControlAddStudent1
            // 
            userControlAddStudent1.BackColor = Color.White;
            userControlAddStudent1.Dock = DockStyle.Fill;
            userControlAddStudent1.Font = new Font("Century Gothic", 9.75F);
            userControlAddStudent1.Location = new Point(287, 173);
            userControlAddStudent1.Margin = new Padding(4, 4, 4, 4);
            userControlAddStudent1.Name = "userControlAddStudent1";
            userControlAddStudent1.Size = new Size(1046, 389);
            userControlAddStudent1.TabIndex = 0;
            userControlAddStudent1.Visible = false;
            // 
            // userControlAddTeacher1
            // 
            userControlAddTeacher1.BackColor = Color.White;
            userControlAddTeacher1.Dock = DockStyle.Fill;
            userControlAddTeacher1.Location = new Point(287, 173);
            userControlAddTeacher1.Margin = new Padding(4);
            userControlAddTeacher1.Name = "userControlAddTeacher1";
            userControlAddTeacher1.Size = new Size(1046, 389);
            userControlAddTeacher1.TabIndex = 0;
            userControlAddTeacher1.Visible = false;
            // 
            // userControlAttendanceV2
            // 
            userControlAttendanceV2.BackColor = Color.White;
            userControlAttendanceV2.Location = new Point(287, 172);
            userControlAttendanceV2.Margin = new Padding(4);
            userControlAttendanceV2.Name = "userControlAttendanceV2";
            userControlAttendanceV2.Size = new Size(1350, 620);
            userControlAttendanceV2.TabIndex = 5;
            userControlAttendanceV2.Visible = false;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1333, 562);
            Controls.Add(userControlAttendanceV2);
            Controls.Add(userControlAddTeacher1);
            Controls.Add(userControlAddStudent1);
            Controls.Add(userControlAddClass1);
            Controls.Add(userControlDashboard1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(0, 5);
            Margin = new Padding(4, 5, 4, 5);
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Managment System";
            WindowState = FormWindowState.Maximized;
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panelAddTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panelAddClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panelAddstudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panelAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            PanelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelUN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelAddTeacher;
        private System.Windows.Forms.Button butnAddTeacher;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panelAddClass;
        private System.Windows.Forms.Button butnAddClass;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panelAddstudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Panel panelExpand;
        private Panel panel10;
        private Button buttonMinimize;
        private Button buttonLogOut;
        private System.Windows.Forms.Timer timerDateAndTime;
        private attendence_system.Admin.userControl.UserControlDashboard userControlDashboard1;
        private attendence_system.Admin.userControl.UserControlAddClass userControlAddClass1;
        private attendence_system.Admin.userControl.UserControlAddStudent userControlAddStudent1;
        private attendence_system.Admin.userControl.UserControlAddTeacher userControlAddTeacher1;
        private attendence_system.Admin.userControl.UserControlAttendance userControlAttendance1;
        private attendence_system.Admin.userControl.UserControlAttendanceV2 userControlAttendanceV2;
        //  private System.Windows.Forms.Timer timerDateAndTime;
    }
}