using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题12. 矩阵中的路径
    /// https://leetcode-cn.com/problems/ju-zhen-zhong-de-lu-jing-lcof/
    /// </summary>
    public class ju_zhen_zhong_de_lu_jing_lcof
    {
        int width, height, depth;
        IList<int[]> data;
        string _word;
        public bool Exist(char[][] board, string word)
        {
            _word = word;
            height = board.Length;
            width = board[0].Length;
            depth = word.Length;
            if (height * width < depth)
                return false;
            data = new List<int[]>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (dfs(board, 0, i, j))
                        return true;
                }
            }
            return false;
        }
        public bool dfs(char[][] board, int step, int x, int y)
        {
            if (x > height - 1 || y > width - 1 || x < 0 || y < 0 || step >= depth)
                return false;
            if (board[x][y] == _word[step] && (data.Count == 0 || data.Count > 0 && !data.Any(d => d[0] == x && d[1] == y)))
            {
                if (step == depth - 1)
                {
                    return true;
                }
                else
                {
                    data.Add(new int[] { x, y });
                    bool result =
                        x > 0 && dfs(board, step + 1, x - 1, y) ||
                        x < height - 1 && dfs(board, step + 1, x + 1, y) ||
                        y > 0 && dfs(board, step + 1, x, y - 1) ||
                        y < width - 1 && dfs(board, step + 1, x, y + 1);
                    data.RemoveAt(data.Count - 1);
                    return result;
                }
            }

            return false;
        }
    }

    /// <summary>
    /// Use board[x][y] itself to store the data
    /// </summary>
    public class ImprovedSolution
    {
        int width, height, depth;
        string _word;
        public bool Exist(char[][] board, string word)
        {
            _word = word;
            height = board.Length;
            width = board[0].Length;
            depth = word.Length;
            if (height * width < depth)
                return false;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (dfs(board, 0, i, j))
                        return true;
                }
            }
            return false;
        }
        public bool dfs(char[][] board, int step, int x, int y)
        {
            if (x > height - 1 || y > width - 1 || x < 0 || y < 0 || step >= depth)
                return false;
            if (board[x][y] == _word[step])
            {
                if (step == depth - 1)
                {
                    return true;
                }
                else
                {
                    board[x][y] = ' ';
                    bool result =
                        x > 0 && dfs(board, step + 1, x - 1, y) ||
                        x < height - 1 && dfs(board, step + 1, x + 1, y) ||
                        y > 0 && dfs(board, step + 1, x, y - 1) ||
                        y < width - 1 && dfs(board, step + 1, x, y + 1);
                    board[x][y] = _word[step];
                    return result;
                }
            }

            return false;
        }
    }
}
