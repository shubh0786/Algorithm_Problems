using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 

namespace Algorithm3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(30,0));
            Console.WriteLine(test(25, 5));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(30, 0));
            Console.WriteLine(test(20, 0));


            Console.ReadLine();
        }

        public static bool test(int n, int y)
        {
            return n == 30 || y == 30 || (n + y == 30);
        }


    }
}
