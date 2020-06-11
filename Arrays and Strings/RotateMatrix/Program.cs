using System;

namespace RotateMatrix
{
    class Program
    {
        static void RotateMatrix(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[4,4] { { 1, 2, 3, 4},
                                           { 5, 6, 7, 8},
                                           { 9, 10, 11, 12},
                                           { 13, 14, 15, 16 } };
            RotateMatrix(matrix, N);
            for(int i=0;i<4;++i)
                for(int j=0;j<4;++j)
                    Console.WriteLine(matrix[i,j]);
        }
        private static void RotateMatrix(int[,] matrix, int N)
        {
            int layers = N / 2;
            for(int layer = 0; layer < N / 2; ++layer) // outer layer
            {
                int first = layer;
                int last = N - 1 - layer;
                for(int i = first; i<last; ++i)
                {
                    int index = i - first;
                    int top = matrix[first,i];
                    matrix[first, i] = matrix[last - index, first]; // left --> top
                    matrix[last - index, first] = matrix[last, last - index]; // bottom --> left
                    matrix[last, last - index] = matrix[i, last]; // right --> bottom
                    matrix[i, last] = top; // top --> right
                }
            }
        }
    }
}
