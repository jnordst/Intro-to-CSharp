using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_01_Variables_and_Data_Types
{
    internal class Numbers
    {
        // In C# there are several numeric data types.
        // The most common ones are:
        // int - stores integers (whole numbers), without decimals, 4 bytes, -2,147,483,648 to 2,147,483,647
        // long - stores integers (whole numbers), without decimals, 8 bytes -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        // float - stores floating point numbers, with decimals, 4 bytes -3.402823e38 to 3.402823e38
        // double - stores floating point numbers, with decimals, 8 bytes -1.79769313486232e308 to 1.79769313486232e308
        // decimal - stores floating point numbers, with decimals, 16 bytes -7.9228e28 to 7.9228e28
        // byte - stores integers (whole numbers), without decimals, 1 byte 0 to 255
        // short - stores integers (whole numbers), without decimals, 2 bytes -32,768 to 32,767

        // For the most part you will use int, and float/double unless you need access to very large numbers or are optimizing for memory usage.

        // Declaring a numeric variable as a field
        int myInt;
        float myFloat;
        double myDouble;

        public Numbers()
        {
            // Initializing the fields
            myInt = 30;
            myFloat = 19.99f; // float values are followed by an f
            myDouble = 19.99;

            // You can also declare multiple variables on the same line
            int x = 5, y = 10, z = 15;

            // Using Integers
            // Integers are whole numbers. They do not have a decimal point.
            // Integers can be positive or negative.
            
            // Basic Math
            int a = 5;
            int b = 10;
            int c = 5;
            int sum = a + b; // 15
            int subtraction = a - b; // -5
            int multiplication = a * b; // 50
            int division = a / b; // 0
            int modulo = a % b; // 5 | The % operator returns the remainder of a division operation.
            c = c + a + b; // 20 | A variable can perform operations using itself

            // Incrementing
            int d = 5;
            d++; // d is now 6 | The ++ operator increments the value of a variable by 1.

            // Decrementing
            d--; // d is now 5 | The -- operator decrements the value of a variable by 1.

            // Using Floats
            // Floats are numbers with a decimal point.
            // Floats can be positive or negative.
            // Floats are declared with the float keyword.
            // Floats have 7 digits of precision.
            myFloat = 19.99f;
            myFloat = 19.99f + 1.01f; // myFloat is now 21.00

            // Casting (Converting) Data Types
            // You can convert one data type to another using casting.
            // Casting is done by placing the type you want to convert to in parentheses in front of the value.
            // Casting is useful when you need to perform operations on variables of different types.
            // For example, you can't add an int and a float, but you can cast the int to a float and then add them.
            myInt = 5;
            myFloat = 19.99f;
            myDouble = 19.99;

            myFloat = myInt; // myFloat is now 5.0 | Implicit casting is done automatically by the compiler
            myFloat = (float)myInt; // myFloat is now 5.0 | Explicit casting is done manually by the programmer
            myDouble = (double)myInt; // myDouble is now 5.0 | Explicit casting is done manually by the programmer
            myDouble = Convert.ToDouble(myInt); // myDouble is now 5.0 | You can also use the Convert class to cast data types if applicable
        }
    }
}
