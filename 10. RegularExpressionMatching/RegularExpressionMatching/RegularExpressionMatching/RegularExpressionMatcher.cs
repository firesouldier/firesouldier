using System;

namespace RegularExpressionMatching
{
    public class RegularExpressionMatcher
    {
        bool?[,] _dpMemo;
        public bool IsMatch(string input, string pattern)
        {
            //return IsMatchDynamicProgramming(input, pattern);
            return IsMatchNonDynamicProgrammingWithoutSubstrings(0, 0, input, pattern);
        }

        

        public bool IsMatchDynamicProgramming(string input, string pattern)
        {
            
            _dpMemo = new bool?[input.Length + 1, pattern.Length + 1];
            for (int i = 0; i < input.Length + 1; ++i)
            {
                for (int j = 0; j < pattern.Length + 1; ++j)
                {
                    _dpMemo[i, j] = null;
                }
            }
            return ApplyDynamicProgramming(0, 0, input, pattern);
        }

        public bool ApplyDynamicProgramming(int inputIndex, int patternIndex, string input, string pattern)
        {
            if (_dpMemo[inputIndex, patternIndex] != null)
            {
                return _dpMemo[inputIndex, patternIndex] == true;
            }
            bool isMatch = false;
            if (patternIndex == pattern.Length)
            {
                isMatch = inputIndex == input.Length;
            }
            else
            {
                bool charMatched = inputIndex < input.Length && (input[inputIndex] == pattern[patternIndex] || pattern[patternIndex] == '.');

                if (pattern.Length > patternIndex + 1 && pattern[patternIndex + 1] == '*')
                {
                    isMatch = ApplyDynamicProgramming(inputIndex, patternIndex + 2, input, pattern) || (charMatched && ApplyDynamicProgramming(inputIndex + 1, patternIndex, input, pattern));
                }
                else
                {
                    isMatch = charMatched && ApplyDynamicProgramming(inputIndex + 1, patternIndex + 1, input, pattern);
                }
            }

            _dpMemo[inputIndex, patternIndex] = isMatch;
            return isMatch;
        }

        public bool IsMatchNonDynamicProgramming(string input, string pattern)
        {
            if (pattern.Length == 0)
            {
                return input.Length == 0;
            }

            bool charMatched = input.Length > 0 && (input[0] == pattern[0] || pattern[0] == '.');

            if (pattern.Length > 1 && pattern[1] == '*')
            {
                return IsMatch(input, pattern.Substring(2)) || (charMatched && IsMatch(input.Substring(1), pattern));
            }
            else
            {
                return charMatched && IsMatch(input.Substring(1), pattern.Substring(1));
            }
        }

        private bool IsMatchNonDynamicProgrammingWithoutSubstrings(int inputIndex, int patternIndex, string input, string pattern)
        {
            if (patternIndex == pattern.Length)
            {
                return inputIndex == input.Length;
            }

            bool charMatched = inputIndex < input.Length && (input[inputIndex] == pattern[patternIndex] || pattern[patternIndex] == '.');

            if (patternIndex + 1 < pattern.Length && pattern[patternIndex + 1] == '*')
            {
                return IsMatchNonDynamicProgrammingWithoutSubstrings(inputIndex, patternIndex + 2, input, pattern) || (charMatched && IsMatchNonDynamicProgrammingWithoutSubstrings(inputIndex + 1, patternIndex, input, pattern));
            }
            else
            {
                return charMatched && IsMatchNonDynamicProgrammingWithoutSubstrings(inputIndex + 1, patternIndex + 1, input, pattern);
            }
        }
    }
}