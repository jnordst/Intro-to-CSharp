using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_05_Subclasses.Lesson_05._1_Interhitance
{
    internal class Person
    {
        public string firstName { get; protected set;} // protected means that this field can only be set from this class and its subclasses
        public string lastName { get; protected set; }
        public string email { get; protected set; }
        public string address { get; protected set; }
        public string gender { get; protected set; }
        public int age { get; protected set; }

        public Person(string firstName, int age, string email, string address, string gender, string lastName)
        {
            this.firstName = firstName;
            this.age = age;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.lastName = lastName;
        }

        public string Introduce() // This method is public, so it can be accessed from anywhere.
        {
            return $"Hello my name is {firstName} {lastName}. I am {age} years old. It's nice to meet you!";
        }
    }
}
