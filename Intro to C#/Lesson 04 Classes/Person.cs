using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_04_Classes
{
    internal class Person
    {
        // Classes are the blueprints for objects. They can contain methods and variables.
        // The class is the blueprint that describes the state and behavior that the objects of the class all share.
        // A class can be used to create many objects. Objects created at runtime from a class are called instances of that particular class.
        // This class will be used as a blueprint for a Person Object.

        // Fields are like variables, but they belong to the class in which they are defined, and they can be accessed from any method in that class.
        // Fields that are declared public can be accessed from anywhere.
        // Private fields are accessible only within the class in which they are declared.
        // Alternatively you can not specifiy private/public and the field will default to private.
        // Fields should always be declared at the top, before methods.

        public string name; // public field
        private int age; // private field
        string email; // private field
        protected string address; // protected fields can be accessed by subclasses. They are private by default. We will cover subclasses later.


        // It is common practice to use getters and setters to access and update the values of private fields.
        // Getters and Setters are methods that are used to access and update the values of private fields.
        // Getters are used to access the value of a private field.
        // Setters are used to update the value of a private field.
        // Why bother using them? Why not just make the fields public?
        // Because getters and setters allow you to control how the fields are accessed and updated.
        
        // Traditional getters and setters are defined like this:
        public int getAge()
        {
            // Even though the age field is private, we can access it by using the getAge() method even outside of the class.
            return this.age;
        }

        public void setAge(int age)
        {
            // By using Setters we can control how the age field is updated.
            // For example, we can add a condition that the age must be greater than 0.
            if (age < 0)
            {
                // Exceptions are used to handle errors.
                // They are used to notify the user that something went wrong.
                // Exceptions are thrown when an error occurs.
                // When thrown, an exception will stop the execution of the program unless it is handled.
                // This way a user cannot set the age to a negative number. This is the power of getters and setters.
                throw new Exception("Age must be greater than 0");
            }

            // If no exception is thrown, then we can update the age field.
            this.age = age;
        }

        // Alternatively you can use C# properties to define getters and setters.

        // Properties
        // Properties are essentially fields that have built in getters and setters.
        // Properties are used to access and update the values of private fields.
        // Properties are defined like fields, but they are actually methods that are called when the property is accessed or updated.
        // This is called an auto-implemented property. It is a shortcut for defining a property with a getter and setter.
        public string gender { get; set; } // This property has a public getter and setter, so it can be accessed from anywhere.
        
        public string lastName { get; private set; } // This property has a private setter, so it can only be updated from within the class.

        // Constructors are special methods that are used to create instances of a class.
        // Constructors are used to initialize the fields of an object.
        // Constructors are called when an object is created using the new keyword.
        // Constructors have the same name as the class.
        public Person(string name, int age, string email, string address, string gender, string lastName)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.lastName = lastName;
        }

        // You can have multiple constructors in a class.
        // This is called constructor overloading.
        // Constructor overloading allows you to create objects in different ways.
        // For example, you can create an object with just a name, or with a name and age, or with a name, age and email.
        public Person(string name, int age, string gender, string lastName)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.lastName = lastName;
            this.email = "no email";
            this.address = "no address";

            // In this case the user did not specify an email or address, so we set it to "no email" by default.
        }

        // Methods are functions that are defined inside a class.
        // Methods are used to define the behavior of an object.
        // Methods are defined the same way as functions, except they are defined inside a class.
        // Methods can be public or private, just like fields.
        // Methods should always be declared after fields.

        public string Introduce() // This method is public, so it can be accessed from anywhere.
        {
            return $"Hello my name is {name} {lastName}. I am {age} years old. It's nice to meet you!";
        }
    }

    internal class Main
    {
        public Main()
        {
            // Creating a new Person OBJECT using the Person CLASS
            Person jacob = new Person("Jacob", 28, "Jacob@Email.ca", "123 Georgian Dr.", "Male", "Nordstrom");

            // Accessing the fields of the Person object
            string name = jacob.name ; // We can access the name field because it is public
            int age = jacob.getAge(); // We can access the getAge() method because it is public. We cannot access the age field because it is private.
            // we cannot access the email or address fields because it is private and we did not define a getter for it.
            string gender = jacob.gender; // We can access the gender field because of the getter property we made for it
            string lastName = jacob.lastName; // We can access the lastName field because the getter is public, however we cannot set it due to the private setter.

            // Accessing the methods of the Person object
            Console.WriteLine(jacob.Introduce()); // -> Hello my name is Jacob Nordstrom. I am 28 years old. It's nice to meet you!

            // Changing the fields of the Person object
            jacob.name = "Jac"; // We can change the name field because it is public
            jacob.setAge(29); // Using the setter method to change the age field
            Console.WriteLine(jacob.Introduce()); // -> Hello my name is Jac Nordstrom. I am 29 years old. It's nice to meet you!
        }
    }

}
