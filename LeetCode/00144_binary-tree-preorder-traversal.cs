using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 144. 二叉树的前序遍历
/// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 递归
    /// </summary>
    public class _00144_binary_tree_preorder_traversal
    {
        IList<int> result;
        public IList<int> PreorderTraversal(TreeNode root)
        {
            result = new List<int>();
            travel(root);
            return result;
        }

        public void travel(TreeNode node)
        {
            if (node == null)
                return;
            result.Add(node.val);
            travel(node.left);
            travel(node.right);
        }
    }

    /// <summary>
    /// 迭代
    /// </summary>
    public class binary_tree_preorder_traversal_V2
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || s.Count > 0)
            {
                if (node == null)
                    node = s.Pop();
                result.Add(node.val);
                if (node.right != null)
                    s.Push(node.right);
                node = node.left;
            }
            return result;
        }
    }
}
