using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题10- I. 斐波那契数列
    /// https://leetcode-cn.com/problems/fei-bo-na-qi-shu-lie-lcof/
    /// </summary>
    public class fei_bo_na_qi_shu_lie_lcof
    {
        public int Fib(int n)
        {
            int[] data = new int[3];
            data[0] = 0;
            data[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                data[i % 3] = (data[(i - 1) % 3] + data[(i - 2) % 3]) % 1000000007;
            }
            return data[n % 3];
        }
    }
}
