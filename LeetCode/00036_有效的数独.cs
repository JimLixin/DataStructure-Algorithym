using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 36. 有效的数独
/// https://leetcode-cn.com/problems/valid-sudoku/
/// </summary>
namespace Algorithym.LeetCode
{

    public static class valid_sudoku
    {
        public static bool Answer(char[][] board)
        {
            List<char> tmp = new List<char>();
            List<char>[] squares = new List<char>[3] { new List<char>(), new List<char>(), new List<char>() };
            List<char>[] squares2 = new List<char>[9] { new List<char>(), new List<char>(), new List<char>(), new List<char>(), new List<char>(), new List<char>(), new List<char>(), new List<char>(), new List<char>() };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;
                    if (tmp.Contains(board[i][j]) || squares[j / 3].Contains(board[i][j]) || squares2[j].Contains(board[i][j]))
                        return false;
                    tmp.Add(board[i][j]);
                    squares[j / 3].Add(board[i][j]);
                    squares2[j].Add(board[i][j]);
                }
                tmp.Clear();
                if (i % 3 == 2)
                {
                    squares[0].Clear();
                    squares[1].Clear();
                    squares[2].Clear();
                }
            }
            return true;
        }
    }
}
