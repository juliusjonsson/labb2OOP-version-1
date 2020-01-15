namespace winformslabb2test
{
    partial class AddKurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKursNamn = new System.Windows.Forms.TextBox();
            this.txtKursId = new System.Windows.Forms.TextBox();
            this.txtKursDeltagare = new System.Windows.Forms.TextBox();
            this.txtLärare = new System.Windows.Forms.TextBox();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.tillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kursnamn : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KursId :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antal Kursdeltagare :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lärare : ";
            // 
            // txtKursNamn
            // 
            this.txtKursNamn.Location = new System.Drawing.Point(189, 66);
            this.txtKursNamn.Name = "txtKursNamn";
            this.txtKursNamn.Size = new System.Drawing.Size(170, 20);
            this.txtKursNamn.TabIndex = 4;
            // 
            // txtKursId
            // 
            this.txtKursId.Location = new System.Drawing.Point(189, 133);
            this.txtKursId.Name = "txtKursId";
            this.txtKursId.Size = new System.Drawing.Size(170, 20);
            this.txtKursId.TabIndex = 5;
            // 
            // txtKursDeltagare
            // 
            this.txtKursDeltagare.Location = new System.Drawing.Point(189, 200);
            this.txtKursDeltagare.Name = "txtKursDeltagare";
            this.txtKursDeltagare.Size = new System.Drawing.Size(170, 20);
            this.txtKursDeltagare.TabIndex = 6;
            // 
            // txtLärare
            // 
            this.txtLärare.Location = new System.Drawing.Point(189, 263);
            this.txtLärare.Name = "txtLärare";
            this.txtLärare.Size = new System.Drawing.Size(170, 20);
            this.txtLärare.TabIndex = 7;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCourse.Location = new System.Drawing.Point(12, 381);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(163, 42);
            this.btnSaveCourse.TabIndex = 8;
            this.btnSaveCourse.Text = "Spara";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(388, 29);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(387, 394);
            this.lstCourse.TabIndex = 9;
            // 
            // tillbaka
            // 
            this.tillbaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tillbaka.Location = new System.Drawing.Point(196, 381);
            this.tillbaka.Name = "tillbaka";
            this.tillbaka.Size = new System.Drawing.Size(163, 42);
            this.tillbaka.TabIndex = 10;
            this.tillbaka.Text = "Tillbaka";
            this.tillbaka.UseVisualStyleBackColor = true;
            this.tillbaka.Click += new System.EventHandler(this.tillbaka_Click);
            // 
            // AddKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tillbaka);
            this.Controls.Add(this.lstCourse);
            this.Controls.Add(this.btnSaveCourse);
            this.Controls.Add(this.txtLärare);
            this.Controls.Add(this.txtKursDeltagare);
            this.Controls.Add(this.txtKursId);
            this.Controls.Add(this.txtKursNamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddKurs";
            this.Text = "AddKurs";
            this.Load += new System.EventHandler(this.AddKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKursNamn;
        private System.Windows.Forms.TextBox txtKursId;
        private System.Windows.Forms.TextBox txtKursDeltagare;
        private System.Windows.Forms.TextBox txtLärare;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.Button tillbaka;
    }
}