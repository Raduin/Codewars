using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
// Sentence Smash
// Write a function that takes an array of words and smashes them together into a sentence and returns the sentence.
// You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word.
// Be careful, there shouldn't be a space at the beginning or the end of the sentence!

// Example
// ['hello', 'world', 'this', 'is', 'great']  =>  'hello world this is great'

    class Program
    {
        public static string Smash(string[] words)
        {
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i] + " ";
            }
            return result.Trim();
        }
        public static void Main()
        {

            string[] str = { "   this", "is", "a", "really", "long", "sentence " };
            Console.WriteLine(Smash(str));


            Console.Read();
        }
    }
}
