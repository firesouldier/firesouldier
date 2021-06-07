using Functional.Maybe;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    public class TwoSumCalculator
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //var result = CalculateByBruteForce(nums, target);
            var result = CalculateOptimised(nums, target);
            if (result.IsNothing())
            {
                throw new InvalidOperationException($"No two numbers could be found which add up to {target}");
            }
            return result.Value;
        }

        private Maybe<int[]> CalculateOptimised(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (dict.TryGetValue(target - nums[i], out int firstIndex))
                {
                    return GenerateResult(firstIndex, i);
                }

                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                
            }
            return Maybe<int[]>.Nothing;
        }


        private Maybe<int[]> CalculateByBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = 1; j < nums.Length; ++j)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return GenerateResult(i, j);
                    }
                }
            }
            return Maybe<int[]>.Nothing;
        }

        private Maybe<int[]> GenerateResult(int firstIndex, int secondIndex)
        {
            return new int[] { firstIndex, secondIndex }.ToMaybe();
        }
    }
}
