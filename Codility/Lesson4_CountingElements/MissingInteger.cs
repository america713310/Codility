using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson4_CountingElements
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class MissingInteger
    {
        public static int Solution(int[] A)
        {
            HashSet<int> _hashSet = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                    _hashSet.Add(A[i]);
            }
            for (int i = 1; i < Int32.MaxValue; i++)
            {
                if (!_hashSet.Contains(i))
                    return i;
            }
            return 1;
        }
    }
}
