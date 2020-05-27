using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 面试题31. 栈的压入、弹出序列
/// https://leetcode-cn.com/problems/zhan-de-ya-ru-dan-chu-xu-lie-lcof/
/// </summary>
namespace Algorithym.LeetCode.LCOF
{
    public class 栈的压入弹出序列
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            if (pushed.Length == 0) return popped.Length == 0;
            if (popped.Length == 0) return pushed.Length == 0;
            Stack<int> s = new Stack<int>();
            int i = 0, j = 0, len = pushed.Length;
            while (i < len)
            {
                s.Push(pushed[i++]);
                while (s.Count > 0 && s.Peek() == popped[j])
                {
                    s.Pop();
                    j++;
                }
            }
            return s.Count > 0 ? false : true;
        }
    }
}
