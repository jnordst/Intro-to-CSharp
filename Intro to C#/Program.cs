// See https://aka.ms/new-console-template for more information

using Intro_to_C_.Lesson_04_Classes;

Console.WriteLine("Introduce Yourself!");
Console.WriteLine("What's your name?");
string name = Console.ReadLine();

Console.WriteLine("What's your last name?");
string lastName = Console.ReadLine();

Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine()); // We need to convert the string input to an int

Console.WriteLine("What's your gender?");
string gender = Console.ReadLine();

// Using the users input to create a new Person object
Person person = new Person(name, age, gender, lastName);

// Accessing the methods of the Person object
Console.WriteLine(person.Introduce()); // -> Hello my name is Jacob Nordstrom. I am 29 years old. It's nice to meet you!
