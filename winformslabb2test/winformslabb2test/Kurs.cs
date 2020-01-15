using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformslabb2test
{
    class Kurs
    {
        public List<Teacher> teachers;
        public List<Student> students;
        //public List<Kurs> kurs;
        
        private string kursNamn;
        private int kursId;
        private int kursDeltagare;
        private string lärare;

        public string KursNamn
        {
            get{ return kursNamn; }
            set { kursNamn = value; }
        }

        public int KursId
        {
            get { return kursId; }
            set { kursId = value; }
        }

        public int KursDeltagare
        {
            get { return kursDeltagare; }
            set { kursDeltagare = value; }
        }

        public string Lärare
        {
            get { return lärare; }
            set { lärare = value; }
        }

        public Kurs()
        {
            kursNamn = "Objektorienterad Systemutveckling";
            kursId = 1;
            kursDeltagare = 50;
            lärare = "Stefan Andersson";
        }

        public Kurs(string kursNamn, int kursDeltagare, string lärare)
        {
            KursNamn = kursNamn;
            KursDeltagare = kursDeltagare;
            Lärare = lärare;
     
        }

        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1}, {2}, {3}", KursId, KursNamn, KursDeltagare, Lärare);
            return output;
        }


    } //end of class

} //end of namespace
