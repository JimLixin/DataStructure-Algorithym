using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1305. 两棵二叉搜索树中的所有元素
/// https://leetcode-cn.com/problems/all-elements-in-two-binary-search-trees/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// 中序遍历(迭代) + 归并排序
    /// </summary>
    public class _01305_两棵二叉搜索树中的所有元素
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            int[] data1 = InOrderTravesal(root1);
            int[] data2 = InOrderTravesal(root2);
            if (data1 == null || data1.Length == 0) return data2;
            if (data2 == null || data2.Length == 0) return data1;
            int p1 = data1.Length - 1, p2 = data2.Length - 1, len = data1.Length + data2.Length, pos = len - 1;
            int[] result = new int[len];
            while (p1 >= 0 && p2 >= 0) result[pos--] = data1[p1] > data2[p2] ? data1[p1--] : data2[p2--];
            while (p1 >= 0) result[pos--] = data1[p1--];
            while (p2 >= 0) result[pos--] = data2[p2--];
            return result;
        }

        public int[] InOrderTravesal(TreeNode root)
        {
            List<int> data = new List<int>();
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
                data.Add(node.val);
                node = node.right;
            }
            return data.ToArray();
        }
    }
}
