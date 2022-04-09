using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.StaticClasses.Utils
{
    public static class StringUtils
    {
        public static string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            char firstLetter = text[0];
            string capitalisedLetter = firstLetter.ToString().ToUpper();

            if (text.Length == 1)
            {
                return capitalisedLetter;
            }

            return $"{capitalisedLetter}{text.Substring(1)}.";

        }

        public static int VerifyStringNumber(string input)
        {
            int result = 0;

            bool isParsed = int.TryParse(input, out result);

            if (isParsed)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
