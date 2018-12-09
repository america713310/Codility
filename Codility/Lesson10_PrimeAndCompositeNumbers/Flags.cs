using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson10_PrimeAndCompositeNumbers
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class Flags
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 1) return 0;
            ArrayList al = new ArrayList();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    al.Add(i);
                }
            }
            int s = al.Count;
            if (s == 1) return 1;
            if (s == 0) return 0;
            s = (int)Math.Ceiling(Math.Sqrt(A.Length));
            while (s >= 0)
            {
                int lp = (int)al[0];
                int c = 1;
                for (int i = 1; i < al.Count; i++)
                {
                    int d = Math.Abs((int)al[i] - lp);
                    if (d >= s)
                    {
                        lp = (int)al[i];
                        c++;
                        if (c == s)
                            return c;
                    }
                }
                s--;
            }
            return 0;
        }
    }
}
