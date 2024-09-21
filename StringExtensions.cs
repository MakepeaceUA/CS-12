using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class StringExtensions
    {
        public static int CountSentences(this string text)
        {
            if (text == null || text == "")
                return 0;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char str = text[i];
                if (str == '.' || str == '!' || str == '?')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
