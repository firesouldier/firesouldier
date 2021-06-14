using System;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            return MaxAreaOptimised(height);
        }

        public int MaxAreaBruteForce(int[] height)
        {
            int maxArea = -1;
            for (int i = 0; i < height.Length; ++i)
            {
                for (int j = 1; j < height.Length; ++j)
                {
                    int area = CalcArea(i, j, height);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
            return maxArea;
        }

        private int CalcArea(int s, int e, int[] height)
        {
            return Math.Min(height[s], height[e]) * (e - s);
        }

        public int MaxAreaOptimised(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;
            int maxArea = CalcArea(start, end, height);

            while(start < end)
            {
                if(height[end] < height[start])
                {
                    --end;
                }
                else 
                {
                    ++start;
                }
                
                int area = CalcArea(start, end, height);
                if (area > maxArea)
                {
                    maxArea = area;
                }
            }
            return maxArea;
        }
    }
}