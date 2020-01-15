using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformslabb2test
{
    

    interface IPerson
    {
        int id { get; set; }
        string gender { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
    }

    public class Student : IPerson
    {
        public string gender { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public int id { get; set; }
        public bool isTeacher = false;



        public Student()
        {
        }
    }

    public class Administrator
    {

    }

    public class Teacher : IPerson
    {
        public Teacher()
        {
        }
        public string gender { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public int id { get; set; }
    }
   
    

}
