using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_05_Subclasses.Lesson_05._2_Abstract_Classes
{
    internal abstract class Animal // define an abstract class by using the abstract keyword in the class definition
    {
        // Abstract classes are classes that CANNOT be instantiated.
        // Abstract classes are used to provide a common definition of a base class that can be shared by multiple subclasses.

        // Fields
        public string name { get; protected set; }
        public int age { get; protected set; }
        public string color { get; protected set; }

        // Constructor
        public Animal(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        // Methods

        // Abstract methods are methods are declared without an implementation.
        // The code body of an abstract method is provided by the subclass that inherits from the abstract class.
        // Classes that inherit from an abstract class MUST provide an implementation for all inherited abstract methods.
        public abstract string Speak();

        // Virtual methods are methods that can be overridden by subclasses.
        // These methods contain a code body but can OPTIONALLY be overridden by subclasses.
        // If a subclass does not override a virtual method, then the code body of the virtual method will be used.
        public virtual string Eat(string food)
        {
            return $"The animal eats the {food}";
        }
    }
}
