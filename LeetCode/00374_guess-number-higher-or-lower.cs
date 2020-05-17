using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 374. 猜数字大小
/// https://leetcode-cn.com/problems/guess-number-higher-or-lower/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00374_guess_number_higher_or_lower
    {
        private int guess(int n) { return 0; }
        /// <summary>
        /// 原始版本
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GuessNumber(int n)
        {
            if (n < 1) return n;
            int start = 1, end = n;
            while (start < end)
            {
                int mid = start + ((end - start) >> 1);
                int res = guess(mid);
                if (res > 0)
                    start = mid + 1;
                else if (res < 0)
                    end = mid;
                else
                    return mid;
            }
            return start;
        }

        /// <summary>
        /// 优化过的版本： 不需要显示判断mid是否等于target
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GuessNumberV2(int n)
        {
            if (n < 1) return n;
            int start = 1, end = n;
            while (start < end)
            {
                int mid = start + ((end - start) >> 1);
                if (guess(mid) > 0)
                    start = mid + 1;
                else
                    end = mid;
            }
            return start;
        }
    }
}
