using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_03_Conditions_and_Loops
{
    internal class ConditionalStatements
    {
        // Conditional statements are used to perform different actions based on different conditions.
        // They are also known as if/else statements.
        // Conditional statements are used to make dynamic decisions in code based on the value of a variable.
        // Please read Lesson 01 Booleans before continuing to understand the conditional operators.

        public ConditionalStatements()
        {
            // if statement
            int age = 18;
            if (age >= 18)
            {
                // This code will be executed if the condition is true
                Console.WriteLine("You are eligible to vote.");
            }

            // if else statement
            int number = 10;
            if (number % 2 == 0) 
            {
                // This code will be executed if the condition is true
                Console.WriteLine("Number is even.");
            }
            else
            {
                // This code will be executed if the condition is false
                Console.WriteLine("Number is odd.");
            }

            // else if statements
            int grade = 85;
            if (grade >= 90) // false
            {
                // This code will be executed if the condition is true
                Console.WriteLine("A");
            }
            else if (grade >= 80) // true
            {
                // If at any point the condition is true, the code will be executed and the rest of the conditions will be skipped
                Console.WriteLine("B");
            }
            else if (grade >= 70) // skipped
            {
                Console.WriteLine("C");
            }
            else // skipped
            {
                // The else statement is the default statement if all other conditions are false
                Console.WriteLine("F");
            }

            // switch statements are used to select one of many code blocks to be executed
            // switch statements are often used as an alternative to if/else statements
            // switch statements are useful when you have multiple conditions to check
            int day = 2;
            switch (day)
            {
                case 1: // Because day is not equal to 1, this case will be skipped
                    Console.WriteLine("Monday");
                    break; // break is used to exit the switch statement
                case 2: // Because day is equal to 2, this code will be executed
                    Console.WriteLine("Tuesday");
                    break;
                // ...
                default: // If none of the cases are true, the default case will be executed siimilarly to the else statement
                    Console.WriteLine("Unknown day");
                    break;
            }
        }
    }
}
