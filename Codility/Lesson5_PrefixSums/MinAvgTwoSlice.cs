using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson5_PrefixSums
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {
            int minIndex = 0;
            double minAvg = double.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                double average = (A[i] + A[i + 1]) / 2.0;

                if (i < A.Length - 2)
                {
                    double threeSliceAvg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    average = Math.Min(average, threeSliceAvg);
                }
                if (average < minAvg)
                {
                    minAvg = average;
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
