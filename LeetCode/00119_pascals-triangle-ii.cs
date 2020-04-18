using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle-ii/
    /// </summary>
    public class pascals_triangle_ii
    {
        public IList<int> GetRow(int rowIndex)
        {
            rowIndex = rowIndex < 0 ? 1 : rowIndex;
            int[] prev = null;
            for (int i = 0; i <= rowIndex; i++)
            {
                int[] cur = new int[rowIndex + 1];
                cur[0] = 1;
                cur[i] = 1;
                for (int j = 1; j < i; j++)
                {
                    cur[j] = prev[j - 1] + prev[j];
                }
                prev = cur;
            }
            return prev;
        }
    }
}
