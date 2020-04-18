using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle/
    /// </summary>
    public class pascals_triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            numRows = numRows < 0 ? 1 : numRows;
            IList<IList<int>> data = new List<IList<int>>();
            int[] pre = new int[numRows];
            for (int i = 0; i < numRows; i++)
            {
                data.Add(new int[i + 1]);
                data[i][0] = 1;
                data[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    data[i][j] = pre[j - 1] + pre[j];
                }
                pre = data[i].ToArray();
            }
            return data;
        }
    }
}
