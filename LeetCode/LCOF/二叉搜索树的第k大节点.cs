using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题54. 二叉搜索树的第k大节点
    /// https://leetcode-cn.com/problems/er-cha-sou-suo-shu-de-di-kda-jie-dian-lcof/
    /// </summary>
    public class 二叉搜索树的第k大节点
    {
        int count, result;
        public int KthLargest(TreeNode root, int k)
        {
            travel(root, k);
            return result;
        }

        public void travel(TreeNode node, int k)
        {
            if (node == null) return;
            travel(node.right, k);
            count++;
            if (count == k)
                result = node.val;
            travel(node.left, k);
        }
    }
}
