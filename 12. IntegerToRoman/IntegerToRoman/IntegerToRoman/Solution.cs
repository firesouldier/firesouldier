using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegerToRoman
{
    public class Solution
    {
        private class RomanNumeral
        {
            public RomanNumeral(int value, string symbol)
            {
                Value = value;
                Symbol = symbol;
            }

            public int Value { get; }
            public string Symbol { get; }
        }


        private RomanNumeral[] Numerals = new RomanNumeral[]
        {
            new RomanNumeral(1000, "M"),
            new RomanNumeral(900, "CM"),
            new RomanNumeral(500, "D"),
            new RomanNumeral(400, "CD"),
            new RomanNumeral(100, "C"),
            new RomanNumeral(90, "XC"),
            new RomanNumeral(50, "L"),
            new RomanNumeral(40, "XL"),
            new RomanNumeral(10, "X"),
            new RomanNumeral(9, "IX"),
            new RomanNumeral(5, "V"),
            new RomanNumeral(4, "IV"),
            new RomanNumeral(1, "I"),
        };

        public string IntToRoman(int num)
        {
            //return VerboseSolution(num);
            return PrivateClassSolution(num);
        }


        private string PrivateClassSolution(int num)
        {
            string output = string.Empty;
            for(int i = 0; i < Numerals.Length; ++i)
            {
                int numCharacters = num / Numerals[i].Value;
                if(numCharacters > 0)
                {
                    output += string.Join(string.Empty, Enumerable.Repeat(Numerals[i].Symbol, numCharacters));
                    num %= Numerals[i].Value;
                }
            }
            return output;
        }

        private string VerboseSolution(int num)
        {
            string output = string.Empty;
            while (num > 0)
            {
                output += ConstructPart(num, out int remainder);
                num = remainder;
            }
            return output;
        }

        private string ConstructPart(int number, out int remainder)
        {
            if (number >= 900)
            {
                remainder = number % 1000;
                if (remainder >= 900)
                {
                    remainder %= 900;
                    return string.Join(string.Empty, Enumerable.Repeat("M", number / 1000)) + "CM";
                }
                return string.Join(string.Empty, Enumerable.Repeat("M", number / 1000));
            }
            else if (number >= 400)
            {
                remainder = number % 500;
                if (remainder >= 400)
                {
                    remainder %= 400;
                    return string.Join(string.Empty, Enumerable.Repeat("D", number / 500)) + "CD";
                }
                return string.Join(string.Empty, Enumerable.Repeat("D", number / 500));
            }
            else if (number >= 90)
            {
                remainder = number % 100;
                if (remainder >= 90)
                {
                    remainder %= 90;
                    return string.Join(string.Empty, Enumerable.Repeat("C", number / 100)) + "XC";
                }
                return string.Join(string.Empty, Enumerable.Repeat("C", number / 100));
            }
            else if (number >= 40)
            {
                remainder = number % 50;
                if (remainder >= 40)
                {
                    remainder %= 40;
                    return string.Join(string.Empty, Enumerable.Repeat("L", number / 50)) + "XL";
                }
                return string.Join(string.Empty, Enumerable.Repeat("L", number / 50));
            }
            else if (number >= 9)
            {
                remainder = number % 10;
                if (number == 9)
                {
                    return ConstructPart(1, out remainder) + "X";
                }
                return string.Join(string.Empty, Enumerable.Repeat("X", number / 10));
            }
            else if (number >= 4)
            {
                remainder = number % 5;
                if (number == 4)
                {
                    return ConstructPart(1, out remainder) + "V";
                }
                return string.Join(string.Empty, Enumerable.Repeat("V", number / 5));
            }
            else if (number >= 1)
            {
                remainder = 0;
                return string.Join(string.Empty, Enumerable.Repeat("I", number));
            }
            remainder = number;
            return string.Empty;
        }
    }
}