using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum. Go to the editor

//Sample Input:
//1, 2
//3, 2
//2, 2
//Expected Output:
//3
//5
//12   

namespace Algorithm1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(test(5,2));
            Console.WriteLine(test(8, 2));
            Console.WriteLine(test(2, 2));
            Console.ReadLine();
        }

        public static int test(int x, int y)

       {

          return x == y ? (x + y)*3 : x + y;

        }

       
       
    }
}
