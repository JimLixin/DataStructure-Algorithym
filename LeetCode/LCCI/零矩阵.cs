using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 01.08. 零矩阵
/// https://leetcode-cn.com/problems/zero-matrix-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class 零矩阵
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return;
            int rows = matrix.Length, cols = matrix[0].Length;
            bool[] data = new bool[rows + cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        data[i] = true;
                        data[rows + j] = true;
                    }
                }
            }
            //Console.WriteLine(string.Join(",",data));
            for (int i = 0; i < rows; i++)
            {
                if (data[i])
                {
                    for (int j = 0; j < cols; j++) matrix[i][j] = 0;
                }
            }
            for (int i = rows; i < data.Length; i++)
            {
                if (data[i])
                {
                    for (int j = 0; j < rows; j++) matrix[j][i - rows] = 0;
                }
            }
        }
    }
}
