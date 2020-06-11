using System;
using System.Text;

namespace String_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            foreach (var ch in input)
                str.Append(ch);
            var output = CompressString(str);
            Console.WriteLine(output);
        }
        private static StringBuilder CompressString(StringBuilder input)
        {
            int finalLength = CompressionLength(input);
            if (finalLength > input.Length) return input;

            StringBuilder stringCompressed = CompressStringOf(input);
            return stringCompressed;
        }
        private static int CompressionLength(StringBuilder input)
        {
            StringBuilder finalString = CompressStringOf(input);
            return finalString.Length;
        }
        private static StringBuilder CompressStringOf(StringBuilder input)
        {
            StringBuilder str = new StringBuilder();
            int countCompression = 1;
            for (int i = 0; i < input.Length; ++i)
            {   
                if(i+1 < input.Length)
                {
                    if (input[i + 1] == input[i])
                    {
                        countCompression++;
                        continue;
                    }
                }
                str.Append(input[i]);
                str.Append(countCompression);
                countCompression = 1;
            }
            return str;
        }
    }
}
