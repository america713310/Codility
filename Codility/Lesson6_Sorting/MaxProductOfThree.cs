using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson6_Sorting
{
    // expected worst-case time complexity is O(N* log(N))
    // expected worst-case space complexity is O(1)
    class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            Array.Sort(A);
            return Math.Max(A[0] * A[1] * A[A.Length - 1], A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3]);
        }
    }
}
