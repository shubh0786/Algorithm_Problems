using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. Go to the editor

//Sample Input:
//103
//90
//89
//Expected Output:
//True
//True
//False


namespace Algorithm4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(test(300));

            Console.WriteLine(test(200));

            Console.WriteLine(test(100));

            Console.WriteLine(test(30));
            Console.ReadLine();
        }


        public static bool test(int x)
        {

            if (Math.Abs(x - 100)  <=10 || Math.Abs(x-200) <=10)

                return true;
            return false;

        }

    

    }
}
