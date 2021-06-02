using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterfataUtilizator_WindowsForms
{
    static class Functii
    {
        public static bool OnlyDigits(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static bool OnlyLetters(string s)
        {
            return Regex.IsMatch(s, @"^[\p{L}]+$");
        }

        public static bool IsFloatNumber(string s)
        {
            return float.TryParse(s, out _);
        }

        public static bool IsIntNumber(string s)
        {
            return int.TryParse(s, out _);
        }
    }
}
