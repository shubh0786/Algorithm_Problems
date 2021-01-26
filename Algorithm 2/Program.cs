using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.


namespace Algorithm_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(test(53));
            Console.WriteLine(test(53));
            Console.WriteLine(test(51));
            Console.ReadLine();

        }



        public static int test(int n)
        {

            var x = 51;

            if (n > x)
            {

              


                return (n - x) * 3;



            }
            else
            {
                return x - n;
            }




        }
    }
}
