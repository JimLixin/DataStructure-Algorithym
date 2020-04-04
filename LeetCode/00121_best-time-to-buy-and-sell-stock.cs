using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class best_time_to_buy_and_sell_stock
    {
        public static int Answer(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int len = prices.Length, buy = int.MaxValue, sell = 0;

            for (int i = 0; i < len; i++)
            {
                if (prices[i] < buy)
                    buy = prices[i];
                else
                    sell = Math.Max(sell, prices[i] - buy);
            }
            return sell;
        }
    }
}
