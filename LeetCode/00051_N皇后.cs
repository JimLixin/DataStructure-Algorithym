using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 51. N皇后
/// https://leetcode-cn.com/problems/n-queens/
/// </summary>
namespace Algorithym.LeetCode
{
    public class n_queens
    {
        private IList<int[]> result;
        private int[] solutions;


        /// <param name="n"></param>
        /// <returns></returns>
        public IList<IList<string>> SolveNQueens(int n)
        {
            solutions = new int[n];
            result = new List<int[]>();
            for (int i = 0; i < solutions.Length; i++)
            {
                solutions[i] = -(n+1);
            }
            solve(0, n);
            return getSolutionString(result, n);
        }

        public void solve(int row, int n)
        {
            if (row >= n)
            {
                if (!solutions.Contains(-(n + 1)))
                {
                    result.Add((int[])solutions.Clone());
                }
                return;
            }
            for (int col = 0; col < n; col++)
            {
                if (Valid(row, col))
                {
                    solutions[row] = col;
                    solve(row + 1, n);
                    solutions[row] = -(n+1);
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

        public IList<IList<string>> getSolutionString(IList<int[]> solutions, int n)
        {
            IList<IList<string>> result = new List<IList<string>>();
            foreach (var s in solutions)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    var tmp = Enumerable.Repeat<char>('.', n).ToList();
                    tmp[s[i]] = 'Q';
                    list.Add(new String(tmp.ToArray()));
                }

                result.Add(list);
            }

            return result;
        }
    }
}
