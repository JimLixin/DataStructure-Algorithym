using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 326. 3的幂
/// https://leetcode-cn.com/problems/power-of-three/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00326_power_of_three
    {
        /// <summary>
        /// 递归版本
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            if (n == 1) return true;
            return n % 3 == 0 ? IsPowerOfThree(n / 3) : false;
        }

        /// <summary>
        /// 迭代版本
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfThreeV2(int n)
        {
            if (n <= 0) return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}
