using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_01_Variables_and_Data_Types
{
    public class Strings
    {
        // In C#, strings are objects. The string keyword is an alias for the System.String class.
        // Strings are immutable. This means that once a string is created, it cannot be changed.
        // To modify an existing string, you must create a new string object that contains the modifications.
        // Strings can be concatenated to form new strings.
        // String literals (denoted by double or single quotes) and strings returned from String class methods or property are immutable.
        // Strings are a collection (array) of char values. A char value is surrounded by single quotes, like 'A' or 'c'.

        // Declaring a string variable as a field
        string myString;

        public Strings()
        {
            // Assigning a value to a string variable
            myString = "Hello World!"; // myString is now "Hello World!"
            Console.WriteLine(myString); // -> Hello World!

            // Remember that strings are immutable, so you aren't actually changing the value of a string variable
            // However, you can assign a new value to a string variable. This will create a new string object.

            // String Concatenation
            string firstName = "John"; // You can declare and assign a value to a string variable on the same line
            string lastName = "Doe";
            string fullName = firstName + " " + lastName; // You can combine strings using the + operator
            Console.WriteLine(fullName); // -> John Doe

            // String Interpolation
            int age = 35;
            string bio = $"My name is {fullName} and I am {age} years old."; // You can use string interpolation to insert variables into a string
            Console.WriteLine(bio); // -> My name is John Doe and I am 35 years old.


            // String Methods
            // Strings have many built-in methods that you can use to manipulate them.

            // Length
            // The Length property returns the length of a string (number of characters).
            myString = "Hello World!";
            Console.WriteLine(myString.Length); // -> 12

            // ToUpper
            // The ToUpper method returns a copy of a string converted to uppercase.
            Console.WriteLine(myString.ToUpper()); // -> HELLO WORLD!

            // ToLower
            // The ToLower method returns a copy of a string converted to lowercase.
            Console.WriteLine(myString.ToLower()); // -> hello world!

            // IndexOf
            // The IndexOf method returns the index of the first occurrence of a specified character in a string.
            Console.WriteLine(myString.IndexOf("o")); // -> 4

            // LastIndexOf
            // The LastIndexOf method returns the index of the last occurrence of a specified character in a string.
            Console.WriteLine(myString.LastIndexOf("o")); // -> 7

            // Substring
            // The Substring method returns a substring of a string.
            // The substring starts at a specified character position and has a specified length.
            Console.WriteLine(myString.Substring(6, 5)); // -> World (starts at index 6 and has a length of 5           )

            // Remove
            // The Remove method deletes a specified number of characters from a string.
            // The Remove method returns a new string.
            Console.WriteLine(myString.Remove(5)); // -> Hello (removes all characters after index 5)

            // Replace
            // The Replace method replaces a specified character or string with another character or string.
            // The Replace method returns a new string.
            Console.WriteLine(myString.Replace("World", "Universe")); // -> Hello Universe!

            // Contains
            // The Contains method checks whether a string contains a specified character or string.
            // The Contains method returns a boolean value.
            Console.WriteLine(myString.Contains("World")); // -> True

            // StartsWith
            // The StartsWith method checks whether a string starts with a specified character or string.
            // The StartsWith method returns a boolean value.
            Console.WriteLine(myString.StartsWith("Hello")); // -> True

            // EndsWith
            // The EndsWith method checks whether a string ends with a specified character or string.
            // The EndsWith method returns a boolean value.
            Console.WriteLine(myString.EndsWith("World!")); // -> True

            // Trim
            // The Trim method removes whitespace from both sides of a string.
            // The Trim method returns a new string.
            myString = "   Hello World!   ";
            Console.WriteLine(myString.Trim()); // -> Hello World!

            // Split
            // The Split method splits a string into substrings.
            // The Split method returns an array of strings.
            myString = "Hello,World,!";
            string[] myArray = myString.Split(','); // -> ["Hello", "World", "!"]
            Console.WriteLine(myArray[0]); // -> Hello

            // Get the index of a substring inside a string
            // You can use the IndexOf method to get the index of a substring inside a string.
            // The IndexOf method returns -1 if the substring is not found.
            myString = "Hello World!";
            Console.WriteLine(myString.IndexOf("World")); // -> 6

            // Escape Characters
            // Because strings must be written within quotes, C# will misunderstand this string, and generate an error:
            // string justice = "What you call "Justice" is an illusion!";
            // The solution to avoid this problem, is to use the backslash escape character.
            // The backslash (\) escape character turns special characters into string characters:
            string justice = "What you call \"Justice\" is an illusion!";

        }


    }
}
