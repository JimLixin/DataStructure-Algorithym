using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题15. 二进制中1的个数
    /// https://leetcode-cn.com/problems/er-jin-zhi-zhong-1de-ge-shu-lcof/
    /// </summary>
    public class er_jin_zhi_zhong_1de_ge_shu_lcof
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1) count++;
                n >>= 1;
            }
            return count;
        }
    }
}
