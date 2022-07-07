using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             * */
        }
    }
}
