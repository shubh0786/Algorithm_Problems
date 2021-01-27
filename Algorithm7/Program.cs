using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. Go to the editor

//Sample Input:
//"abcd"
//"a"
//"xy"
//Expected Output:

//dbca
//a
//yx

namespace Algorithm7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("singh"));
            Console.WriteLine(test("saah"));
            Console.ReadLine();

        }


        public static string test(string s)
        {

            return  s.Length>1

                ? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;

        }
    }
}
