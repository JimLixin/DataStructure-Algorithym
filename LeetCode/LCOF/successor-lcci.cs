using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题 04.06. 后继者
    /// https://leetcode-cn.com/problems/successor-lcci/
    /// </summary>
    public class successor_lcci
    {
        IList<int> data;
        int count;
        TreeNode target;
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
                return null;
            data = new List<int>();
            count = 0;
            target = null;
            travel(root, p);
            return target;
        }

        public void travel(TreeNode node, TreeNode p)
        {
            if (target != null)
                return;
            if (node.left != null)
                travel(node.left, p);
            if (target != null)
                return;
            if (count > 0 && data[count - 1] == p.val)
            {
                target = node;
                return;
            }
            else
            {
                data.Add(node.val);
                count++;
            }
            if (node.right != null)
                travel(node.right, p);
        }
    }
}
