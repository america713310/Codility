using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson2_Arrays
{
    class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            int[] _array = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                _array[i] = A[(A.Length - (K % A.Length) + i) % A.Length];
            }
            return _array;
        }
    }
}
