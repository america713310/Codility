using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson12_EuclideanAlgorithm
{
    class ChocolatesByNumbers
    {
        // expected worst-case time complexity is O(log(N+M))
        // expected worst-case space complexity is O(log(N+M))
        public static int Solution(int N, int M)
        {
            HashSet<int> _hash = new HashSet<int>();
            int i = 0;

            while(true)
            {
                if (i >= N)
                    i = i % N;
                if (_hash.Contains(i))
                    break;
                _hash.Add(i);
                i += M;
            }
            return _hash.Count;
        }
    }
}
