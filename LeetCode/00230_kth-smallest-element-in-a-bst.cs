using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 230. 二叉搜索树中第K小的元素
    /// https://leetcode-cn.com/problems/kth-smallest-element-in-a-bst/
    /// </summary>
    public class _00230_kth_smallest_element_in_a_bst
    {
        public int KthSmallest(TreeNode root, int k)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            int count = 0;
            TreeNode node = root;
            while (node != null || s.Count > 0)
            {
                while (node != null)
                {
                    s.Push(node);
                    node = node.left;
                }
                node = s.Pop();
                count++;
                if (count == k)
                    return node.val;
                node = node.right;
            }
            return node.val;
        }
    }
}
