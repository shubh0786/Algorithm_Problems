using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//6. Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive. Go to the editor

//Sample Input:
//"Python", 1
//"Python", o
//"Python", 4
//Expected Output:
//Pthon
//ython
//Pythn


namespace Algorith6
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(test("shubham", 2));

            Console.WriteLine(test("shubham", 5));

            Console.WriteLine(test("shubham", 0));

            Console.ReadLine();
        }

        public static string test(string s, int a)
        {

            return s.Remove(a, 1);
        }
       
    }
}
