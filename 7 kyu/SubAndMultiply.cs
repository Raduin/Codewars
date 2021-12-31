using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
// Write a function that accepts two parameters(sum and multiply) and find two numbers[x, y], where x + y = sum and x* y = multiply.
// Example:
// sum = 12 and multiply = 32
// In this case, x equals 4 and y equals 8.
// x = 4
// y = 8
// Because
// x + y = 4 + 8 = 12 = sum
// x* y = 4 * 8 = 32 = multiply
// The result should be [4, 8].
// Note:
// 0 <= x <= 1000
// 0 <= y <= 1000
// If there is no solution, your function should return null (or None in python).
// You should return an array (list in python) containing the two values [x, y]
// and it should be sorted in ascending order.
// One last thing: x and y are integers (no decimals).


    public class Kata
    {
        public static int[] SubAndMultiply(int sum, int multiply)
        {
            int[] array = new int[2];
            int discriminant = sum * sum - 4 * multiply;
            if (discriminant < 0)
                array = null;
            else if (discriminant == 0)
                array[0] = array[1] = sum / 2;
            else
            {
                if (Math.Sqrt(discriminant) % 1 == 0)
                {
                    array[0] = (sum - Convert.ToInt32(Math.Sqrt(discriminant))) / 2;
                    array[1] = (sum + Convert.ToInt32(Math.Sqrt(discriminant))) / 2;
                }
                else
                    array = null;
            }
            return array;
        }
    }
    class Program
    {
     
        public static void Main()
        {

            int[] array = new int[2];
            array = Kata.SubAndMultiply(6, 9);

            if (array == null)
            {
                Console.WriteLine($"The function returned null");
            }
            else
            {
                Console.WriteLine($"x = {array[0]}");
                Console.WriteLine($"y = {array[1]}");
            }

            Console.Read();
        }
    }
}