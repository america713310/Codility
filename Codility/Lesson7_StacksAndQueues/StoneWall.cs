using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson7_StacksAndQueues
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class StoneWall
    {
        public static int Solution(int[] H)
        {
            Stack<int> st = new Stack<int>();
            int numBlock = 0;

            for (int i = 0; i < H.Length; i++)
            {
                while (st.Count != 0 && st.Peek() > H[i])
                {
                    st.Pop();
                }
                if (st.Count == 0)
                {
                    numBlock++;     
                    st.Push(H[i]);  
                }
                else if (st.Peek() == H[i])
                {
                }
                else if (st.Peek() < H[i])
                {
                    numBlock++;    
                    st.Push(H[i]);
                }
            }
            return numBlock;
        }
    }
}
