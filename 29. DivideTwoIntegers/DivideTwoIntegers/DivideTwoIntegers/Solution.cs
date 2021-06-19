using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideTwoIntegers
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if(dividend == int.MinValue)
            {
                if(divisor == -1)
                {
                    return int.MaxValue;
                }
            }

            int resultInternal = DivideInternal(dividend > 0 ? -dividend : dividend, divisor > 0 ? -divisor : divisor);
            if(MustInvertResult(dividend, divisor))
            {
                return -resultInternal;
            }
            return resultInternal;
        }

        private bool MustInvertResult(int dividend, int divisor)
        {
            return (divisor < 0 && dividend > 0) || (divisor > 0 && dividend < 0);
        }

        private int DivideInternal(int dividendNegative, int divisorNegative)
        {
            int numDivisions = 0;
            int remainder = dividendNegative;
            while (remainder <= divisorNegative)
            {
                int nextValToSubtractFromRemainder = divisorNegative;
                int newNumDivisions = 1;
                while(nextValToSubtractFromRemainder << 1 >= remainder && nextValToSubtractFromRemainder << 1 < 0)
                {
                    nextValToSubtractFromRemainder = nextValToSubtractFromRemainder << 1;
                    newNumDivisions = newNumDivisions + newNumDivisions;
                }

                numDivisions += newNumDivisions;
                remainder -= nextValToSubtractFromRemainder;
            }
            return numDivisions;
        }
    }
}
