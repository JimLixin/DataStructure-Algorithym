using Algorithym.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-inorder-traversal/
    /// </summary>
    public class binary_tree_inorder_traversal
    {
        private IList<int> result;
        public IList<int> InorderTraversal(TreeNode root)
        {
            result = new List<int>();
            travel(root);
            return result;
        }

        public void travel(TreeNode node)
        {
            if (node != null)
            {
                travel(node.LeftChild);
                result.Add(node.Value);
                travel(node.RightChild);
            }
        }
    }
}
