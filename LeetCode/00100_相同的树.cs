using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 100. 相同的树
/// https://leetcode-cn.com/problems/same-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class same_tree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null && q != null || p != null && q == null)
                return false;
            return (p.val == q.val) && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
