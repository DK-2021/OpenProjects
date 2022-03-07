using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Notes
{
    public class Student
    {
        private float GPA { get; set; } // Has to be accessed through the public facing property below
        public int StudentID { get; set; } // Accessible without a public facing property. 

        private string Name; // This is a private field, the only way to access it is with making a public propety below. 

        public string Address; // This is a public field and is accessible without any protection.  Can also be accessed via the constructor below as an argument.
        public Student()
        {
            // Constructor does nothing but intialize
        }
        public Student(int _studentId, string _address) 
        {
            StudentID = _studentId;
            Address = _address;
        }
        public string _Name // Used to access the private Name field above. 
        {
            get { return Name; }
            set { Name = value; }
        }
        public float _GPA // Used to access the private Name field above.  Only to access the field. 
        {
            get { return GPA; }
            set { GPA = value; }
        }
    }
}
