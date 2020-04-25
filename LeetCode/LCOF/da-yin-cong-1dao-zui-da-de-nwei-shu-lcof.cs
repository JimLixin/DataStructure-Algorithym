using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题17. 打印从1到最大的n位数
    /// https://leetcode-cn.com/problems/da-yin-cong-1dao-zui-da-de-nwei-shu-lcof/
    /// </summary>
    public class da_yin_cong_1dao_zui_da_de_nwei_shu_lcof
    {
        public int[] PrintNumbers(int n)
        {
            return Enumerable.Range(1, (int)Math.Pow(10, n) - 1).ToArray();
        }
    }
}
