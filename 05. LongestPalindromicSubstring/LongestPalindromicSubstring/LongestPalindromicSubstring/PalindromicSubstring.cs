using System;
using System.Collections.Generic;

namespace LongestPalindromicSubstring
{
    public class PalindromicSubstring
    {
        private Dictionary<char, List<int>> _indicesToCheck = new Dictionary<char, List<int>>();
        public string LongestPalindrome(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                return inputString;
            }

            int start = 0;
            int end = 0;
            for (int i = 0; i < inputString.Length; ++i)
            {
                int palindromeLength = LongestPalindromeFromIndex(inputString, i, i);
                int palindromeLength2 = LongestPalindromeFromIndex(inputString, i, i + 1);
                int actualLength = Math.Max(palindromeLength, palindromeLength2);

                if (actualLength > end - start)
                {
                    start = i - (actualLength - 1) / 2;
                    end = i + actualLength / 2;
                }
            }

            return inputString.Substring(start, end - start + 1);
        }

        private int LongestPalindromeFromIndex(string input, int left, int right)
        {
            while (left >= 0 && right < input.Length && input[left] == input[right])
            {
                --left;
                ++right;
            }
            return right - left - 1;
        }


        public string OriginalSolution(string inputString)
        {
            int longestPalindromeStartIndex = -1;
            int longestPalindromeEndIndex = -1;

            _indicesToCheck.Clear();

            for (int i = 0; i < inputString.Length; ++i)
            {
                if (_indicesToCheck.TryGetValue(inputString[i], out var result))
                {
                    for (int j = 0; j < result.Count; ++j)
                    {
                        if (i - result[j] <= longestPalindromeEndIndex - longestPalindromeStartIndex)
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
                    if (_indicesToCheck.Count == 0)
                    {
                        longestPalindromeStartIndex = i;
                        longestPalindromeEndIndex = i;
                    }
                    _indicesToCheck.Add(inputString[i], new List<int>(10) { i });
                }
            }
            return inputString.Substring(longestPalindromeStartIndex, longestPalindromeEndIndex - longestPalindromeStartIndex + 1); ;
        }

        private bool IsPalindrome(string s, int startIndex, int endIndex)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            do
            {
                if (!s[startIndex].Equals(s[endIndex]))
                {
                    return false;
                }
            } while (++startIndex < --endIndex);
            return true;
        }
    }
}
