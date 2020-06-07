using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 371. 两整数之和
/// https://leetcode-cn.com/problems/sum-of-two-integers/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00371_两整数之和
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a ^ b;
                b = (a & b) << 1;
                a = tmp;
            }
            return a;
        }
    }
}
