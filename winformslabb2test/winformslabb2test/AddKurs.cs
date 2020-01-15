using System;
using System.IO;
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
    public partial class AddKurs : Form
    {

        public AddKurs()
        {
            InitializeComponent();
        }

        //private void Write(Kurs obj)
        //{
        //    StreamWriter sw = new StreamWriter("Courses.txt");
        //    sw.WriteLine(kurser.Length + 1);
        //    sw.WriteLine(obj.KursNamn);
        //    sw.WriteLine(obj.KursId);
        //    sw.WriteLine(obj.KursDeltagare);
        //    sw.WriteLine(obj.Lärare);

        //    for(int x = 0; x < kurser.Length; x++)
        //    {
        //        sw.WriteLine(kurser[x].KursNamn);
        //        sw.WriteLine(kurser[x].KursId);
        //        sw.WriteLine(kurser[x].KursDeltagare);
        //        sw.WriteLine(kurser[x].Lärare);
        //    }
        //    sw.Close();
        //}

        //private void Read()
        //{
        //    StreamReader sr = new StreamReader("Courses.txt");
        //    kurser = new Kurs[Convert.ToInt32(sr.ReadLine())];

        //    for(int x = 0; x < kurser.Length; x++)
        //    {
        //        kurser[x] = new Kurs();
        //        kurser[x].KursNamn = sr.ReadLine();
        //        kurser[x].KursId = Convert.ToInt32(sr.ReadLine());
        //        kurser[x].KursDeltagare = Convert.ToInt32(sr.ReadLine());
        //        kurser[x].Lärare = sr.ReadLine();
        //    }
        //    sr.Close();
        //}

        //private void Display()
        //{
        //    lstCourse.Items.Clear();

        //    for(int x = 0; x < kurser.Length; x++)
        //    {
        //        lstCourse.Items.Add(kurser[x].ToString());
        //    }
        //}

        private void ClearForm()
        {
            txtKursNamn.Text = String.Empty;
            txtKursId.Text = String.Empty;
            txtKursDeltagare.Text = String.Empty;
            txtLärare.Text = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            // Skapar ett objekt av kurs
            Kurs obj = new Kurs();
            // Tilldelar kurs värden
            obj.KursNamn = txtKursNamn.Text;
            obj.KursId = Convert.ToInt32(txtKursId.Text);
            obj.KursDeltagare = Convert.ToInt32(txtKursDeltagare.Text);
            obj.Lärare = txtLärare.Text;
            // Lägger till kurs i listan
            Program.kurs.Add(obj);
            //Presenterar innehållet i listbox
            lstCourse.Items.Add(obj);

            // Längden av listan
            int i = Program.kurs.Count();
            //Write(obj);
            //Read();
            //Display();
            //ClearForm();
        }

        private void AddKurs_Load(object sender, EventArgs e)
        {
        //    Read();
        //    Display();
        }

        private void tillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
