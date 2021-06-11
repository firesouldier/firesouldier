using System;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            return FromLeetCode(x);
        }

        public int FromLeetCode(int x)
        {
            int reversed = 0;
            while (x != 0)
            {
                int currentDigit = x % 10;
                x /= 10;

                if(WillOverflow2(10, currentDigit, reversed))
                {
                    return 0;
                }
                reversed = reversed * 10 + currentDigit;

            }

            return reversed;
        }

        private bool WillOverflow2(int currentMultiplier, int currentDigit, int totalSoFar)
        {
            if (currentMultiplier == 0) return false;

            if (totalSoFar > int.MaxValue/10 || (totalSoFar == int.MaxValue/10 && currentDigit > 7))
            {
                return true;
            }

            if (totalSoFar < int.MinValue / 10 || (totalSoFar == int.MinValue / 10 && currentDigit < -8))
            {
                return true;
            }
            return false;
        }



        private int UsingStrings(int x)
        {
            string xAsString = x.ToString();
            bool isNegative = string.Equals(xAsString[0], '-');

            int currentMultiplier = (int)Math.Pow(10, xAsString.Length - 1 - (isNegative ? 1 : 0));
            int totalValue = 0;
            for (int i = xAsString.Length - 1; i >= (isNegative ? 1 : 0); --i)
            {
                var currentDigit = (int)char.GetNumericValue(xAsString[i]);
                int delta = currentMultiplier * currentDigit;
                if (WillOverflow(currentMultiplier, currentDigit, delta, int.MaxValue - totalValue))
                {
                    return 0;
                }

                totalValue += delta;
                currentMultiplier /= 10;
            }
            return totalValue * (isNegative ? -1 : 1);
        }


        private bool WillOverflow(int currentMultiplier, int currentDigit, int delta, int remaining)
        {
            if (currentMultiplier == 0) return false;

            var maximumDigit = remaining / currentMultiplier;
            if (currentDigit > maximumDigit)
            {
                return true;
            }
            return delta > remaining;
        }
    }
}