using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static string DeleteClassCharacter(this string text)
        {
            return text.Substring(0, text.Length - 1);
        }

        public static string DeleteClassCharacterClassic(string text)
        {
            return text.Substring(0, text.Length - 1);
        }

        public static string AddQuotations(this string textToQuote)
        {
            return @$"""{textToQuote}""";
        }
    }
}
