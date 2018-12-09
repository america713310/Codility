using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson2_Arrays
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(1)
    class OddOccurrencesInArray
    {
        public static int Solution(int[] A)
        {
            int _answer = 0;

            for (int i = 0; i < A.Length; i++)
                _answer = _answer ^ A[i];
            return _answer;
        }
    }
}
