using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class best_time_to_buy_and_sell_stock_ii
    {
        public static int Answer(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int len = prices.Length;
            int buy = prices[0], sell = buy, profit = 0;
            for (int i = 1; i < len; i++)
            {
                if (prices[i] < buy && sell == buy)
                {
                    buy = prices[i];
                }
                else
                {
                    if (prices[i] < sell)
                    {
                        profit += (sell - buy);
                        buy = prices[i];
                    }
                }
                sell = prices[i];
            }
            return profit + (sell - buy);
        }
    }
}
