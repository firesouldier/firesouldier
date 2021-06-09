using System;
using System.Collections.Generic;
using System.Text;

namespace LongestPalindromicSubstring
{
    public class PalindromicSubstring
    {
        public string LongestPalindrome(string inputString)
        {
            int longestPalindromeStartIndex = -1;
            int longestPalindromeEndIndex = -1;
            var indicesToCheck = new Dictionary<char, List<int>>();
            for (int i = 0; i < inputString.Length; ++i)
            {
                if (indicesToCheck.TryGetValue(inputString[i], out var result))
                {
                    for(int j = 0; j < result.Count; ++j)
                    {
                        if(i - result[j] <= longestPalindromeEndIndex - longestPalindromeStartIndex)
                        {
                            break;
                        }
                        if (IsPalindrome(inputString, result[j], i))
                        {
                            longestPalindromeStartIndex = result[j];
                            longestPalindromeEndIndex = i;
                            break;
                        }
                    }
                    result.Add(i);
                }
                else
                {
                    if(indicesToCheck.Count == 0)
                    {
                        longestPalindromeStartIndex = i;
                        longestPalindromeEndIndex = i;
                    }
                    indicesToCheck.Add(inputString[i], new List<int>(10) { i });
                }
            }
            return inputString.Substring(longestPalindromeStartIndex, longestPalindromeEndIndex - longestPalindromeStartIndex + 1); ;
        }

        private bool IsPalindrome(string s, int startIndex, int endIndex)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            while(startIndex < endIndex)
            {
                if(!s[startIndex].Equals(s[endIndex]))
                {
                    return false;
                }
                ++startIndex;
                --endIndex;
            }
            return true;
        }
    }
}
