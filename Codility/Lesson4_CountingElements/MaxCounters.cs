using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson4_CountingElements
{
    // expected worst-case time complexity is O(N+M)
    // expected worst-case space complexity is O(N)
    class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            int max = 0;
            int lastMax = 0;
            int[] counters = new int[N];

            for (int k = 0; k < A.Length; k++)
            {
                if (A[k] >= 1 && A[k] <= N)
                {
                    counters[A[k] - 1] = Math.Max(counters[A[k] - 1], lastMax);
                    counters[A[k] - 1] += 1;
                    max = Math.Max(max, counters[A[k] - 1]);
                }
                else if (A[k] == N + 1)
                {
                    lastMax = max;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], lastMax);
            }

            return counters;
        }
    }
}
