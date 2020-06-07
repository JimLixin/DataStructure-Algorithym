using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 461. 汉明距离
/// https://leetcode-cn.com/problems/hamming-distance/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00461_汉明距离
    {
        public int HammingDistance(int x, int y)
        {
            int count = 0;
            while (x != 0 || y != 0)
            {
                count += (x & 1) ^ (y & 1);
                x >>= 1;
                y >>= 1;
            }
            return count;
        }
    }
}
