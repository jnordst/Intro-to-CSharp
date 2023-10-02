using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_05_Subclasses.Lesson_05._1_Interhitance
{
    internal class Main
    {
        public Main()
        {
            // Creating a Person Object
            Person person = new Person("Jacob", 29, "jacob@email.com", "123 Georgian Dr.", "Male", "Nordstrom");

            // Creating a Student Object
            Student student = new Student("Jacob", 29, "jacob@email.com", "123 Georgian Dr.",
                "Male", "Nordstrom", "Computer Programming", "200368110", 96);

            // Student has all the methods available to Person
            Console.WriteLine(person.Introduce()); // -> Hello my name is Jacob Nordstrom. I am 29 years old. It's nice to meet you!
            Console.WriteLine(student.Introduce()); // -> Hello my name is Jacob Nordstrom. I am 29 years old. It's nice to meet you!

            // Student also has its own methods that are not available to Person
            Console.WriteLine(student.Grade()); // -> Jacob Nordstrom has a grade of 96.
            // Console.WriteLine(person.Grade()); // -> This will cause an error because the Grade() method is not available to Person

            // Student also has its own fields that are not available to Person
            Console.WriteLine(student.program); // -> Computer Programming
            // Console.WriteLine(person.program); // -> This will cause an error because the program field is not available to Person
        }
    }
}
