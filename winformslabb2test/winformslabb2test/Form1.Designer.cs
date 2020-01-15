namespace winformslabb2test
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NewPerson = new System.Windows.Forms.Button();
            this.NewCourse = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.ListBox();
            this.teacherList = new System.Windows.Forms.ListBox();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.Students = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentDelete = new System.Windows.Forms.Button();
            this.teacherDelete = new System.Windows.Forms.Button();
            this.courseDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.NewPerson);
            this.panel1.Controls.Add(this.NewCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 582);
            this.panel1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.buttonRefresh.Location = new System.Drawing.Point(0, 254);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(164, 55);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.button3.Location = new System.Drawing.Point(0, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NewPerson
            // 
            this.NewPerson.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.NewPerson.Location = new System.Drawing.Point(0, 132);
            this.NewPerson.Name = "NewPerson";
            this.NewPerson.Size = new System.Drawing.Size(164, 55);
            this.NewPerson.TabIndex = 2;
            this.NewPerson.Text = "New person";
            this.NewPerson.UseVisualStyleBackColor = true;
            this.NewPerson.Click += new System.EventHandler(this.newPerson_Click);
            // 
            // NewCourse
            // 
            this.NewCourse.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCourse.Location = new System.Drawing.Point(0, 71);
            this.NewCourse.Name = "NewCourse";
            this.NewCourse.Size = new System.Drawing.Size(164, 55);
            this.NewCourse.TabIndex = 1;
            this.NewCourse.Text = "New course";
            this.NewCourse.UseVisualStyleBackColor = true;
            this.NewCourse.Click += new System.EventHandler(this.newCourse_Click);
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(181, 38);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(392, 485);
            this.studentList.TabIndex = 8;
            // 
            // teacherList
            // 
            this.teacherList.FormattingEnabled = true;
            this.teacherList.Location = new System.Drawing.Point(579, 38);
            this.teacherList.Name = "teacherList";
            this.teacherList.Size = new System.Drawing.Size(391, 485);
            this.teacherList.TabIndex = 9;
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(976, 38);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(363, 485);
            this.lstCourse.TabIndex = 10;
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.Location = new System.Drawing.Point(330, 15);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(74, 20);
            this.Students.TabIndex = 11;
            this.Students.Text = "Students";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Teachers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1137, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Courses";
            // 
            // studentDelete
            // 
            this.studentDelete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.studentDelete.Location = new System.Drawing.Point(277, 527);
            this.studentDelete.Name = "studentDelete";
            this.studentDelete.Size = new System.Drawing.Size(164, 55);
            this.studentDelete.TabIndex = 5;
            this.studentDelete.Text = "Delete";
            this.studentDelete.UseVisualStyleBackColor = true;
            this.studentDelete.Click += new System.EventHandler(this.studentDelete_Click);
            // 
            // teacherDelete
            // 
            this.teacherDelete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.teacherDelete.Location = new System.Drawing.Point(692, 527);
            this.teacherDelete.Name = "teacherDelete";
            this.teacherDelete.Size = new System.Drawing.Size(164, 55);
            this.teacherDelete.TabIndex = 14;
            this.teacherDelete.Text = "Delete";
            this.teacherDelete.UseVisualStyleBackColor = true;
            this.teacherDelete.Click += new System.EventHandler(this.teacherDelete_Click);
            // 
            // courseDelete
            // 
            this.courseDelete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.courseDelete.Location = new System.Drawing.Point(1080, 527);
            this.courseDelete.Name = "courseDelete";
            this.courseDelete.Size = new System.Drawing.Size(164, 55);
            this.courseDelete.TabIndex = 15;
            this.courseDelete.Text = "Delete";
            this.courseDelete.UseVisualStyleBackColor = true;
            this.courseDelete.Click += new System.EventHandler(this.courseDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 582);
            this.Controls.Add(this.courseDelete);
            this.Controls.Add(this.teacherDelete);
            this.Controls.Add(this.studentDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.lstCourse);
            this.Controls.Add(this.teacherList);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NewPerson;
        private System.Windows.Forms.Button NewCourse;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.ListBox teacherList;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button studentDelete;
        private System.Windows.Forms.Button teacherDelete;
        private System.Windows.Forms.Button courseDelete;
    }
}

