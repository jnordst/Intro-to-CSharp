using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_02_Functions
{
    internal class Functions
    {
        // Functions are a way to organize code into reusable blocks.
        // Functions are also called methods.
        // Functions are defined with the following syntax:

        public void myFunction()
        {
            // Code to be executed
        }

        // Lets break down exactly what is happening here...

        // First, we have the access modifier, which is public.
        // This means that the function can be accessed from anywhere.

        // Next, we have the return type, which is void.
        // This means that the function does not return a value. It simply executes some code.

        // Next, we have the name of the function, which is myFunction.
        // This is the name that we will use to call the function.

        // Next, we have the parameters of the function, which are empty. ()
        // Inside these parentheses we can define parameters that the function will accept.
        // We will cover parameters in more detail later.

        // Finally, we have the body of the function, which is the code that will be executed when the function is called.
        // The code block is enclosed inside curly braces. { code }

        // Now that we have defined the function, we can call it from anywhere in our code.
        // To call a function, we simply write the name of the function followed by parentheses.
        // myFunction();
    }
}
