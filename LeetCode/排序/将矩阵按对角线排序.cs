using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1329. 将矩阵按对角线排序
/// https://leetcode-cn.com/problems/sort-the-matrix-diagonally/
/// </summary>
namespace Algorithym.LeetCode.排序
{
    public class _01329_将矩阵按对角线排序
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            int rows = mat.Length, cols = mat[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int key = i - j;
                    if (!dic.ContainsKey(key)) dic[key] = new List<int>();
                    dic[key].Add(mat[i][j]);
                }
            }
            foreach (int i in dic.Keys) dic[i].Sort();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int key = i - j;
                    mat[i][j] = dic[key][0];
                    dic[key].RemoveAt(0);
                }
            }
            return mat;
        }
    }
}
