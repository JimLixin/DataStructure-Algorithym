using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 16.01. 交换数字
/// https://leetcode-cn.com/problems/swap-numbers-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 交换数字
    {
        public int[] SwapNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length != 2)
                return numbers;
            numbers[0] = numbers[0] ^ numbers[1];
            numbers[1] = numbers[0] ^ numbers[1];
            numbers[0] = numbers[0] ^ numbers[1];
            return numbers;
        }
    }
}
