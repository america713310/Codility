using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson4_CountingElements
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(X)
    class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            HashSet<int> fallen = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X)
                    fallen.Add(A[i]);

                if (fallen.Count == X)
                    return i;
            }

            return -1;
        }
    }
}
