using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 84. 柱状图中最大的矩形
/// https://leetcode-cn.com/problems/largest-rectangle-in-histogram/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00084_柱状图中最大的矩形
    {
        /// <summary>
        /// 自己想出来的原始版本
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int LargestRectangleArea(int[] heights)
        {
            if (heights == null || heights.Length == 0) return 0;
            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                int minHeight = heights[i];
                if (minHeight > maxArea)
                    maxArea = minHeight;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (heights[j] < minHeight)
                        minHeight = heights[j];
                    int tmp = (i - j + 1) * minHeight;
                    if (tmp > maxArea)
                        maxArea = tmp;
                }
            }
            return maxArea;
        }
    }
}
