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
    public partial class AddPerson : Form
    {
        List<Student> students;
        public AddPerson(List<Student> oldStudents)
        {
            InitializeComponent();
            this.students = oldStudents;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student() { firstName = firstName.Text, lastName = lastName.Text, email = email.Text, adress = adress.Text, gender = genderBox.SelectedItem?.ToString(), isTeacher = checkBox1.Checked };
            this.students.Add(newStudent);
            Close();
        }
    }
}
