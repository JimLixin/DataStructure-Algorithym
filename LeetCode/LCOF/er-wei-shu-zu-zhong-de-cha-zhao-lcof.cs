using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题04. 二维数组中的查找
    /// https://leetcode-cn.com/problems/er-wei-shu-zu-zhong-de-cha-zhao-lcof/
    /// </summary>
    public class er_wei_shu_zu_zhong_de_cha_zhao_lcof
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return false;
            int startRow = 0, startCol = matrix[0].Length - 1, cur;
            while (startRow < matrix.Length && startCol >= 0)
            {
                cur = matrix[startRow][startCol];
                if (cur == target)
                    return true;
                if (cur > target)
                    startCol--;
                else
                    startRow++;
            }

            return false;
        }
    }
}
