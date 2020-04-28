using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题63. 股票的最大利润
    /// https://leetcode-cn.com/problems/gu-piao-de-zui-da-li-run-lcof/
    /// </summary>
    public class 股票的最大利润
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int buy = prices[0], profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                    buy = prices[i];
                else
                    profit = Math.Max(prices[i] - buy, profit);
            }
            return profit;
        }
    }
}
