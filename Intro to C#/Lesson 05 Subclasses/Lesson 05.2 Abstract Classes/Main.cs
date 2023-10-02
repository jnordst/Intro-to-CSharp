using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_05_Subclasses.Lesson_05._2_Abstract_Classes
{
    internal class Main
    {
        public Main()
        {
            // Creating a new Animal Object is not allowed because Animal is an abstract class
            // Animal animal = new Animal("Animal", 0, "Brown"); // -> Cannot create an instance of the abstract class or interface 'Animal'

            // In order to create an Animal object, we must create a subclass of Animal

            // Creating a new Cat Object
            Cat cat = new Cat("Soot", 3, "Black");

            // Calling the abstract Speak() method
            Console.WriteLine(cat.Speak()); // -> Meow!

            // Calling the virtual Eat() method
            // Because we chose not to override the Eat() method in the Cat class, the Eat() method from the Animal class is used
            Console.WriteLine(cat.Eat("Tuna")); // -> The animal eats the Tuna

            // Creating a new Dog Object
            Dog dog = new Dog("Buddy", 5, "Brown");

            // Calling the abstract Speak() method
            Console.WriteLine(dog.Speak()); // -> Woof!

            // Calling the virtual Eat() method
            // Because we chose to override the Eat() method in the Dog class, the Eat() method from the Dog class is used
            Console.WriteLine(dog.Eat("Kibble")); // -> Buddy wolfs down the Kibble!


        }
    }
}
