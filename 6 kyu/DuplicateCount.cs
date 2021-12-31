using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
   // Count the number of Duplicates
   // Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string.
   // The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.

   //Example
   // "abcde" -> 0 # no characters repeats more than once
   // "aabbcde" -> 2 # 'a' and 'b'
   // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
   // "indivisibility" -> 1 # 'i' occurs six times
   // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
   // "aA11" -> 2 # 'a' and '1'
   // "ABBA" -> 2 # 'A' and 'B' each occur twice



    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            int result = 0;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        result += 1;
                        str = str.Replace(Convert.ToString(str[i]), string.Empty);
                        i = 0;
                        break;
                    }
                }
            }
              return result; 
        }
    }
    class Program
    {
     
        public static void Main()
        {
            string str = "aA1++1";
            Console.WriteLine(str);
            Console.WriteLine(Kata.DuplicateCount(str));

            Console.Read();
        }
    }
}

