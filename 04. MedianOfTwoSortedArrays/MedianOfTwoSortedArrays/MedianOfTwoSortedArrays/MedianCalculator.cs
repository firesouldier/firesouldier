using System;

namespace MedianOfTwoSortedArrays
{
    public class MedianCalculator
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] shortArray = nums1.Length > nums2.Length ? nums2 : nums1;
            int[] longArray = nums1.Length > nums2.Length ? nums1 : nums2;
            return ComputeMedian(shortArray, longArray);
        }

        private double ComputeMedian(int[] arrayA, int[] arrayB)
        {
            int total = arrayA.Length + arrayB.Length;
            int halfNumElements = total / 2;

            int leftIndex = 0;
            int rightIndex = arrayA.Length - 1;

            while (true)
            {
                int midPointIndexA = (int)Math.Floor((leftIndex + rightIndex)/2.0);
                int midPointB = halfNumElements - midPointIndexA - 2;

                int Aleft = GetValueForIndex(arrayA, midPointIndexA);
                int Aright = GetValueForIndex(arrayA, midPointIndexA+1); 

                int Bleft = GetValueForIndex(arrayB, midPointB);
                int Bright = GetValueForIndex(arrayB, midPointB + 1);

                if(Aleft <= Bright && Bleft <= Aright)
                {
                    if(total % 2 == 1)
                    {
                        return Math.Min(Aright, Bright);
                    }
                    return (Math.Max(Aleft, Bleft) + Math.Min(Aright, Bright)) / 2.0;
                }
                else if(Aleft > Bright)
                {
                    rightIndex = midPointIndexA - 1;
                }
                else
                {
                    leftIndex = midPointIndexA + 1;
                }
            }
        }

        private int GetValueForIndex(int[] array, int index)
        {
            if(index >= array.Length)
            {
                return int.MaxValue;
            }

            if (index < 0)
            {
                return int.MinValue;
            }
            return array[index];
        }

    }
}
