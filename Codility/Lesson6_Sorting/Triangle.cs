using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson6_Sorting
{
    // expected worst-case time complexity is O(N* log(N))
    // expected worst-case space complexity is O(N)
    class Triangle
    {
        public static int Solution(int[] A)
        {
            Array.Sort(A);
            for (int i = 1; i < A.Length - 1; i++)
            {
                if ((long)A[i - 1] + (long)A[i] > (long)A[i + 1])
                    return 1;
            }
            return 0;
        }
    }
}
