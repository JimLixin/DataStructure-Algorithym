using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1342. 将数字变成 0 的操作次数
/// https://leetcode-cn.com/problems/number-of-steps-to-reduce-a-number-to-zero/
/// </summary>
namespace Algorithym.LeetCode.位运算
{
    public class _01342_number_of_steps_to_reduce_a_number_to_zero
    {
        public int NumberOfSteps(int num)
        {
            int steps = 0;
            while (num != 0)
            {
                steps += (num & 1) == 0 ? 1 : 2;
                num >>= 1;
            }
            return --steps;
        }
    }
}
