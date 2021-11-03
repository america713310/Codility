using System;

namespace Codility.Lesson1_Iterations
{
    // expected worst-case time complexity is O(log(N))
    // expected worst-case space complexity is O(1)
    class BinaryGap
    {
        public static int Solution(int N)
        {
            string binary = Convert.ToString(N, 2);

            int _max = 0;
            int _count = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                    _max++;
                else
                {
                    if (_count < _max)
                        _count = _max;

                    _max = 0;
                }
            }

            return _count;
        }
    }
}
