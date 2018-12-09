using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson9_MaximumSliceProblem
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(1)
    class MaxProfit
    {
        public static int Solution(int[] A)
        {
            if (A.Length < 2)
                return 0;
            int buy = A[0];
            int profit = 0;
            for (int i = 1; i < A.Length; i++)
            {
                int value = A[i];
                profit = Math.Max(profit, value - buy);
                buy = Math.Min(buy, value);
            }
            return profit;
        }
    }
}
