using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TEMP
{
   // using NUnit.Framework;
    // Create a function that returns an array containing the first l numbers from the nth diagonal of Pascal's triangle.

    // n = 0 should generate the first diagonal of the triangle(the ones).
    // The first number in each diagonal should be 1.
    // If l = 0, return an empty array.
    // Both n and l will be non-negative integers in all test cases.

    class Program
    {
        public static BigInteger[] GenerateDiagonal(int n, int l)
        {
            BigInteger[] diagonal = new BigInteger[l];
 
            BigInteger[,] arrPascal = new BigInteger[n+1, l+1];
            for (int i = 0; i <= n; i++)
                arrPascal[i,0] = 1;
            for (int i = 1; i <= l; i++)
                arrPascal[0, i] = 1;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= l; j++)
                    arrPascal[i, j] = arrPascal[i - 1, j] + arrPascal[i, j - 1];

            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= l; j++)
            //        Console.Write(arrPascal[i,j] + "  ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            for (int i =  0; i < l; i++)
                diagonal[i] = arrPascal[n,i];

            return diagonal;
        }
        public static void Main()
        {
            int n = 3;
            int l = 7;
            BigInteger[] res = GenerateDiagonal(n, l);

            for (int i = 0; i < l; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.WriteLine();

            Console.Read();
        }
    }
}
