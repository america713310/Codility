using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson12_EuclideanAlgorithm
{
    // expected worst-case time complexity is O(Z* log(max(A)+max(B))2)
    // expected worst-case space complexity is O(1)
    class CommonPrimeDivisors
    {
        public static int Solution(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 2; j < A[i]; j++)
                {
                    if (A[i] % 2 == 0)
                }
            }
        }
    }
}
