using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/
    /// </summary>
    public static class generate_parentheses
    {
        private static char[] data;
        private static bool[] vis;
        private static int availableOpen;
        private static int availableClose;
        private static IList<string> result;
        public static IList<string> GenerateParenthesis(int n)
        {
            if (n <= 0)
                return result;
            if (n == 1)
            {
                result.Add("()");
                return result;
            }
            data = new char[2*n];
            vis = new bool[2*n+2];
            availableOpen = n;
            availableClose = n;
            result = new List<string>();

            List<char[]> input = new List<char[]>();
            input.Add(new char[] { '('});
            char[] brackets = new char[] { '(',')'};
            input.AddRange(Enumerable.Repeat(brackets, 2*n - 2));
            input.Add(new char[] { ')' });

            dfs(0, input.ToArray());
            return result;
        }

        private static void dfs(int step, char[][] nums)
        {
            if (step >= nums.Length)
            {
                result.Add(new String(data));
                return;
            }

            for (int i = 0; i < nums[step].Length; i++)
            {
                char c = nums[step][i];
                bool isOpen = (c == '(');
                if (isOpen && availableOpen == 0 || !isOpen && (availableClose == 0 || availableClose <= availableOpen))
                    continue;
                if (!vis[step])
                {
                    vis[step] = true;
                    data[step] = c;

                    if (isOpen)
                        availableOpen--;
                    else
                        availableClose--;

                    dfs(step+1, nums);
                    vis[step] = false;

                    if (isOpen)
                        availableOpen++;
                    else
                        availableClose++;
                }
            }
        }
    }
}
