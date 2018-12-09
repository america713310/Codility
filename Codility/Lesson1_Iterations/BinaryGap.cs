using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson1_Iterations
{
    // expected worst-case time complexity is O(log(N))
    // expected worst-case space complexity is O(1)
    class BinaryGap
    {
        public static int Solution(int N)
        {
            int _count = 0;
            List<int> _list = new List<int>();

            string _binary = Convert.ToString(N, 2);
            for (int i = 0; i < _binary.Length; i++)
            {
                if (_binary[i] == '0')
                    _count++;
                else
                {
                    _list.Add(_count);
                    _count = 0;
                }
            }
            _list.Sort();
            return _list[_list.Count - 1];
        }
    }
}
