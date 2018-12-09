using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson7_StacksAndQueues
{
    // expected worst-case time complexity is O(N)
    // expected worst-case space complexity is O(N)
    class Brackets
    {
        public static int Solution(string S)
        {
            if (S.Length == 0)
                return 1;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(') stack.Push(')');
                else if (S[i] == '[') stack.Push(']');
                else if (S[i] == '{') stack.Push('}');
                else if (S[i] == ')' || S[i] == ']' || S[i] == '}')
                {
                    if (stack.Count == 0) return 0;
                    else
                    {
                        char temp = stack.Pop(); 
                        if (temp != S[i]) return 0;
                    }
                }
            }
            if (stack.Count != 0) return 0;
            else return 1;
        }
    }
}
