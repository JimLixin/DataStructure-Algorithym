using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens-ii/
    /// </summary>
    public class n_queens_ii
    {
        private int result;
        private int[] solutions;

        public int Answer(int n)
        {
            solutions = new int[n];
            result = 0;
            for (int i = 0; i < solutions.Length; i++)
            {
                solutions[i] = -(n + 1);
            }
            solve(0, n);
            return result;
        }

        public void solve(int row, int n)
        {
            if (row >= n)
            {
                if (!solutions.Contains(-(n + 1)))
                {
                    result++;
                }
                return;
            }
            for (int col = 0; col < n; col++)
            {
                if (Valid(row, col))
                {
                    solutions[row] = col;
                    solve(row + 1, n);
                    solutions[row] = -(n + 1);
                }
            }
        }

        public bool Valid(int row, int col)
        {
            if (solutions.Contains(col) || solutions[row] >= 0)
                return false;
            for (int i = 0; i < solutions.Length; i++)
            {
                if (Math.Abs(i - row) == Math.Abs(solutions[i] - col))
                    return false;
            }
            return true;
        }
    }
}
