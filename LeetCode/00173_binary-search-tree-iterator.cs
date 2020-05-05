using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 173. 二叉搜索树迭代器
/// https://leetcode-cn.com/problems/binary-search-tree-iterator/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// Space: O(N)
    /// </summary>
    public class BSTIterator
    {
        private Queue<int> data = null;
        public BSTIterator(TreeNode root)
        {
            data = new Queue<int>();
            travel(root);
        }

        private void travel(TreeNode node)
        {
            if (node == null)
                return;
            travel(node.left);
            data.Enqueue(node.val);
            travel(node.right);
        }

        /** @return the next smallest number */
        public int Next()
        {
            return data.Dequeue();
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return data.Count > 0;
        }
    }

    /// <summary>
    /// Space: O(h)
    /// Note: h是BST的高度
    /// </summary>
    public class BSTIteratorV2
    {
        private Stack<TreeNode> s = null;
        public BSTIteratorV2(TreeNode root)
        {
            s = new Stack<TreeNode>();
            travel(root);
        }

        private void travel(TreeNode node)
        {
            while (node != null)
            {
                s.Push(node);
                node = node.left;
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode node = s.Pop();
            if (node.right != null)
            {
                travel(node.right);
            }
            return node.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return s.Count > 0;
        }
    }
}
