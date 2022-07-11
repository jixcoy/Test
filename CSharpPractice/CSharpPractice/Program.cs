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
             *  |Fields| - class member that holds different pieces of data. 
             *  ex:
             *  class Forest {
             *  public string name;
             *  public int trees;
             *  }
             *
             *  |Properties|
             *  class member that gives rules for setting values to fields with get() and set()
             *  Get is called when the property is accessed
             *  Set is called when the property is assigned a value
             *  Ex.
             *  public int area;
             *  public int Area
             *  {
             *      Get { return area; }
             *      Set { area = value; }
             *  }
             *  
             *  |Automatic Properties |
             *  make making a property fast and easy by not requiring a field to be set in the first place.
             *  The field is still made in the background, but all that matters is the property
             *  Automatic ex.
             *  public int Area
             *  { get; set; }
             *  
             *  |Public v Private|
             *  Public and private are access modifiers and dictate whether a a member can be accessed by and any class or only by code within
             *  the same class. Generally, fields are private and properties are public
             *  
             *  |Get-Only Properties|
             *  If you want to be able to get a property but not be able to set it, there are two methods. 
             *  1) include no set() - gives this warning whenever and wherever code tries to set it:
             *  "error CS0200: Property or indexer 'Forest.Area' cannot be assigned to (it is read-only)"
             *  2) make the set() private - gives this warning whenever code tries to set it outside of the class:
             *  "error CS0272: The property or indexer 'Forest.Area' cannot be used in this context because the set accessor is inaccessible"
             *  
             *  Option 2 is used more to allow code in the class to set the property
             *  
             *  |Methods|
             *  Same syntax as a normal method. Can be used as a normal method or to change data in a class
             *  
             *  |Constructors|
             *  Used to give values to fields and properties automatically when the class is instantiated with the "new" keyword.
             *  If a constructor is not defined in a class, a hidden one will be automatically created and holds no parameters
             *  Ex.
             *  class Forest
             *  {
             *      public int Area;
             *      public Forest(int area)
             *      {
             *          Area = area
             *      }
             *  }
             *  
             *  Forest f = new Forest(0);
             *  
             *  To be more specific with constructors, use the "this" keyword when assigning values to properties that are similar in name.
             *  Adding "this" tells the reader the value is being added to "this" instance of the class.
             *  ex.
             *  this.Area = area;
             *  
             *  "this" can also be used as a function when overloading constructors. Remember to not confuse the meaning
             *  
             * */
        }
    }
}
