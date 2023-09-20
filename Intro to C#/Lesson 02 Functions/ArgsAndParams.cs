using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intro_to_C_.Lesson_02_Functions
{
    internal class ArgsAndParams
    {
        // Functions can accept parameters, which are values that are passed into the function as arguments.
        // Parameters are specified inside the parentheses after the name of the function.
        // Parameters are separated by commas.
        // Parameters can be any data type, including custom classes, depending on the function's requirements.
        // Arguments are the actual values that are passed into the function. They are specified when the function is called.

        public void myFunction(int myInt, string myString) // Note the parameters are specified here
        {
            // This function accepts two parameters, an int and a String

            // We can access the values of the parameters inside the function body by using the name of the parameter
            int myInt2 = myInt;
            string myString2 = myString;

            // We can also pass ARGUMENTS into the function when we call it
            print("Hello, World!"); // These are called arguments when they are passed into the function
        }

        void print(string output)
        {
            Console.WriteLine(output);
        }
    }
}
