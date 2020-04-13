using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum-iii/
    /// </summary>
    public class path_sum_iii
    {
        private int counter;
        public int PathSum(TreeNode root, int sum)
        {
            List<int> data = new List<int>();
            dfs(root, sum, data);
            return counter;
        }

        public void dfs(TreeNode node, int sum, List<int> data)
        {
            if (node == null)
                return;

            int cur = node.val;
            if (cur == sum)
                counter++;

            int target = data.Where(i => i == cur).Count();
            counter += target;

            List<int> tmp = new List<int>(data.ToArray()).Select(i => i - cur).ToList();
            tmp.Add(sum - cur);

            dfs(node.left, sum, tmp);
            dfs(node.right, sum, tmp);
        }
    }
}
