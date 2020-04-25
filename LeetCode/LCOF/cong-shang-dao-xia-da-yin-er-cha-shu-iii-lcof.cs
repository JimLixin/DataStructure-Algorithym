using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题32 - III. 从上到下打印二叉树 III
    /// https://leetcode-cn.com/problems/cong-shang-dao-xia-da-yin-er-cha-shu-iii-lcof/
    /// </summary>
    public class cong_shang_dao_xia_da_yin_er_cha_shu_iii_lcof
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> data = new List<IList<int>>();
            if (root == null)
                return data;
            int level = 0, flag = 0;
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            Stack<TreeNode>[] stacks = new Stack<TreeNode>[2] { s1, s2 };
            stacks[flag].Push(root);
            while (stacks[flag].Count > 0)
            {
                data.Add(new List<int>());
                int size = stacks[flag].Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = stacks[flag].Pop();
                    data[level].Add(node.val);
                    TreeNode node1 = (flag == 0 ? node.left : node.right);
                    TreeNode node2 = (flag == 0 ? node.right : node.left);
                    if (node1 != null) stacks[flag ^ 1].Push(node1);
                    if (node2 != null) stacks[flag ^ 1].Push(node2);
                }
                level++;
                flag ^= 1;
            }
            return data;
        }
    }
}
