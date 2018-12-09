using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson9_MaximumSliceProblem
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class MaxDoubleSliceSum
    {
        public static int Solution(int[] A)
        {
            int[] maxLeftSums = new int[A.Length];
            int sum = 0;
            for (int i = 1; i < A.Length; i++)
            {
                sum = Math.Max(0, sum + A[i]);
                maxLeftSums[i] = sum;
            }

            int[] maxRightSums = new int[A.Length];
            sum = 0;
            for (int i = A.Length - 2; i >= 0; i--)
            {
                sum = Math.Max(0, sum + A[i]);
                maxRightSums[i] = sum;
            }

            int maxSum = 0;
            for (int i = 1; i <= A.Length - 2; i++)
            {
                maxSum = Math.Max(maxSum, maxLeftSums[i - 1] + maxRightSums[i + 1]);
            }
            return maxSum;
        }
    }
}
