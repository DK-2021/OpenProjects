using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Notes
{
    public class FieldsInDepth
    {
        private int ID; // A private field that is currently accessible via an argument and a public getter and setter below if requirements are met.
        private string Name { get; set; } // A private property not accessible unless you use the public getter and setter or pass as argument.
        private string Title { get; set; } // a private property not accessible other than putting arguments through the contructor on line 20.
        public FieldsInDepth()
        {
            // default constructor
        }
        public FieldsInDepth(string _name, string _title, int _id) // A constructor which allows you to pass arguments directly to an object
        {
            Name = _name; // Access to the Name property
            Title = _title; // Access the Title property
            _ID = _id; // This forces the argument to be filtered through the getter and setter below, '_ID'.  
        }
        public string _Name // the public facing getter and setter for 'Name', if you don't access if via an argument.
        {
            get { return Name; }
            set { Name = value; }
        }
        public int _ID // The public getter and setter for the 'ID' variable.  Ability to provide guidlines to acceptable value within.
        {
            get
            {
                return ID; // Returns the value of the ID
            }
            set
            {
                if (value > 0 && value < 50) // Setting a guidline via getter and setter.
                {
                    ID = value; // ID is now set to value
                }
                else
                    Console.WriteLine("That is an invalid ID number!\nIt will be stored as '0'");
            }
        }
        public void ThePerson(ParentClass obj) // a method that takes a ParentClass object as an argument
        {
            Console.WriteLine($"Employee name: {obj.Name}");
            Console.WriteLine($"Employee title: {obj.Title}");
            Console.WriteLine($"Employee ID: {obj._ID}");
        }
    }
}
