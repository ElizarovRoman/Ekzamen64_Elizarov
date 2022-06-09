using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ekzamen_Elizarov
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int[][] matrix = new int[5][];
            matrix[0] = new int[] { 1, 2, 3, 3, 5 };
            matrix[1] = new int[] { 7, 4, 3, 2, 1 };
            matrix[2] = new int[] { 7, 4, 3, 2, 1 };
            matrix[3] = new int[] { 5, 3, 3, 2, 1 };
            matrix[4] = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Существующий массив: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    if (test(matrix[i], matrix[j]))
                    {
                        Console.WriteLine("Строки {0} и {1} похожи\n", i+1, j+1);
                        flag = false;
                        
                    }
                }
            }
            if (flag) Console.WriteLine("В матрице нет похожих строк!");
            Console.ReadKey();
        }

        private static bool test(int[] row, int[] rowT)
        {
            Array.Sort(row);
            Array.Sort(rowT);
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != rowT[i]) return false;
            }
            return true;
        }
    }
}

