using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_02_Functions
{
    internal class ReturnType
    {
        // Functions can return a value by specifying a return type.
        // The return type is specified before the name of the function.
        // The return type can be any data type, including custom classes.
        // If the function does not return a value, the return type is void.

        bool isLoggedIn = false;

        public int sum(int a, int b) // return type: int
        {
            // Execute the code in the body
            int sum = a + b;

            // Then return the value
            return sum; // Note we are returning an int. The same data type as the return type specified
        }

        public string sayHello() // return type: string
        {
            // Excute the code in the body
            // ...

            // Then return the value
            return "Hello, World!"; // Note we are returning a String. The same data type as the return type specified
        }

        public void print(string output) // return type: void
        {
            // Execute the code in the body
            Console.WriteLine(output); // Console.WriteLine() simply prints the output to the console

            // No return statement is needed because the return type is void
            // void means that the function does not return a value
        }

        public void guardClause() // return type: void
        {
            // You can use the return keyword to exit a function early
            // This is useful if you want to exit a function if a certain condition is met
            // For example, if you want to check if a user is logged in before executing some code
            // If the user is not logged in, you can exit the function early
            // This prevents the rest of the code in the function from executing
            // This is called a guard clause
            // Personally, I prefer to use guard clauses over nested if statements because it makes the code easier to read

            // Check if the user is logged in
            if (!isLoggedIn)
            {
                // If the user is not logged in, exit the function early
                return;
            }

            // If the user is logged in, execute the rest of the code in the function
            Console.WriteLine("Hello, User!");
        }
    }
}
