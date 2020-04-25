using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题34. 二叉树中和为某一值的路径
    /// https://leetcode-cn.com/problems/er-cha-shu-zhong-he-wei-mou-yi-zhi-de-lu-jing-lcof/
    /// </summary>
    public class er_cha_shu_zhong_he_wei_mou_yi_zhi_de_lu_jing_lcof
    {
        IList<IList<int>> result;
        IList<int> data;
        int step, total;
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            result = new List<IList<int>>();
            if (root == null)
                return result;
            data = new List<int>();
            travel(root, sum, 0);
            return result;
        }

        public void travel(TreeNode node, int sum, int step)
        {
            total += node.val;
            data.Add(node.val);
            if (node.left == null && node.right == null)
            {
                if (total == sum)
                    result.Add(new List<int>(data));
                data.RemoveAt(step);
                total -= node.val;
                return;
            }
            if (node.left != null)
                travel(node.left, sum, step + 1);
            if (node.right != null)
                travel(node.right, sum, step + 1);
            data.RemoveAt(step);
            total -= node.val;
        }
    }
}
