using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_00_Getting_Started
{
    internal class Introduction
    {
        // Welcome to programming with C#!
        // Allow me to introduce some of the basic concepts of C#.
        // C# is a programming language that is used to create applications.
        // Applications can be anything from a game to a calculator.
        // C# is a very powerful language that can be used to create many different types of applications.

        // Comments
        // This is a comment. Comments are used to explain what code does.
        // A comment is ignored by the compiler and is not executed.
        // Comments are very useful for explaining what code does.
        // Comments can also be used to disable code.
        // WorldDomination.Excute(); // This line of code is disabled because it is commented out.
        // A comment can be created by typing two forward slashes (//) followed by the comment.
        // Additioanlly a comment can be created by typing...
        /* followed by the comment and then */
        /*
         These kinds of comments
         can span multiple lines
         !!!
        */

        // Program.cs and Namespaces
        // Program.cs is the entry point of the application.
        // The entry point is the first piece of code that is executed when the application is run.
        // None of the code in any of the other files will be executed unless it is called from Program.cs
        // So how do you call code from another file?
        // You can call code from another file by using the using keyword.
        // The using keyword is used to import namespaces.
        // Namespaces are used to organize code.
        // Once you have imported a namespace you can use the code in that namespace.
        // For example, this file is using the System namespace.
        // The System namespace contains many useful classes and methods.

        public Introduction() // This is called a Constructor Method. It's called automatically when a Introduction Object is created.
        {
            // Console Methods
            // The Console class is used to interact with the console.
            // The console is the window that you see when you run the application.
            // The console is used to display text and receive input from the user.
            // The Console class contains many useful methods.

            // WriteLine
            // The WriteLine method is used to write text to the console.
            // The WriteLine method can be used to write text to the console and then move to the next line.
            Console.WriteLine("Hello World!"); // -> Hello World!

            // The WriteLine method can also be used to write text to the console without moving to the next line.
            Console.Write("Hello "); // -> Hello
            Console.Write("World!"); // -> World!

            // ReadLine
            // The ReadLine method is used to read text from the console.
            // The ReadLine method will wait for the user to enter text and then press enter.
            // The ReadLine method will then return the text that the user entered.
            
            // Ask the user for a specific piece of information.
            Console.WriteLine("What is your name?"); // -> What is your name?

            // Assign the response to a variable so we can access it later.
            string name = Console.ReadLine(); // -> User types: Jacob

            // Use the response to do something.
            Console.WriteLine("Hello " + name + "!"); // -> Hello Jacob!
        }
    }
}
