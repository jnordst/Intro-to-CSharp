using Intro_to_C_.Lesson_01_Variables_and_Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_03_Conditions_and_Loops
{
    internal class While
    {
        // The While loop is used to execute a block of code repeatedly until a condition is met.

        List<string> weekdays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public While()
        {
            // while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i); // -> 0, 1, 2, 3, 4

                // This code will be executed 5 times
                // The variable i will be incremented by 1 each time the code is executed
                // The loop will stop when i is no longer less than 5
                // The variable i is only accessible from within the loop
                // The variable i is called the loop counter

                // Lets break down exactly what is happening here...
                // Iteration 1: i = 0. 0 < 5 is true. Execute the code. Increment i by 1.
                // Iteration 2: i = 1. 1 < 5 is true. Execute the code. Increment i by 1.
                // Iteration 3: i = 2. 2 < 5 is true. Execute the code. Increment i by 1.
                // Iteration 4: i = 3. 3 < 5 is true. Execute the code. Increment i by 1.
                // Iteration 5: i = 4. 4 < 5 is true. Execute the code. Increment i by 1.
            }

            // The while loop can also be used to iterate over an array or ArrayList.
            int j = 0;
            while (j < weekdays.Count)
            {
                Console.WriteLine(weekdays[j]); // -> Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
                j++;
            }

            // Loop while a condition is true
            bool isTrue = true;

            // This code will be executed until isTrue is set to false
            while (isTrue)
            {
                Console.WriteLine("Hello");

                isTrue = false;

                // This code will still be executed once because the condition is checked at the end of the loop
                Console.WriteLine("Hello");

                // Exit the loop...
            }

            // do while loop
            int k = 0;
            do
            {
                Console.WriteLine(k); // -> 0
                k++;
            } while (k == 5);

            // do while loop is executed AT LEAST once before the condition is checked
            // Normally in this case the loop would not be executed because k is not equal to 5
            // However, because the do while loop is executed at least once, the loop is executed once
            // Then the condition is checked and the loop is exited

            // break statement
            int l = 0;

            while (true) // It is good practice not to use a while(true) loop because sometimes it can cause an infinite loop
            {
                Console.WriteLine(l); // -> 0, 1, 2, 3, 4

                l++;

                // Exit the loop when l is equal to 5
                if (l == 5)
                {
                    break; // break is used to exit a loop immediately similarly to return
                }
            }

            // continue statement
            int m = 0;

            while (m < 10)
            {
                m++;

                // Skip the rest of the code in the loop and continue to the next iteration
                if (m == 5)
                {
                    continue; // continue is similar to break, but instead of exiting the loop, it skips the rest of the code in the loop and continues to the next iteration
                }

                Console.WriteLine(m); // -> 1, 2, 3, 4, 6, 7, 8, 9, 10
                // Notice that 5 is missing because it was skipped
            }
        }
    }
}
