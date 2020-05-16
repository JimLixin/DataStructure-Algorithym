using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 476. 数字的补数
/// https://leetcode-cn.com/problems/number-complement/
/// </summary>
namespace Algorithym.LeetCode.位运算
{
    public class _00476_number_complement
    {
        /// <summary>
        /// 方法一: 按位取反然后再加回到结果中
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FindComplement(int num)
        {
            int result = 0, j = 0;
            while (num != 0)
            {
                result += ((num & 1) ^ 1) * (int)Math.Pow(2, j++);
                num >>= 1;
            }
            return result;
        }

        /// <summary>
        /// 方法二： 不断清除最右边的1，直到只剩下最高位的1，然后再左移一位并减一，得到的数字与num进行异或就可以得到结果
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FindComplementV2(int num)
        {
            int n = num;
            while ((n & (n - 1)) > 0) n &= n - 1;
            return ((n << 1) - 1) ^ num;
        }
    }
}
