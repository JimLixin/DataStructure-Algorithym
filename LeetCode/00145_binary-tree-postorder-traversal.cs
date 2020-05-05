using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 145. 二叉树的后序遍历
/// https://leetcode-cn.com/problems/binary-tree-postorder-traversal/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 递归
    /// </summary>
    public class _00145_binary_tree_postorder_traversal
    {
        IList<int> result;
        public IList<int> PostorderTraversal(TreeNode root)
        {
            result = new List<int>();
            travel(root);
            return result;
        }
        public void travel(TreeNode node)
        {
            if (node == null)
                return;
            travel(node.left);
            travel(node.right);
            result.Add(node.val);
        }
    }

    /// <summary>
    /// 迭代
    /// </summary>
    public class _00145_binary_tree_postorder_traversal_V2
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            while (s.Count > 0)
            {
                TreeNode node = s.Peek();
                if (node == null)
                {
                    s.Pop();    //弹出null指针
                    result.Add(s.Pop().val);    //保存当前节点
                    continue;
                }
                s.Push(null);   //压入null指针
                if (node.right != null)
                    s.Push(node.right);
                if (node.left != null)
                    s.Push(node.left);
            }
            return result;
        }
    }
}
