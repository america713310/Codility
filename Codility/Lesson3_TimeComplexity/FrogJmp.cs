using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson3_TimeComplexity
{
    // expected worst-case time complexity is O(1)
    // expected worst-case space complexity is O(1)
    class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            if ((Y - X) % D == 0)
                return (Y - X) / D;
            else return (Y - X) / D + 1;
        }
    }
}
