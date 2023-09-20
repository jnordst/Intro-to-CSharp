using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_02_Functions
{
    internal class Scope
    {
        // There are two types of scope: local scope and global scope.
        // Local scope refers to variables that are declared inside a function.
        // Local variables can only be accessed from within the function in which they are declared.
        // Global scope refers to variables that are declared outside of any function.
        // Global variables can be accessed from anywhere in the program.

        // This is a global variable.
        // It can be accessed from anywhere in the program.
        int myInt = 5;

        public void myFunction()
        {
            // This is a local variable.
            // It can only be accessed from within the myFunction() function.
            int myInt2 = 10;

            // We can still access the global variable from within this function
            int myInt3 = myInt;

            // You can also access the global variable using the this keyword if there is a naming conflict
            int myInt4 = this.myInt;
        }

        public void myFunction2()
        {
            // We cannot access the local variable from outside the function
            // This will cause an error
            // int myInt5 = myInt2;
        }
    }
}
