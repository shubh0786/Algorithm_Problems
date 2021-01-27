using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged. Go to the editor

//Sample Input:
//"if else"
//"else"
//Expected Output:
//if else
//if else

namespace Algorithm_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(test("else"));
            Console.ReadLine();
           
        }



        public static string test (string s)
        {

            if (s.Length > 2 && s.Substring(0,2).Equals("if"))
            {
                return s;


            }

            return "if " + s;

        }
        

            

        }
	}
            
 
            
            
   