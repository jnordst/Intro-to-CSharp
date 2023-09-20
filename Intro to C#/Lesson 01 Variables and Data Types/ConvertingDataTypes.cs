using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_01_Variables_and_Data_Types
{
    internal class ConvertingDataTypes
    {
        public ConvertingDataTypes()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            string myString = "10";

            // Converting to String
            // The ToString() method is used to convert a number to a string.
            string convertInt = myInt.ToString(); // "10"
            string convertDouble = myDouble.ToString(); // "5.25"
            string convertBool = myBool.ToString(); // "True"

            // Converting Strings
            // The Convert class can be used to convert strings to numbers.
            int convertString = Convert.ToInt32("10"); // 10
            double convertString2 = Convert.ToDouble("10.99"); // 10.99
            bool convertString3 = Convert.ToBoolean("true"); // true

            // Convert Class
            // The Convert class is used to convert data types.
            // The Convert class has methods to convert to and from most of the built-in data types.
            myInt = Convert.ToInt32("100"); // 100
            myDouble = Convert.ToDouble("100.99"); // 100.99
            myBool = Convert.ToBoolean("true"); // true

            // Casting
            // Casting is used to convert between data types.
            // Casting is done by placing the desired data type in parentheses in front of the value.
            // Casting is useful when you need to perform operations on variables of different types.
            myInt = 10;
            myDouble = 5.25;

            myDouble = myInt; // 10.0 | Implicit casting is done automatically by the compiler
            myDouble = (double)myInt; // 10.0 | Explicit casting is done manually by the programmer
            myDouble = Convert.ToDouble(myInt); // 10.0 | You can also use the Convert class to cast data types if applicable

            // Converting Floating Point Numbers to Integers
            // Converting a floating point number to an integer will remove the decimal point.
            // This is called truncation.
            // Truncation is the process of removing the decimal places from a number.
            myDouble = 10.99;
            myInt = (int)myDouble; // 10 | The decimal places are truncated
            myInt = Convert.ToInt32(myDouble); // 10 | The decimal places are truncated
            myDouble = Math.Round(myDouble); // 11 | The Math class can be used to round numbers



        }
    }
}
