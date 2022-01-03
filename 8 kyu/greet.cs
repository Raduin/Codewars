using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
    //    Description:
    //Make a simple function called greet that returns the most-famous "hello world!".

    //Style Points
    //Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of?
    //What is a "hello world" solution you would want to show your friends?
    class Program
    {

        public static string greet()
        {
            return "hello world!";
        }
        public static void Main()
        {

            Console.WriteLine(greet());

            Console.Read();
        }
    }
}