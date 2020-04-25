using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题32 - II. 从上到下打印二叉树 II
    /// https://leetcode-cn.com/problems/cong-shang-dao-xia-da-yin-er-cha-shu-ii-lcof/
    /// </summary>
    public class cong_shang_dao_xia_da_yin_er_cha_shu_ii_lcof
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> data = new List<IList<int>>();
            if (root == null)
                return data;
            int level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                data.Add(new List<int>());
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    data[level].Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                level++;
            }
            return data;
        }
    }
}
