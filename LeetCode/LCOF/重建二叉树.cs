using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题07. 重建二叉树
    /// https://leetcode-cn.com/problems/zhong-jian-er-cha-shu-lcof/
    /// </summary>
    public class zhong_jian_er_cha_shu_lcof
    {
        int index;
        Dictionary<int, int> map = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || preorder.Length == 0)
                return null;
            for (int i = 0; i < inorder.Length; i++)
            {
                map.Add(inorder[i], i);
            }
            return build(preorder, inorder, 0, preorder.Length - 1);
        }

        public TreeNode build(int[] preorder, int[] inorder, int start, int end)
        {
            if (start > end)
                return null;

            int cur = preorder[index];
            int curIndex = map[cur];
            TreeNode node = new TreeNode(cur);
            index++;

            if (start == end)
                return node;

            node.left = build(preorder, inorder, start, curIndex - 1);
            node.right = build(preorder, inorder, curIndex + 1, end);
            return node;
        }
    }
}
