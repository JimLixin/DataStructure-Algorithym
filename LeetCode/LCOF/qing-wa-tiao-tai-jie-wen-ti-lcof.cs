using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题10- II. 青蛙跳台阶问题
    /// https://leetcode-cn.com/problems/qing-wa-tiao-tai-jie-wen-ti-lcof/
    /// </summary>
    public class qing_wa_tiao_tai_jie_wen_ti_lcof
    {
        public int NumWays(int n)
        {
            if (n <= 0)
                return 1;
            int[] dp = new int[3];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i % 3] = (dp[(i - 1) % 3] + dp[(i - 2) % 3]) % 1000000007;
            }
            return dp[n % 3];
        }
    }
}
