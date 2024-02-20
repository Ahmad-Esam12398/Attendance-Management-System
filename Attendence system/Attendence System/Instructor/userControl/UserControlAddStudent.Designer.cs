namespace attendence_system.Instructor
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
            labelAddStudent = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBox1 = new TextBox();
            labelEmail = new Label();
            textBox2 = new TextBox();
            labelPhone = new Label();
            textBox3 = new TextBox();
            labelPassword = new Label();
            buttonAddStudent = new Button();
            SuspendLayout();
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.LightGray;
            labelAddStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelAddStudent.Location = new Point(3, 11);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(108, 19);
            labelAddStudent.TabIndex = 1;
            labelAddStudent.Text = "Add Student";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(135, 156);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 27);
            textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelName.Location = new Point(135, 123);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 19);
            labelName.TabIndex = 3;
            labelName.Text = "Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelEmail.Location = new Point(483, 123);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 19);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 8;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelPhone.Location = new Point(135, 209);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(71, 19);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Phone :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(483, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 27);
            textBox3.TabIndex = 10;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelPassword.Location = new Point(483, 209);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 19);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password :";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = Color.FromArgb(67, 3, 125);
            buttonAddStudent.Font = new Font("Century Gothic", 9.75F);
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Location = new Point(194, 313);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(128, 38);
            buttonAddStudent.TabIndex = 11;
            buttonAddStudent.Text = "Add";
            buttonAddStudent.UseVisualStyleBackColor = false;
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddStudent);
            Controls.Add(textBox3);
            Controls.Add(labelPassword);
            Controls.Add(textBox2);
            Controls.Add(labelPhone);
            Controls.Add(textBox1);
            Controls.Add(labelEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelAddStudent);
            Name = "UserControlAddStudent";
            Size = new Size(934, 464);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddStudent;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBox1;
        private Label labelEmail;
        private TextBox textBox2;
        private Label labelPhone;
        private TextBox textBox3;
        private Label labelPassword;
        private Button buttonAddStudent;
    }
}
