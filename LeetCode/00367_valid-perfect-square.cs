using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 367. 有效的完全平方数
/// https://leetcode-cn.com/problems/valid-perfect-square/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00367_valid_perfect_square
    {
        public bool IsPerfectSquare(int num)
        {
            if (num <= 0) return false;
            long start = 1, end = int.MaxValue;
            while (start < end)
            {
                long mid = start + ((end - start) >> 1);
                long tmp = mid * mid;
                if (tmp == num)
                    return true;
                else if (tmp > num)
                    end = mid;
                else
                    start = mid + 1;
            }
            return false;

        }
    }
}
