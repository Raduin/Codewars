using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
    //Write a function which converts the input string to uppercase.

    class Program
    {
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
        public static void Main()
        {
            Console.WriteLine(MakeUpperCase("hello"));

            Console.Read();
        }
    }
}