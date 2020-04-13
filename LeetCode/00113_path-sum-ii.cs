using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
     public class TreeNode
     {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
     }

    /// <summary>
    /// https://leetcode.com/problems/path-sum-ii/
    /// </summary>
    public class path_sum_ii
    {
        private int counter;
        private IList<int> data;
        private IList<IList<int>> result;
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            counter = 0;
            data = new List<int>();
            result = new List<IList<int>>();
            dfs(root, sum);
            return result;
        }

        public void dfs(TreeNode node, int sum)
        {
            if (node == null)
                return;
            counter += node.val;
            data.Add(node.val);
            if (node.right == null && node.left == null)
            {
                if (counter == sum)
                {
                    result.Add(data.ToArray());
                }
                counter -= node.val;
                data.RemoveAt(data.Count - 1);
                return;
            }
            dfs(node.left, sum);
            dfs(node.right, sum);
            counter -= node.val;
            data.RemoveAt(data.Count - 1);
        }
    }
}
