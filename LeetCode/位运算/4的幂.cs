using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 342. 4的幂
/// https://leetcode-cn.com/problems/power-of-four/
/// </summary>
namespace Algorithym.LeetCode.位运算
{
    public class _00342_power_of_four
    {
        /// <summary>
        /// 自己想出来的版本
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsPowerOfFour(int num)
        {
            if (num <= 0 || (num & (num - 1)) != 0) return false;
            int count = 0;
            while (num > 1)
            {
                num >>= 1;
                count++;
            }
            return (count & 1) == 0;
        }

        /// <summary>
        /// 答案中的最优版本, need to understanding!!!
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsPowerOfFourV2(int num)
        {
            if (num <= 0) return false;
            if ((num & (num - 1)) != 0) return false;
            int flag = 0x55555555;
            if ((num & flag) == 0) return false;
            return true;
        }
    }
}
