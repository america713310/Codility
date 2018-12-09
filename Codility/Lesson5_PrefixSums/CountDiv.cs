using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson5_PrefixSums
{
    // expected worst-case time complexity is O(1)
    // expected worst-case space complexity is O(1)
    class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            return (B / K) - (A / K) + (A % K == 0 ? 1 : 0);
        }
    }
}
