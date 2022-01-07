using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMP
{
    // Your task, is to create NxN multiplication table, of size provided in parameter.
    // for example, when given size is 3:

    // 1 2 3
    // 2 4 6
    // 3 6 9

    // for given example, the return value should be: [[1,2,3],[2,4,6],[3,6,9]]

    class Program
    {
        public static int[,] MultiplicationTable(int size)
        {
            int[,] arrayResult = new int[size,size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    arrayResult[i, j] = (i+1) * (j+1);
            return arrayResult;
        }
        public static void Main()
        {

            int size = 9;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(MultiplicationTable(size)[i,j] + "  ");
                    if (MultiplicationTable(size)[i,j] >= 10)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(("  "));
                    }
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}