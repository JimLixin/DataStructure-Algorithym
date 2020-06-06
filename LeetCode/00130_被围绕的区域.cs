using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 130. 被围绕的区域
/// https://leetcode-cn.com/problems/surrounded-regions/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00130_被围绕的区域
    {
        int rows, cols;
        public void Solve(char[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return;
            rows = board.Length;
            cols = board[0].Length;
            for (int i = 0; i < cols; i++) Update(board, 0, i);
            for (int i = 0; i < rows; i++) Update(board, i, cols - 1);
            for (int i = cols - 1; i >= 0; i--) Update(board, rows - 1, i);
            for (int i = rows - 1; i >= 0; i--) Update(board, i, 0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O') board[i][j] = 'X';
                    if (board[i][j] == 'Y') board[i][j] = 'O';
                }
            }
        }

        public void Update(char[][] board, int i, int j)
        {
            if (i >= rows || j >= cols || i < 0 || j < 0)
                return;
            if (board[i][j] == 'O')
            {
                board[i][j] = 'Y';
                Update(board, i + 1, j);
                Update(board, i - 1, j);
                Update(board, i, j + 1);
                Update(board, i, j - 1);
            }
        }
    }
}
