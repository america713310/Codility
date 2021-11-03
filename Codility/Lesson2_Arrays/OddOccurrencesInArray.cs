namespace Codility.Lesson2_Arrays
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(1)
    class OddOccurrencesInArray
    {
        public static int Solution(int[] A)
        {
            int _num = 0;

            for (int i = 0; i < A.Length; i++)
                _num ^= A[i];

            return _num;
        }
    }
}
