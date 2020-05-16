using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 190. 颠倒二进制位
/// https://leetcode-cn.com/problems/reverse-bits/
/// </summary>
namespace Algorithym.LeetCode.位运算
{
    public class _00190_reverse_bits
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                result |= (n & 1);
                n >>= 1;
            }
            return result;
        }
    }
}
