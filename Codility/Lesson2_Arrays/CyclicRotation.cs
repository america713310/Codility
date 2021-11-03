namespace Codility.Lesson2_Arrays
{
    class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            if (A.Length == 0)
                return new int[0];

            K = K % A.Length;

            int[] _array = new int[A.Length];

            for (int i = 0; i < K; i++)
                _array[i] = A[A.Length - K + i];

            for (int i = 0; i < A.Length - K; i++)
                _array[i + K] = A[i];

            return _array;
        }
    }
}
