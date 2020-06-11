using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 739. 每日温度
/// https://leetcode-cn.com/problems/daily-temperatures/
/// </summary>
namespace Algorithym.LeetCode.栈
{
    public class _00739_每日温度
    {
        public int[] DailyTemperatures(int[] T)
        {
            int len = T.Length;
            int[] ans = new int[len];
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < len; i++)
            {
                while (s.Count > 0 && T[s.Peek()] < T[i])
                {
                    int pre = s.Pop();
                    ans[pre] = i - pre;
                }
                s.Push(i);
            }
            return ans;
        }
    }
}
