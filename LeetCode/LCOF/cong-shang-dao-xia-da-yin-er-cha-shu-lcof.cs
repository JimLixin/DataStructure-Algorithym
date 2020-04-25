using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题32 - I. 从上到下打印二叉树
    /// https://leetcode-cn.com/problems/cong-shang-dao-xia-da-yin-er-cha-shu-lcof/
    /// </summary>
    public class cong_shang_dao_xia_da_yin_er_cha_shu_lcof
    {
        public int[] LevelOrder(TreeNode root)
        {
            if (root == null)
                return new int[] { };
            IList<int> data = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    data.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }
            return data.ToArray();
        }
    }
}
