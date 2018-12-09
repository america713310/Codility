using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson5_PrefixSums
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(1)
    class PassingCars
    {
        public static int Solution(int[] A)
        {
            int zCount = 0;  // how many going east 
            int passing = 0; // total passing pairs

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    passing += zCount;
                }
                else zCount++;
            }

            if (passing > 1e9 || passing < 0) return -1;
            else return passing;
        }
    }
}
