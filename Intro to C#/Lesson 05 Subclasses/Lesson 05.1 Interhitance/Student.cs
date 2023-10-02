using Intro_to_C_.Lesson_05_Subclasses.Lesson_05._1_Interhitance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_05_Subclasses
{
    internal class Student : Person // the : symbol is used to indicate that the Student class inherits from the Person class
    {
        // A subclass is a class that inherits from another class.
        // A class can only inherit from one parent class.
        // A subclass is also called a child class.
        // A subclass inherits all the fields and methods of its parent class.
        // A subclass can also have its own fields and methods.
        // In this case Student is a subclass of Person and inherits all of its fields and methods.

       // Fields
        public string program { get; private set; }
        public string studentNumber { get; private set; }
        public int grade { get; private set; }

        // Constructor
        public Student(string firstName, int age, string email, string address, string gender, string lastName, string program, string studentNumber, int grade) 
            : base(firstName, age, email, address, gender, lastName) // the base keyword is used to call the constructor of the parent class
        {
            // Setting the fields of the Student class
            this.program = program;
            this.studentNumber = studentNumber;
            this.grade = grade;
        }

        // Methods
        public string Grade()
        {
            return $"{firstName} {lastName} has a grade of {grade}.";
        }
    }
}
