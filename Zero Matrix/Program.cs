using System;
using System.Collections.Generic;

namespace Zero_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4] { { 1, 2, 0, 4},
                                           { 5, 0, 7, 8},
                                           { 9, 10, 0, 12},
                                           { 13, 14, 15, 16 } };
            ZeroMatrix(matrix, 4);
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    Console.Write($"{matrix[i, j]}    ");
                }
                Console.WriteLine("");
            }
        }

        private static void ZeroMatrix(int[,] matrix, int N)
        {
            List<KeyValuePair<int, int>> zeroIndeces = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                    if (matrix[i, j] == 0)
                        zeroIndeces.Add(new KeyValuePair<int, int>(i, j));

            foreach (var item in zeroIndeces)
            {
                ZeroRows(matrix, N, item.Key);
                ZeroColumn(matrix, N, item.Value);
            }
        }

        private static void ZeroColumn(int[,] matrix, int N, int value)
        {
            for (int i = 0; i < N; ++i)
                matrix[i, value] = 0;
        }

        private static void ZeroRows(int[,] matrix, int N, int key)
        {
            for (int i = 0; i < N; ++i)
                matrix[key, i] = 0;
        }
    }
}
