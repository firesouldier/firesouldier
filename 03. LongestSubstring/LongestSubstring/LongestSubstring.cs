using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubstring
{
    public class GetLongestSubstring
    {
        public int LengthOfLongestSubstring(string inputString)
        {
            var charsInCurrentString = GetNewHashSet();

            int lengthOfLongestStringSoFar = 0;
            foreach (var character in inputString)
            {
                if (charsInCurrentString.Contains(character))
                {
                    lengthOfLongestStringSoFar = PotentiallyUpdateLongestStringLength(charsInCurrentString, lengthOfLongestStringSoFar);
                    charsInCurrentString = GetNewHashSet();
                }
                charsInCurrentString.Add(character);
            }

            lengthOfLongestStringSoFar = PotentiallyUpdateLongestStringLength(charsInCurrentString, lengthOfLongestStringSoFar);


            return lengthOfLongestStringSoFar;
        }

        private int PotentiallyUpdateLongestStringLength(HashSet<char> currentSet, int lengthOfLongestStringSoFar)
        {
            if (currentSet.Count > lengthOfLongestStringSoFar)
            {
                return currentSet.Count;
            }
            return lengthOfLongestStringSoFar;
        }

        private HashSet<char> GetNewHashSet()
        {
            return new HashSet<char>();
        }
    }
}
