using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 397. 整数替换
/// https://leetcode-cn.com/problems/integer-replacement/
/// </summary>
namespace Algorithym.LeetCode.位运算
{
    public class _00397_integer_replacement
    {
        public int IntegerReplacement(int n)
        {
            long N = n;
            int steps = 0;
            while (N > 1)
            {
                if ((N & 1) == 0)
                    N >>= 1;
                else
                    N += ((N & 2) == 0 || N == 3) ? -1 : 1;
                steps++;
            }
            return steps;
        }
    }
}
