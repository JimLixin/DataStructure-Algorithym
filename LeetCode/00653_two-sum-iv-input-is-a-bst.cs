using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 653. 两数之和 IV - 输入 BST
/// https://leetcode-cn.com/problems/two-sum-iv-input-is-a-bst/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00653_two_sum_iv_input_is_a_bst
    {
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> dic = new HashSet<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || s.Count > 0)
            {
                while (node != null)
                {
                    s.Push(node);
                    node = node.left;
                }
                node = s.Pop();
                if (dic.Contains(k - node.val)) return true;
                if (!dic.Contains(node.val)) dic.Add(node.val);
                node = node.right;
            }
            return false;
        }
    }
}
