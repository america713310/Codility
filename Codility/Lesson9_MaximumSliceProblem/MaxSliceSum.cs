using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson9_MaximumSliceProblem
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class MaxSliceSum
    {
        public static int Solution(int[] A)
        {
            int max_ending = A[0];
            int max_slice = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (max_ending < 0)
                {
                    max_ending = A[i];
                }
                else
                {
                    max_ending = max_ending + A[i];
                }
                if (max_ending > max_slice)
                {
                    max_slice = max_ending;
                }
            }

            return max_slice;
        }
    }
}
