using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_01_Variables_and_Data_Types
{
    internal class Booleans
    {
        // In C#, the bool keyword is used to declare a variable of the Boolean data type.
        // Boolean variables can have two values: true or false.
        // Boolean values are mostly used for conditional testing.

        public Booleans()
        {
            // Initializing a boolean variable
            bool isTrue = true;
            bool isFalse = false;

            // Operators
            bool equalTo = isTrue == true; // -> true | Equal to
            bool notEqualTo = isTrue != true; // -> false | Not equal to
            bool and = isTrue && isFalse; // -> false | And
            bool or = isTrue || isFalse; // -> true | Or
            bool not = !isTrue; // -> false | Not
            bool greaterThan = 10 > 5; // -> true | Greater than
            bool lessThan = 10 < 5; // -> false | Less than
            bool greaterThanOrEqualTo = 10 >= 5; // -> true | Greater than or equal to
            bool lessThanOrEqualTo = 10 <= 5; // -> false | Less than or equal to

            // Using the if statement with boolean values

            // Checking if a boolean value is true
            if (isTrue == true) // if isTrue is true
            {
                Console.WriteLine("isTrue is true");
            }

            if (isTrue != false) // if isTrue is NOT false
            {
                Console.WriteLine("isTrue is true");
            }

            if (isTrue) // if isTrue is true (short form)
            {
                Console.WriteLine("isTrue is true");
            }

            // Checking if a boolean value is false
            if (isTrue == false) // if isTrue is false
            {
                Console.WriteLine("isTrue is false");
            }

            if (isTrue != true) // if isTrue is NOT true
            {
                Console.WriteLine("isTrue is false");
            }

            if (!isTrue) // if isTrue is NOT true (short form)
            {
                Console.WriteLine("isTrue is false");
            }


        }
    }
}
