using System;
using System.Collections.Generic;
using System.Text;

namespace ZigZagConversion
{
    public class ZigZagConverter
    {
        public string Convert(string inputString, int numRows)
        {
            if (numRows == 1)
            {
                return inputString;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numRows; ++i)
            {
                int rowNumber = i + 1;
                var skip = CalculateCharacterIndexSkip(i, numRows);
                int mirrorRowIndex = CalculateMirrorIndex(i, numRows);
                var skip2 = CalculateCharacterIndexSkip(mirrorRowIndex, numRows);
                bool useSkip1 = true;
                for (int j = i; j < inputString.Length;)
                {
                    sb.Append(inputString[j]);
                    if (useSkip1)
                    {
                        j += skip;
                        useSkip1 = false;
                    }
                    else
                    {
                        j += skip2;
                        useSkip1 = true;
                    }

                }
            }
            return sb.ToString();
        }

        private int CalculateMirrorIndex(int index, int numRows)
        {
            return numRows - index -1;

        }

        private int CalculateCharacterIndexSkip(int currentRow, int numRows)
        {
            if (currentRow == 0 || currentRow == numRows - 1)
            {
                return numRows * 2 - 2;
            }

            var tmp = currentRow % numRows;
            int offset = (numRows * 2 - 2) - (2 * tmp);
            return offset;
        }
    }
}
