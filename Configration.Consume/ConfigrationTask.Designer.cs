namespace Configration.Consume
{
    partial class ConfigrationTask
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ITIBranches = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBranchConfigKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.Students = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStudentConfigKey = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.Instructor = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInstructorConfigKey = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.tbBranchConfigValue = new System.Windows.Forms.TextBox();
            this.tbStudentConfigValue = new System.Windows.Forms.TextBox();
            this.tbInstructorConfigValue = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ITIBranches.SuspendLayout();
            this.Students.SuspendLayout();
            this.Instructor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ITIBranches);
            this.tabControl1.Controls.Add(this.Students);
            this.tabControl1.Controls.Add(this.Instructor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // ITIBranches
            // 
            this.ITIBranches.Controls.Add(this.tbBranchConfigValue);
            this.ITIBranches.Controls.Add(this.label3);
            this.ITIBranches.Controls.Add(this.label2);
            this.ITIBranches.Controls.Add(this.cmbBranchConfigKey);
            this.ITIBranches.Controls.Add(this.label1);
            this.ITIBranches.Controls.Add(this.cmbBranch);
            this.ITIBranches.Location = new System.Drawing.Point(4, 22);
            this.ITIBranches.Name = "ITIBranches";
            this.ITIBranches.Padding = new System.Windows.Forms.Padding(3);
            this.ITIBranches.Size = new System.Drawing.Size(792, 424);
            this.ITIBranches.TabIndex = 0;
            this.ITIBranches.Text = "ITI Branches";
            this.ITIBranches.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Config Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Config Key";
            // 
            // cmbBranchConfigKey
            // 
            this.cmbBranchConfigKey.FormattingEnabled = true;
            this.cmbBranchConfigKey.Location = new System.Drawing.Point(244, 83);
            this.cmbBranchConfigKey.Name = "cmbBranchConfigKey";
            this.cmbBranchConfigKey.Size = new System.Drawing.Size(121, 21);
            this.cmbBranchConfigKey.TabIndex = 2;
            this.cmbBranchConfigKey.SelectedIndexChanged += new System.EventHandler(this.cmbBranchConfigKey_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(244, 41);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 21);
            this.cmbBranch.TabIndex = 0;
            // 
            // Students
            // 
            this.Students.Controls.Add(this.tbStudentConfigValue);
            this.Students.Controls.Add(this.label4);
            this.Students.Controls.Add(this.label5);
            this.Students.Controls.Add(this.cmbStudentConfigKey);
            this.Students.Controls.Add(this.label6);
            this.Students.Controls.Add(this.cmbStudent);
            this.Students.Location = new System.Drawing.Point(4, 22);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(792, 424);
            this.Students.TabIndex = 1;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Config Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Config Key";
            // 
            // cmbStudentConfigKey
            // 
            this.cmbStudentConfigKey.FormattingEnabled = true;
            this.cmbStudentConfigKey.Location = new System.Drawing.Point(240, 95);
            this.cmbStudentConfigKey.Name = "cmbStudentConfigKey";
            this.cmbStudentConfigKey.Size = new System.Drawing.Size(121, 21);
            this.cmbStudentConfigKey.TabIndex = 8;
            this.cmbStudentConfigKey.SelectedIndexChanged += new System.EventHandler(this.cmbStudentConfigKey_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Student";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(240, 53);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(121, 21);
            this.cmbStudent.TabIndex = 6;
            // 
            // Instructor
            // 
            this.Instructor.Controls.Add(this.tbInstructorConfigValue);
            this.Instructor.Controls.Add(this.label7);
            this.Instructor.Controls.Add(this.label8);
            this.Instructor.Controls.Add(this.cmbInstructorConfigKey);
            this.Instructor.Controls.Add(this.label9);
            this.Instructor.Controls.Add(this.cmbInstructor);
            this.Instructor.Location = new System.Drawing.Point(4, 22);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(792, 424);
            this.Instructor.TabIndex = 2;
            this.Instructor.Text = "Instructor";
            this.Instructor.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Config Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Config Key";
            // 
            // cmbInstructorConfigKey
            // 
            this.cmbInstructorConfigKey.FormattingEnabled = true;
            this.cmbInstructorConfigKey.Location = new System.Drawing.Point(247, 99);
            this.cmbInstructorConfigKey.Name = "cmbInstructorConfigKey";
            this.cmbInstructorConfigKey.Size = new System.Drawing.Size(121, 21);
            this.cmbInstructorConfigKey.TabIndex = 8;
            this.cmbInstructorConfigKey.SelectedIndexChanged += new System.EventHandler(this.cmbInstructorConfigKey_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Instructor";
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(247, 57);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(121, 21);
            this.cmbInstructor.TabIndex = 6;
            // 
            // tbBranchConfigValue
            // 
            this.tbBranchConfigValue.Enabled = false;
            this.tbBranchConfigValue.Location = new System.Drawing.Point(244, 127);
            this.tbBranchConfigValue.Name = "tbBranchConfigValue";
            this.tbBranchConfigValue.Size = new System.Drawing.Size(121, 20);
            this.tbBranchConfigValue.TabIndex = 6;
            // 
            // tbStudentConfigValue
            // 
            this.tbStudentConfigValue.Enabled = false;
            this.tbStudentConfigValue.Location = new System.Drawing.Point(240, 139);
            this.tbStudentConfigValue.Name = "tbStudentConfigValue";
            this.tbStudentConfigValue.Size = new System.Drawing.Size(121, 20);
            this.tbStudentConfigValue.TabIndex = 12;
            // 
            // tbInstructorConfigValue
            // 
            this.tbInstructorConfigValue.Enabled = false;
            this.tbInstructorConfigValue.Location = new System.Drawing.Point(247, 143);
            this.tbInstructorConfigValue.Name = "tbInstructorConfigValue";
            this.tbInstructorConfigValue.Size = new System.Drawing.Size(121, 20);
            this.tbInstructorConfigValue.TabIndex = 13;
            // 
            // ConfigrationTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigrationTask";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ITIBranches.ResumeLayout(false);
            this.ITIBranches.PerformLayout();
            this.Students.ResumeLayout(false);
            this.Students.PerformLayout();
            this.Instructor.ResumeLayout(false);
            this.Instructor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ITIBranches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.TabPage Students;
        private System.Windows.Forms.TabPage Instructor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBranchConfigKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStudentConfigKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbInstructorConfigKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.TextBox tbBranchConfigValue;
        private System.Windows.Forms.TextBox tbStudentConfigValue;
        private System.Windows.Forms.TextBox tbInstructorConfigValue;
    }
}

