using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformslabb2test
{
    public partial class Form1 : Form
    {
        public List<Student> AllPersons { get; set; }
        //public List<Kurs> AllCourses { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.AllPersons = new List<Student>();
        }

        public void DisplayStudents()
        {
            studentList.Items.Clear();
            foreach (Student student in AllPersons)
            {
                if (student.isTeacher)
                    continue;
                string fullName = student.id + " " + student.firstName + " " + student.lastName + " " + student.email + " " + student.adress + " " + student.gender;
                this.studentList.Items.Add(fullName);
            }
            
        }

        public void DisplayTeachers()
        {
            teacherList.Items.Clear();
            foreach (Student student in AllPersons)
            {
                if (!student.isTeacher)
                    continue;
                string fullName = student.id + " " + student.firstName + " " + student.lastName + " " + student.email + " " + student.adress + " " + student.gender;
                this.teacherList.Items.Add(fullName);
            }

        }



        private void newCourse_Click(object sender, EventArgs e)
        {
            var frm = new AddKurs();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void newPerson_Click(object sender, EventArgs e)
        {
            AddPerson frm = new AddPerson(AllPersons);
            frm.FormClosing += delegate { this.Show(); };
            frm.FormClosing += delegate { this.DisplayStudents(); };
            frm.FormClosing += delegate { this.DisplayTeachers(); };
            frm.Show();
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            

            foreach (Kurs k in Program.kurs)
            {
                lstCourse.Items.Add(k);
            }




        }

        private void studentDelete_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(studentList);
            selectedItems = studentList.SelectedItems;

            if (studentList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    studentList.Items.Remove(selectedItems[i]);
            }
        }

        private void teacherDelete_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(teacherList);
            selectedItems = teacherList.SelectedItems;

            if (teacherList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    teacherList.Items.Remove(selectedItems[i]);
            }
        }

        private void courseDelete_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstCourse);
            selectedItems = lstCourse.SelectedItems;

            if (lstCourse.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lstCourse.Items.Remove(selectedItems[i]);
            }
        }
    }
}
