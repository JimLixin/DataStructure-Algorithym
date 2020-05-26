using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 37. 解数独
/// https://leetcode-cn.com/problems/sudoku-solver/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00037_sudoku_solver
    {
        int rows, cols;
        char[][] _board;
        public void SolveSudoku(char[][] board)
        {
            rows = board.Length;
            cols = board[0].Length;
            _board = board;
            dfs(0, 0);
        }

        public bool dfs(int row, int col)
        {
            if (col == 9) return dfs(row + 1, 0);
            if (row == 9) return true;
            for (int i = row; i < 9; i++)
            {
                for (int j = col; j < 9; j++)
                {
                    if (_board[row][col] != '.') return dfs(row, col + 1);
                    for (char ch = '1'; ch <= '9'; ch++)
                    {
                        if (!isValid(row, col, ch)) continue;
                        _board[row][col] = ch;
                        //Console.WriteLine($"row:{row}, col:{col}, _board[row][col]: {i}");
                        if (dfs(row, col + 1)) return true;
                        _board[row][col] = '.';
                    }
                    return false;
                }
            }
            return false;
        }

        public bool isValid(int row, int col, char num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (_board[row][i] == num) return false;
                if (_board[i][col] == num) return false;
                if (_board[(row / 3) * 3 + i / 3][(col / 3) * 3 + i % 3] == num) return false;
            }
            return true;
        }
    }
}
