using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/triangle/
    /// </summary>
    public class triangle
    {
        /// <summary>
        /// Space complexity: O(M*N)
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle == null || triangle.Count == 0)
                return 0;
            int steps = triangle.Count, min = int.MaxValue;
            int[][] dp = new int[steps][];
            dp[0] = new int[] { triangle[0][0] };
            min = dp[0][0];
            for (int i = 1; i < steps; i++)
            {
                int dpCount = triangle[i].Count;
                dp[i] = new int[dpCount];
                dp[i][0] = dp[i - 1][0] + triangle[i][0];
                dp[i][dpCount - 1] = dp[i - 1][dpCount - 2] + triangle[i][dpCount - 1];
                min = Math.Min(dp[i][0], dp[i][dpCount - 1]);
                for (int j = 1; j < dpCount - 1; j++)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j], dp[i - 1][j - 1]) + triangle[i][j];
                    min = Math.Min(min, dp[i][j]);
                    //Console.WriteLine($"{min}");
                }
                //Console.WriteLine(string.Join(",", dp[i]));
            }
            return min;
        }

        /// <summary>
        /// Space complexity: O(N)
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public int MinimumTotalV2(IList<IList<int>> triangle)
        {
            if (triangle == null || triangle.Count == 0)
                return 0;
            int steps = triangle.Count, min = int.MaxValue;
            int[] dp = new int[steps];
            dp[steps - 1] = triangle[0][0];
            min = dp[steps - 1];
            for (int i = 1; i < steps; i++)
            {
                min = int.MaxValue;
                int dpCount = triangle[i].Count;
                for (int j = 0; j < dpCount; j++)
                {
                    if (j == 0)
                        dp[steps - dpCount + j] = dp[steps - dpCount + j + 1] + triangle[i][0];
                    else if (j == dpCount - 1)
                        dp[steps - dpCount + j] = dp[steps - 1] + triangle[i][dpCount - 1];
                    else
                        dp[steps - dpCount + j] = Math.Min(dp[steps - dpCount + j], dp[steps - dpCount + j + 1]) + triangle[i][j];

                    min = Math.Min(min, dp[steps - dpCount + j]);
                    //Console.WriteLine($"{min}");
                }
                //Console.WriteLine(string.Join(",", dp[i]));
            }
            return min;
        }
    }
}
