using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx/
    /// </summary>
    public class sqrtx
    {
        public int MySqrt(int x)
        {
            if (x >= 2147395600)
                return 46340;
            int start = 0, end = 46340, mid = 0;
            while (end - start > 1)
            {
                mid = (start + end) / 2;
                if (mid * mid == x)
                    return mid;
                if (mid * mid > x)
                    end = mid;
                else
                    start = mid;
            }
            return start;
        }
    }
}
