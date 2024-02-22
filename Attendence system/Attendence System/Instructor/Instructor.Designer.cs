namespace attendence_system.Instructor
{
    partial class instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructor));
            panel1 = new Panel();
            panelSettings = new Panel();
            buttonSettings = new Button();
            pictureBox2 = new PictureBox();
            panelSide = new Panel();
            panelAttendance = new Panel();
            buttonAttendance = new Button();
            pictureBox6 = new PictureBox();
            panelDashBoard = new Panel();
            buttonDashboard = new Button();
            pictureBox5 = new PictureBox();
            panelAddStudent = new Panel();
            buttonAddStudent = new Button();
            pictureBox8 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panelExpand = new Panel();
            panel10 = new Panel();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            pictureBoxExpand = new PictureBox();
            pictureBox3 = new PictureBox();
            labelDateTime = new Label();
            panel4 = new Panel();
            labelRole = new Label();
            labelName = new Label();
            label5 = new Label();
            label4 = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            setAttendance = new userControl.setAttendance();
            userControlDashboard = new Admin.userControl.UserControlDashboard();
            panel1.SuspendLayout();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panelExpand.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panelSettings);
            panel1.Controls.Add(panelSide);
            panel1.Controls.Add(panelAttendance);
            panel1.Controls.Add(panelDashBoard);
            panel1.Controls.Add(panelAddStudent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 720);
            panel1.TabIndex = 0;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(buttonSettings);
            panelSettings.Controls.Add(pictureBox2);
            panelSettings.Location = new Point(22, 559);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(299, 75);
            panelSettings.TabIndex = 8;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.Transparent;
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(73, 12);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(162, 50);
            buttonSettings.TabIndex = 1;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            buttonSettings.MouseLeave += button1_MouseLeave;
            buttonSettings.MouseHover += buttonDashboard_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(67, 23, 125);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 273);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(9, 49);
            panelSide.TabIndex = 9;
            // 
            // panelAttendance
            // 
            panelAttendance.Controls.Add(buttonAttendance);
            panelAttendance.Controls.Add(pictureBox6);
            panelAttendance.Location = new Point(22, 355);
            panelAttendance.Name = "panelAttendance";
            panelAttendance.Size = new Size(299, 75);
            panelAttendance.TabIndex = 6;
            // 
            // buttonAttendance
            // 
            buttonAttendance.BackColor = Color.Transparent;
            buttonAttendance.Cursor = Cursors.Hand;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Location = new Point(73, 12);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(162, 50);
            buttonAttendance.TabIndex = 1;
            buttonAttendance.Text = "Attendance";
            buttonAttendance.UseVisualStyleBackColor = false;
            buttonAttendance.Click += buttonAttendance_Click;
            buttonAttendance.MouseLeave += button1_MouseLeave;
            buttonAttendance.MouseHover += buttonDashboard_MouseHover;
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
            // panelDashBoard
            // 
            panelDashBoard.Controls.Add(buttonDashboard);
            panelDashBoard.Controls.Add(pictureBox5);
            panelDashBoard.Location = new Point(22, 265);
            panelDashBoard.Name = "panelDashBoard";
            panelDashBoard.Size = new Size(299, 66);
            panelDashBoard.TabIndex = 5;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(73, 8);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(162, 50);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            buttonDashboard.MouseLeave += button1_MouseLeave;
            buttonDashboard.MouseHover += buttonDashboard_MouseHover;
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
            // panelAddStudent
            // 
            panelAddStudent.Controls.Add(buttonAddStudent);
            panelAddStudent.Controls.Add(pictureBox8);
            panelAddStudent.Location = new Point(22, 454);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(299, 75);
            panelAddStudent.TabIndex = 7;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = Color.Transparent;
            buttonAddStudent.Cursor = Cursors.Hand;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Location = new Point(73, 12);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(162, 50);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            buttonAddStudent.MouseLeave += button1_MouseLeave;
            buttonAddStudent.MouseHover += buttonDashboard_MouseHover;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 160);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(220, 19);
            label1.TabIndex = 1;
            label1.Text = "Attendance Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 220);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ic;
            pictureBox1.Location = new Point(61, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelExpand);
            panel3.Controls.Add(pictureBoxExpand);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(labelDateTime);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(333, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1175, 179);
            panel3.TabIndex = 1;
            // 
            // panelExpand
            // 
            panelExpand.BackColor = Color.FromArgb(67, 3, 105);
            panelExpand.Controls.Add(panel10);
            panelExpand.Location = new Point(985, 68);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(150, 111);
            panelExpand.TabIndex = 3;
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
            buttonLogOut.Click += buttonLogOut_Click;
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
            // pictureBoxExpand
            // 
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(1039, 43);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(43, 26);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 12;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(940, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            labelDateTime.ForeColor = Color.FromArgb(67, 3, 125);
            labelDateTime.Location = new Point(6, 34);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(31, 19);
            labelDateTime.TabIndex = 3;
            labelDateTime.Text = "{?}";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Controls.Add(labelRole);
            panel4.Controls.Add(labelName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(1175, 104);
            panel4.TabIndex = 2;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(120, 68);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(31, 19);
            labelRole.TabIndex = 7;
            labelRole.Text = "{?}";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(120, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 19);
            labelName.TabIndex = 6;
            labelName.Text = "{?}";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 5;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 20);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 4;
            label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // setAttendance
            // 
            setAttendance.BackColor = Color.White;
            setAttendance.Location = new Point(382, 454);
            setAttendance.Name = "setAttendance";
            setAttendance.Size = new Size(362, 209);
            setAttendance.TabIndex = 2;
            setAttendance.Load += setAttendance_Load;
            // 
            // userControlDashboard
            // 
            userControlDashboard.BackColor = Color.White;
            userControlDashboard.Font = new Font("Century Gothic", 9.75F);
            userControlDashboard.Location = new Point(382, 265);
            userControlDashboard.Margin = new Padding(4, 4, 4, 4);
            userControlDashboard.Name = "userControlDashboard";
            userControlDashboard.Size = new Size(362, 167);
            userControlDashboard.TabIndex = 3;
            // 
            // instructor
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 720);
            Controls.Add(userControlDashboard);
            Controls.Add(setAttendance);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "instructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor";
            WindowState = FormWindowState.Maximized;
            Load += Instructor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelAddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelExpand.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label labelDateTime;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label labelRole;
        private Label labelName;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxExpand;
        private Panel panelAttendance;
        private Button buttonAttendance;
        private PictureBox pictureBox6;
        private Panel panelDashBoard;
        private Button buttonDashboard;
        private PictureBox pictureBox5;
        private Panel panelAddStudent;
        private Button buttonAddStudent;
        private PictureBox pictureBox8;
        private Panel panelSide;
        private Panel panelExpand;
        private Panel panel10;
        private Button buttonLogOut;
        private Button buttonMinimize;
        private System.Windows.Forms.Timer timerDateAndTime;
        private Panel panelSettings;
        private Button buttonSettings;
        private PictureBox pictureBox2;
        private userControl.setAttendance setAttendance;
        private Admin.userControl.UserControlDashboard userControlDashboard;
    }
}