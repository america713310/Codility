using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson5_PrefixSums
{
    // expected worst-case time complexity is O(N+M)
    // expected worst-case space complexity is O(N)
    class GenomicRangeQuery
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            string[] _array = new string[P.Length];
            int[] _answers = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                _array[i] = S.Substring(P[i], Q[i] - P[i] + 1);
            }
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Contains("A"))
                    _answers[i] = 1;
                else if (_array[i].Contains("C"))
                    _answers[i] = 2;
                else if (_array[i].Contains("G"))
                    _answers[i] = 3;
                else if (_array[i].Contains("T"))
                    _answers[i] = 4;
            }
            return _answers;
        }
    }
}
