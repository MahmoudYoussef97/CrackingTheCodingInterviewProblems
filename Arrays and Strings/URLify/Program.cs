using System;

namespace URLify
{
    class Program
    {
        static void URLify(string[] args)
        {
            var str = Console.ReadLine();
            int trueLength = Convert.ToInt32(Console.ReadLine());
            var output = URLify(str, trueLength);
            Console.WriteLine(output);
        }
        private static char[] URLify(string str, int trueLength)
        {
            char[] charArray = new char[str.Length+1];
            for (int i = 0; i < str.Length; ++i) charArray[i] = str[i];
                
            int spaceCount = 0;
            int index = 0;
            for (int i = 0; i < trueLength; ++i)
                if (charArray[i] == ' ') spaceCount++;

            index = trueLength + spaceCount * 2;
            if (trueLength < charArray.Length) charArray[trueLength] = '\0';
            for(int i = trueLength - 1; i >= 0; --i)
            {
                if(charArray[i] == ' ')
                {
                    charArray[index - 1] = '0';
                    charArray[index - 2] = '2';
                    charArray[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    charArray[index - 1] = charArray[i];
                    index--;
                }
            }
            return charArray;
        }
    }
}
