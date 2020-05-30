using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1217. 玩筹码
/// https://leetcode-cn.com/problems/play-with-chips/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01217_玩筹码
    {
        public int MinCostToMoveChips(int[] chips)
        {
            int even = 0, odd = 0;
            foreach (int n in chips)
            {
                if ((n & 1) == 0)
                    even++;
                else
                    odd++;
            }
            return Math.Min(even, odd);
        }
    }
}
