using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 56. 合并区间
/// https://leetcode-cn.com/problems/merge-intervals/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _00056_合并区间
    {
        /// <summary>
        /// Array.Sort, 排序效率不高
        /// 执行用时 :384 ms, 在所有 C# 提交中击败了20.86%的用户
        /// 内存消耗 :33.2 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> result = new List<int[]>();
            if (intervals == null || intervals.Length == 0)
                return result.ToArray();

            Array.Sort(intervals, (a, b) => {
                if (a[0] > b[0])
                    return 1;
                else if (a[0] < b[0])
                    return -1;
                else
                    return 0;
            });

            for (int i = 0; i < intervals.Length; i++)
            {
                if (result.Count == 0 || result[result.Count - 1][1] < intervals[i][0])
                    result.Add(intervals[i]);
                else
                    result[result.Count - 1][1] = Math.Max(intervals[i][1], result[result.Count - 1][1]);
            }
            return result.ToArray();
        }

        /// <summary>
        /// 使用Linq中的OrderBy以及优化循环部分的代码，性能有所提升
        /// 执行用时 :316 ms, 在所有 C# 提交中击败了50.99%的用户
        /// 内存消耗 :33.8 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] MergeV2(int[][] intervals)
        {
            if (intervals.Length < 2) return intervals;

            intervals = intervals.OrderBy(x => x[0]).ToArray();
            var res = new List<int[]>();
            var cur = intervals[0];
            foreach (var next in intervals)
            {
                if (cur[1] >= next[0])
                    cur[1] = Math.Max(next[1], cur[1]);
                else
                {
                    res.Add(cur);
                    cur = next;
                }
            }
            res.Add(cur);
            return res.ToArray();
        }
    }
}
