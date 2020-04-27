using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题57 - II. 和为s的连续正数序列
    /// https://leetcode-cn.com/problems/he-wei-sde-lian-xu-zheng-shu-xu-lie-lcof/
    /// </summary>
    public class he_wei_sde_lian_xu_zheng_shu_xu_lie_lcof
    {
        public int[][] FindContinuousSequence(int target)
        {
            IList<int[]> result = new List<int[]>();
            IList<int> data = new List<int>();
            int index = 1, cur = index, sum = 0;
            while (index < target / 2 + 1)
            {
                sum = 0;
                cur = index;
                data.Clear();
                while (sum < target)
                {
                    sum += cur;
                    data.Add(cur);
                    cur++;
                }
                if (sum == target)
                    result.Add(data.ToArray());
                index++;
            }
            return result.ToArray();
        }

        /// <summary>
        /// Better solution to use array
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[][] FindContinuousSequenceV2(int target)
        {
            IList<int[]> result = new List<int[]>();
            int index = 1, cur = index, sum = 0;
            while (index < target / 2 + 1)
            {
                sum = 0;
                cur = index;
                while (sum < target)
                {
                    sum += cur;
                    cur++;
                }
                if (sum == target)
                {
                    result.Add(Enumerable.Range(index, cur - index).ToArray());
                }
                index++;
            }
            return result.ToArray();
        }
    }
}
