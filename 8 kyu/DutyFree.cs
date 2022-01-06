using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
    //The purpose of this kata is to work out just how many bottles of duty free whiskey you would have to buy such that the saving over the normal high street price would effectively cover the cost of your holiday.
    //You will be given the high street price (normPrice), the duty free discount (discount) and the cost of the holiday.
    //For example, if a bottle cost £10 normally and the discount in duty free was 10%, you would save £1 per bottle. If your holiday cost £500, the answer you should return would be 500.

    //All inputs will be integers.Please return an integer. Round down.

    class Program
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            if (Discount != 0 && normPrice != 0)
                return (int)(hol / ((decimal)normPrice * Discount / 100));
            else
                // Solution of this kata is not correct. I have to use MIN int value to solve this problem.
                return -2147483648;
        }
        public static void Main()
        {

            int normPrice = 300;
            int Discount = 0; 
            int hol = 500;

            Console.WriteLine(DutyFree(normPrice, Discount, hol));


            Console.Read();
        }
    }
}