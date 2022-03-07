using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Notes
{
    public interface IInterfaceAbstractClasses
    {
        // All data in the class must be overriden by derived classes.
        // Cannot have implementations for its members(methods), unlike an abstract class.
        // Cannot have fields, unlike abstract class
        // Can only inherit from another Interface, abstract classes can inherit from from both.
        // A class can inherit multiple interfaces at the same time; but cannot inherit from multiple classes.
            
        private void Paint() // Default modifier is public.  Changing it to private will require a body for the method.
        {
            
        }

        public string Write(); // Does not have to be void or explicitly state a modifier.
        public string Word { get; set; } // Allowed to have properties but can not contain fields.
    }
    public abstract class MyAbstractClass
    {
        // Cannot instantiate an abstract class.
        // Used to make other developers follow our code: they will have to account for, and override all of the base abstract methods.
        // Abstract classes contain methods and properties, no extra code.
        // An abstract can contain methods and fields.  All methods must be overriden in derived classes.

        public string name; // Can contain fields.
        public abstract void Draw(); // An abstract method.  Cannot contain any body or be static/private.  Will have to be overriden by the derived.

        public void Name() // Not all classes in an abstract class have to be abstract overriden.  This will be inherited like other methods
        {
            Console.WriteLine("Say name");
        }
    }
    public class DerivedAbstractClass : MyAbstractClass 
    {
        // All derived classes must override all abstract methods from the base class.
        public override void Draw()
        {
            Console.WriteLine("I have overriden the abstract class' Draw method");
        }
    }
}
