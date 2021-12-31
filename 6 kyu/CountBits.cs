using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
    //Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number.
    //You can guarantee that input is non-negative.

    //Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case



    public class Kata
    {
        public static int CountBits(int n)
        {
            int result = 0;
            string str = Convert.ToString(n, 2);
            if (n >= 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1')
                        result++;
                }
                return result;
            }
            else
              return -1; 
        }
    }
    class Program
    {
     
        public static void Main()
        {

            int x = 5;
            Console.WriteLine(x);
            Console.WriteLine(Convert.ToString(x,2));
            Console.WriteLine(Kata.CountBits(x));


            Console.Read();
        }
    }
}

