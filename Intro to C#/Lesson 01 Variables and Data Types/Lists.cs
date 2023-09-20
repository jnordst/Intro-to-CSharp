using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_01_Variables_and_Data_Types
{
    internal class Lists
    {
        // In C# there are several kinds of collections that you can use to store multiple values.
        // The most common ones are:
        // Array - a fixed size collection of elements of the same type
        // List - a dynamic size collection of elements of the same type
        // Dictionary - a collection of key/value pairs

        public Lists()
        {
            // ----------------------------------------------------------------------------
            // Arrays
            // ----------------------------------------------------------------------------
            // An array is a collection of elements of the same type.
            // Arrays are fixed size, meaning that once you create an array, you cannot add or remove elements from it.
            // To add or remove elements from an array, you must create a new array with the correct size.
            // Arrays are zero indexed, meaning that the first element in an array has an index of 0.
            // You can access an element in an array by using its index.
            // The length of an array is the number of elements it contains.

            // Declaring an Array
            int[] myArray; // You can declare an array by specifying the type of the elements it contains, followed by [].

            // Initialing an Array with a Size
            int[] myArray2 = new int[5]; // 5 is the size of the array

            // Initializing an Array with Values
            int[] myArray3 = new int[] { 1, 2, 3, 4, 5 }; // -> [1, 2, 3, 4, 5]

             // You can assign an array to another array
             myArray = myArray3;

            // Accessing Elements in an Array
            // You can access an element in an array by using its index.
            // The index of an array starts at 0.
            // You can access the last element in an array by using the length of the array minus 1.
            // You can also use the Length property to get the length of an array.

            int length = myArray.Length; // -> 5
            int firstElement = myArray[0]; // -> 1
            int lastElement = myArray[myArray.Length - 1]; // -> 5

            // Changing Elements in an Array
            // You can change the value of an element in an array by using its index.
            myArray[0] = 10; // -> [10, 2, 3, 4, 5]

            // ----------------------------------------------------------------------------
            // Lists
            // ----------------------------------------------------------------------------
            // A list is a collection of elements of the same type.
            // Lists are dynamic size, meaning that you can add or remove elements from them.
            // Lists are similar to arrays, but they are more flexible. Use lists when you need to add or remove elements from a collection.

            // Declaring a List
            List<int> myList; // You can declare a list by specifying the type of the elements it contains, followed by <>.

            // Initializing a List
            myList = new List<int>(); // -> []

            // Adding Elements to a List
            myList.Add(1); // -> [1]

            // Adding Multiple Elements to a List
            myList.AddRange(myArray); // -> [1, 10, 2, 3, 4, 5]

            // Removing Elements from a List
            myList.Remove(1); // -> [10, 2, 3, 4, 5] | Removes the first occurrence of 1
            myList.RemoveAt(0); // -> [2, 3, 4, 5] | Removes the element at index 0
            myList.RemoveRange(0, 2); // -> [4, 5] | Removes 2 elements starting at index 0

            // Accessing Elements in a List
            // You can access an element in a list by using its index.
            // The index of a list starts at 0.

            myList[0] = 10; // -> [10, 5]
            myList[1] = 10; // -> [10, 10]

            // ----------------------------------------------------------------------------
            // Dictionaries
            // ----------------------------------------------------------------------------
            // A dictionary is a collection of key/value pairs.
            // Each key in a dictionary must be unique.
            // Dictionaries are similar to lists, but they are more faster and more flexible. Use dictionaries when you need to access elements by a key.
            // Dictionaries are also known as maps or hashmaps in other programming languages.

            Dictionary<string, int> myDictionary; // You can declare a dictionary by specifying the type of the key and the type of the value it contains, followed by <>.
            myDictionary = new Dictionary<string, int>(); // -> {}

            // Adding Elements to a Dictionary
            myDictionary.Add("one", 1); // -> {"one": 1}
            myDictionary.Add("two", 2); // -> {"one": 1, "two": 2}

            // Accessing Elements in a Dictionary
            // You can access an element in a dictionary by using its key.
            // The key of a dictionary must be unique.
            // You can also use the ContainsKey method to check if a dictionary contains a key.

            // Get the value of a key
            int value = myDictionary["one"]; // -> 1

            // Check if a dictionary contains a key
            bool containsKey = myDictionary.ContainsKey("one"); // -> true

            // Changing Elements in a Dictionary
            // You can change the value of an element in a dictionary by using its key.
            myDictionary["one"] = 10; // -> {"one": 10, "two": 2}

            // Removing Elements from a Dictionary
            myDictionary.Remove("one"); // -> {"two": 2}


        }
    }
}
