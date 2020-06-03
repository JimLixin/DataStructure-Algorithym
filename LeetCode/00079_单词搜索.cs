using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 79. 单词搜索
/// https://leetcode-cn.com/problems/word-search/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00079_单词搜索
    {
        public char[][] _board;
        public bool[,] vis;
        public string _word;
        public int rows;
        public int cols;
        public bool Exist(char[][] board, string word)
        {
            _board = board;
            _word = word;
            rows = board.Length;
            cols = board[0].Length;
            vis = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (check(i, j, 0))
                        return true;
                }
            }
            return false;
        }

        public bool check(int i, int j, int step)
        {
            if (i < 0 || i >= rows || j < 0 || j >= cols || vis[i, j] || _board[i][j] != _word[step]) return false;
            if (step == _word.Length - 1) return true;

            bool res = false;
            vis[i, j] = true;
            res = check(i + 1, j, step + 1) || check(i - 1, j, step + 1) || check(i, j + 1, step + 1) || check(i, j - 1, step + 1);
            vis[i, j] = false;
            return res;
        }
    }
}
