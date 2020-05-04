using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 191. 位1的个数
    /// https://leetcode-cn.com/problems/number-of-1-bits/
    /// </summary>
    public class _00191_number_of_1_bits
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                count += (n & 1) > 0 ? 1 : 0;
                n >>= 1;
            }
            return count;
        }

        public int HammingWeightV2(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= n - 1;
            }
            return count;
        }
    }
}
