using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson3_TimeComplexity
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int _sum = 0;
            List<int> _list = new List<int>();
            int _first = 0;

            for (int i = 0; i < A.Length; i++)
                _sum += A[i];
            for (int i = 0; i < A.Length - 1; i++)
            {
                _first += A[i];
                _list.Add(Math.Abs(_first + _first - _sum));
            }
            _list.Sort();
            return _list[0];
        }
    }
}
