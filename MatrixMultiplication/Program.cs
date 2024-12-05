using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 4]
            {
            { 1, 2, 3, 2 },
            { 3, 4, 5, 6 },
            { 5, 6, 8, 4 }
            };

            int[,] matrix2 = new int[4, 3]
            {
            { 2, 5, 3 },
            { 4, 5, 1 },
            { 8, 7, 9 },
            { 3, 7, 2 }
            };
            int[,] matrixMultiplied = new int[3, 3];
            int r1 = matrix1.GetLength(0);
            int c1 = matrix1.GetLength(1);
            int r2 = matrix2.GetLength(0);
            int c2 = matrix2.GetLength(1);
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    matrixMultiplied[i, j] = 0;
                    for (int k = 0; k < c1; k++)
                    {
                        matrixMultiplied[i, j] = matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            Console.WriteLine("Resultant Matrix:");
            for (int i = 0; i < matrixMultiplied.GetLength(0); i++)
            {
                for (int j = 0; j < matrixMultiplied.GetLength(1); j++)
                {
                    Console.Write(matrixMultiplied[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
       
    }
}
