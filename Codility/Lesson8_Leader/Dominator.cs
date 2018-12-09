using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility.Lesson8_Leader
{
    class Dominator
    {
        // expected worst-case time complexity is O(N)
        // expected worst-case space complexity is O(1)
        public static int Solution(int[] A)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            if (A.Length == 1)
                return 0;
            int _count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (map.ContainsKey(A[i]))
                {
                    if (map[A[i]] >= A.Length / 2)
                    {
                        return i;
                    }
                    else
                    {
                        _count = map[A[i]];
                        map.Remove(A[i]);
                        map.Add(A[i], _count + 1);
                    }
                }
                else
                {
                    map.Add(A[i], 1);
                }
            }
            return -1;
        }
    }
}
