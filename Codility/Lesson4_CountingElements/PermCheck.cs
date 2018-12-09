using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson4_CountingElements
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class PermCheck
    {
        public static int Solution(int[] A)
        {
            bool[] seen = new bool[A.Length + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 1 || A[i] > A.Length) return 0;
                if (seen[A[i]] == true) return 0;
                else seen[A[i]] = true;
            }

            return 1;
        }
    }
}
