using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_04_Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            // The first input is an integer containing the number of test cases
            // Convert input to integer
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                Printer printer = new Printer(input);
            }
        }
    }

    class Printer
    {
        string odd = "";
        string even = "";

        public Printer(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 % 2 == 0)
                {
                    even = even + input[i];
                }
                else
                {
                    odd = odd + input[i];
                }
            }

            Console.WriteLine($"{odd} {even}");
        }
    }

}
