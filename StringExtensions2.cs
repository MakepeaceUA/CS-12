using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class StringExtensions2
    {
        public static int CountWords(this string text)
        {
            int count = 0;
            int start = -1;

            if (text == null || text == "")
            {
                return 0;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (start == -1)
                    {
                        start = i;
                    }
                      
                }
                else
                {
                    if (start != -1)
                    {
                        char FLetter = char.ToLower(text[start]);
                        char LLetter = char.ToLower(text[i - 1]);

                        if (FLetter == LLetter)
                        { 
                            count++; 
                        }
                          
                        start = -1;
                    }
                }
            }
            return count;
        }
    }
}
