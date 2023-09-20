using System;

public class Variables
{
    // ---------------------------
    // Variables and Data Types
    // ---------------------------
    // Variables are containers for storing data values.
    // C# is a strongly typed language. This means that every variable must be declared with a data type.
    // The data type specifies which type of value the variable has, and what operations can be performed on it.
    // In C#, there are different types of variables (defined with different keywords), for example:
    // int - stores integers (whole numbers), without decimals
    // float - stores floating point numbers, with decimals
    // char - stores single characters. Char values are surrounded by single quotes
    // string - stores text, such as "Hello World". String values are surrounded by double quotes.
    // bool - stores values with two states: true or false

    int myInt = 30;
    float myFlaot = 19.99;
    char myChar = 'A';
    string myString = "Hello World 123!";
    bool myBool = true;

    // ---------------------------
    // Access Modifiers
    // ---------------------------
    // public - the code is accessible for all classes
    // private - the code is only accessible within the same class
    // protected - the code is accessible within the same class, or in a class that is inherited from that class.
    // static - means that the code belongs to the class, instead of an object of the class. And you can access it without creating an object of the class.
    // readonly - the value of the field can be set once (when it is initialized), and then it cannot be changed.

    public string name = "John"; // public
    private int age = 35; // private
    double gpa = 3.2; // if no access modifier is set, the default is private
    protected char grade = 'A'; // protected
    bool isMale = true;

}
