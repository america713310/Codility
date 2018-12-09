using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson8_Leader
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class EquiLeader
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 1)
                return 0;
            int value = A[0];
            int size = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (size == 0)
                {
                    size++;
                    value = A[i];
                }
                else
                {
                    if (A[i] == value)
                        size++;
                    else
                        size--;
                }
            }
            int candidate = -1;
            int count = 0;
            if (size > 0)
                candidate = value;
            for (int i = 0; i < A.Length; i++)
                if (A[i] == candidate)
                    count++;

            if (count <= A.Length / 2)
                return 0;

            int leader = candidate;
            int equiCount = 0;
            int leaderCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                    leaderCount++;
                if (leaderCount > (i + 1) / 2 && (count - leaderCount) > (A.Length - i - 1) / 2)
                    equiCount++;
            }
            return equiCount;
        }
    }
}
