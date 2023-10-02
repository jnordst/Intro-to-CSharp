using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_05_Subclasses.Lesson_05._2_Abstract_Classes
{
    internal class Dog : Animal
    {

        public Dog(string name, int age, string color) : base(name, age, color)
        {

        }

        // Because the Speak() method is abstract in the Animal class, we have to provide an implementation
        public override string Speak()
        {
            return "Woof!";
        }

        // Because the Eat() method is virtual in the Animal class, we can optionally override it
        public override string Eat(string food)
        {
            return $"{name} wolfs down the {food}!";
        }
    }
}
