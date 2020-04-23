using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题11. 旋转数组的最小数字
    /// https://leetcode-cn.com/problems/xuan-zhuan-shu-zu-de-zui-xiao-shu-zi-lcof/
    /// </summary>
    public class xuan_zhuan_shu_zu_de_zui_xiao_shu_zi_lcof
    {
        public int MinArray(int[] numbers)
        {
            int len = numbers.Length;
            if (len < 3)
                return len == 1 ? numbers[0] : Math.Min(numbers[0], numbers[1]);

            int p1 = 0, p2 = 1, p3 = 2;
            while (p3 < len)
            {
                if (numbers[p1] > numbers[p2])
                    return numbers[p2];
                if (numbers[p2] > numbers[p3])
                    return numbers[p3];
                p1++; p2++; p3++;
            }
            return numbers[0];
        }
    }
}
