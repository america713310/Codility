using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson10_PrimeAndCompositeNumbers
{
    class CountFactors
    {
        // expected worst-case time complexity is O(sqrt(N))
        // expected worst-case space complexity is O(1)
        public static int Solution(int N)
        {
            int numFactors = 0;

            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i * i != N)
                    {
                        numFactors = numFactors + 2;
                    }
                    else if (i * i == N)
                    {
                        numFactors = numFactors + 1;
                    }
                }
            }
            return numFactors;
        }
    }
}
