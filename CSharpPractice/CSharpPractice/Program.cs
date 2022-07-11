using System;

namespace CSharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Notes for C# */

            /* ||Basics||
             * 
             * Console.WriteLine("") will print out text to the window 
             * Console.ReadLine will wait for user input to continue to next code (use this to keep window from closing)
             * 
             * |Data Types|
             * int num = 1;
             * double dub = 1.1;
             * bool = true; (bools are lowercase)
             * string name = "john";
             * char initial = 'j';
             * 
             * Usigned Data Types
             * Int32 can hold a integer within the range -2,147,483,648 to 2,147,483,647
             * Unsigned Int32 can hold 0 to 4,294,967,295
             * 
             * When dealing with unsigned number types, the value can't go lower than 0
             * 
             * |Logic|
             * Comparison operators:
             * ==, <=, <, >=, >
             * Logical operators:
             * &&, ||, !
             * 
             * IFS, ELSE IFS, ELSE
             * 
             * if (num == num){Console.WriteLine("True");}
             * else if (num == num1){Console.WriteLine("True v2");}
             * else {Console.WriteLine("False");}
             * 
             * SWITCH
             * switch (num)
             * {
             *      case 3:
             *      stuff
             *      break;
             *      
             *      default:
             *      if no case works, do this
             *      break
             * }
             * 
             * TERNARY OPERATOR
             * One line conditional that assigns a variable one out of 2 values depending on condition
             * 
             * string color = "blue";
             * string result = (color == "red") ? "red" : "NOT red";
             * 
             * () = condition
             * ? = separates conditon and values
             * : = separates values
             * 
             * 
             * ||Methods||
             * 
             * |Methods|
             *
             * Naming Convention - PascalCase
             *
             * Basic structure
             *  ____________
             *  Static void MyMethod(type param)
             *  {
             *      Code;
             *  }
             *  ____________
             *
             *  Optional parameters - string b = “beta”
             *  When using optional parameters, place them at the end of the parameter list.
             *  ____________
             *  Static void MyMethod(string a, string b = “beta”) {}
             *  ____________
             *
             *  If you want to give a value to specific parameter define the parameter with it’s name
             *  (b: “Beta”)
             *  Although named parameters can be defined in whatever order, positional ones must come before
             *  MyMethod(“Alpha”, “Beta” d: “Delta”)
             *
             *  Overloaded methods
             *  Methods with the same name but do use different amounts of arguments
             *  Math.Round(3.1459, 2) #Returns 3.14
             *  Math.Round(3.14) #Returns 3
             *
             *  Return - can only be used if a type is defined in the method declaration
             *  Static string MyMethod() {} must return a string
             *
             *  Out - parameter used to return more than one thing in a method. 
             *  Ex.
             *  Int number;
             *  Bool success = Int32.TryParse(“1”, out number)
             *  #success = true;
             *  #number = 1
             *  If the variable the out is given to does not exist, the method will create the variable after it’s called
             *
             *   Lambda - expressions with no name 
             *  (input-parameters) => expression # use { statement; } if there is more than one expression
             *  Parameter type can be removed if obvious. Parenthesis can be removed if only one param is used
             *
             *  ||Classes and Objects||
             *
             *  |Classes|
             *
             *  Coding Conventions:
             *      Fields - lowercase
             *      Properties - uppercase (names match corresponding field)
             *
             *  Fields - class member that holds different pieces of data. 
             *  ex:
             *  Class Forest {
             *  Public string name;
             *  Public int trees;
             *  }
             *
             *  Properties - class member that gives rules for setting values to fields with get() and set()
             *  Get is called when the property is accessed
             *  Set is called when the property is assigned a value
             *  Ex.
             *  Public int area;
             *  Public int Area
             *  {
             *      Get { return area; }
             *      Set { area = value; }
             *  }
             *  
             * */
        }
    }
}
