using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 231. 2的幂
/// https://leetcode-cn.com/problems/power-of-two/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00231_power_of_two
    {
        public bool IsPowerOfTwo(int n)
        {
            return n <= 0 ? false : (n & (n - 1)) == 0;
        }
    }
}
