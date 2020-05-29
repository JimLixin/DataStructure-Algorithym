using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1046. 最后一块石头的重量
/// https://leetcode-cn.com/problems/last-stone-weight/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _01046_最后一块石头的重量
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones == null || stones.Length == 0) return 0;
            int pre = 0, i = 1000;
            int[] weight = new int[1001];
            for (int n = 0; n < stones.Length; n++) weight[stones[n]]++;
            while (i > 0)
            {
                if (weight[i] == 0 || pre == 0 && (weight[i] & 1) == 0)
                    i--;
                else
                {
                    if (pre == 0)
                    {
                        weight[i] = 0;
                        pre = i--;
                    }
                    else
                    {
                        weight[i]--;
                        weight[pre - i]++;
                        i = Math.Max(pre - i, i);
                        pre = 0;
                    }
                }
            }
            return pre;
        }
    }
}
