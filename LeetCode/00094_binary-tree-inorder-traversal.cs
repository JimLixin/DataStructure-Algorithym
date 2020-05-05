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
                travel(node.left);
                result.Add(node.val);
                travel(node.right);
            }
        }
    }

    /// <summary>
    /// 迭代法
    /// </summary>
    public class binary_tree_inorder_traversal_V2
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            IList<int> result = new List<int>();
            TreeNode cur = root;
            while (cur != null || s.Count > 0)
            {
                while (cur != null)
                {
                    s.Push(cur);
                    cur = cur.left;
                }
                cur = s.Pop();
                result.Add(cur.val);
                cur = cur.right;
            }
            return result;
        }
    }
}
