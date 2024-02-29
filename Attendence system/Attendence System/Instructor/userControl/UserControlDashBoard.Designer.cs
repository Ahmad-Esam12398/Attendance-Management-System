namespace attendence_system.Instructor
{
    partial class UserControlDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashBoard));
            panel3 = new Panel();
            labelRole = new Label();
            labelTotalRole = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            labelTotalClasses = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(labelRole);
            panel3.Controls.Add(labelTotalRole);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(469, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 128);
            panel3.TabIndex = 7;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.None;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(182, 95);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(31, 19);
            labelRole.TabIndex = 2;
            labelRole.Text = "{?}";
            // 
            // labelTotalRole
            // 
            labelTotalRole.Anchor = AnchorStyles.None;
            labelTotalRole.AutoSize = true;
            labelTotalRole.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelTotalRole.ForeColor = Color.White;
            labelTotalRole.Location = new Point(174, 66);
            labelTotalRole.Name = "labelTotalRole";
            labelTotalRole.Size = new Size(50, 23);
            labelTotalRole.TabIndex = 1;
            labelTotalRole.Text = "Role";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelTotalClasses);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(153, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 128);
            panel1.TabIndex = 5;
            // 
            // labelTotalClasses
            // 
            labelTotalClasses.Anchor = AnchorStyles.None;
            labelTotalClasses.AutoSize = true;
            labelTotalClasses.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelTotalClasses.ForeColor = Color.White;
            labelTotalClasses.Location = new Point(180, 94);
            labelTotalClasses.Name = "labelTotalClasses";
            labelTotalClasses.Size = new Size(31, 19);
            labelTotalClasses.TabIndex = 2;
            labelTotalClasses.Text = "{?}";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 68);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 1;
            label1.Text = "classes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserControlDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UserControlDashBoard";
            Size = new Size(942, 501);
            Load += UserControlDashBoard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        public Label labelRole;
        private Label labelTotalRole;
        private PictureBox pictureBox3;
        private Panel panel1;
        public Label labelTotalClasses;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
