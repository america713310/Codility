using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson6_Sorting
{
    // expected worst-case time complexity is O(N* log(N))
    // expected worst-case space complexity is O(N)
    class Distinct
    {
        public static int Solution(int[] A)
        {
            int count = 1;

            Array.Sort(A);
            if (A.Length == 0)
            {
                return 0;
            }
            if (A.Length == 1)
            {
                return 1;
            }
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] != A[i + 1])
                    count++;
            }
            return count;
        }
    }
}
