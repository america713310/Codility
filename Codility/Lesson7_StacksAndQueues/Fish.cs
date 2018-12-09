using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson7_StacksAndQueues
{
    class Fish
    {
        // expected worst-case time complexity is O(N)
        // expected worst-case space complexity is O(N)
        public static int Solution(int[] A, int[] B)
        {
            if (A.Length == 0)
                return 0;

            Stack<int> st = new Stack<int>();
            int numAlive = A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1) st.Push(A[i]);
                if (B[i] == 0)
                {
                    while (st.Count != 0)
                    {
                        if (st.Peek() > A[i])
                        {
                            numAlive--;
                            break;      
                        }
                        else if (st.Peek() < A[i])
                        {
                            numAlive--;
                            st.Pop();  
                        }
                    }
                }
            }

            return numAlive;
        }
    }
}
