namespace Codility.Lesson3_TimeComplexity
{
    // expected worst-case time complexity is O(N);
    // expected worst-case space complexity is O(1), beyond
    class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            long N = A.Length + 1;
            long _sum = N * (N + 1) / 2;

            for (int i = 0; i < A.Length; i++)
                _sum -= A[i];

            return (int)_sum;
        }
    }
}
