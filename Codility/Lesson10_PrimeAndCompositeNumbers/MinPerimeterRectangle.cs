using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson10_PrimeAndCompositeNumbers
{
    // expected worst-case time complexity is O(sqrt(N))
    // expected worst-case space complexity is O(1)
    class MinPerimeterRectangle
    {
        public static int Solution(int N)
        {
            int minPerimeter = int.MaxValue;

            for (int i = 1; i * i <= N; i++)
                if (N % i == 0)
                    minPerimeter = Math.Min(2 * (i + N / i), minPerimeter);

            return minPerimeter;
        }
    }
}
