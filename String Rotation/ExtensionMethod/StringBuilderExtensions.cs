using System;
using System.Collections.Generic;
using System.Text;

namespace String_Rotation.ExtensionMethod
{
    public static class StringBuilderExtensions
    {
        public static bool IsSubstring(this StringBuilder source, string stringToCompare)
        {
            int length = 0;
            int index = 0;
            for(int i=0;i<source.Length;++i)
            {   
                if(i < source.Length && index < stringToCompare.Length)
                {
                    while (source[i] == stringToCompare[index])
                    {
                        length++;
                        index++;
                        i++;
                        if (i >= source.Length || index >= stringToCompare.Length) break;
                    } 
                }
            }
            return length == stringToCompare.Length;
        }
    }
}
