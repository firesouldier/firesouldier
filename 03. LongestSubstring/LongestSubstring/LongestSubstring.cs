using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubstring
{
    public class GetLongestSubstring
    {
        public int LengthOfLongestSubstring(string inputString)
        {
            var charsInCurrentString = new Dictionary<char, int>();

            int lengthOfLongestStringSoFar = 0;
            for (int i = 0; i < inputString.Length; ++i)
            {
                if (charsInCurrentString.TryGetValue(inputString[i], out int indexOfChar))
                {
                    lengthOfLongestStringSoFar = PotentiallyUpdateLongestStringLength(charsInCurrentString, lengthOfLongestStringSoFar);
                    charsInCurrentString.Clear();
                    i = indexOfChar+1;
                    charsInCurrentString.Add(inputString[i], i);
                }
                else
                {
                    charsInCurrentString.Add(inputString[i], i);
                }
                
            }

            lengthOfLongestStringSoFar = PotentiallyUpdateLongestStringLength(charsInCurrentString, lengthOfLongestStringSoFar);


            return lengthOfLongestStringSoFar;
        }

        private int PotentiallyUpdateLongestStringLength(Dictionary<char, int> currentDict, int lengthOfLongestStringSoFar)
        {
            if (currentDict.Count > lengthOfLongestStringSoFar)
            {
                return currentDict.Count;
            }
            return lengthOfLongestStringSoFar;
        }
    }
}
