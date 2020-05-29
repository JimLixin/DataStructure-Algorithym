using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1029. 两地调度
/// https://leetcode-cn.com/problems/two-city-scheduling/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _01029_两地调度
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            int total = costs.Select(c => c[0]).Sum(), len = costs.Length;
            int[] data = new int[len];
            for (int i = 0; i < len; i++) data[i] = costs[i][1] - costs[i][0];
            Array.Sort(data);
            for (int i = 0; i < len / 2; i++) total += data[i];
            return total;
        }
    }
}
