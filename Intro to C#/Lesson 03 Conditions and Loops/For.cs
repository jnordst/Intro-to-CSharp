using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_03_Conditions_and_Loops
{
    internal class For
    {
        // The for loop is the most commonly used loop in Java.
        // The for loop is used when you know how many times you want to loop through a block of code.

        List<string> weekdays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public void myFunction()
        {
            // for i loop
            for (int i = 0; i < 5; i++)
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
                // Iteration 6: i = 5. 5 < 5 is false. Exit the loop.
            }

            // The for loop can also be used to iterate over an array or ArrayList.
            for (int j = 0; j < weekdays.Count; j++)
            {
                Console.WriteLine(weekdays[j]); // -> Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            }

            // for each loop
            foreach (string day in weekdays)
            {
                Console.WriteLine(day); // -> Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

                // This code will be executed 7 times
                // The variable weekday will be assigned the value of each element in the ArrayList
                // The loop will stop when there are no more elements in the ArrayList
            }
        }
    }
}
