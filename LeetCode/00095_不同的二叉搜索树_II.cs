using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 95. 不同的二叉搜索树 II
/// https://leetcode-cn.com/problems/unique-binary-search-trees-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00095_不同的二叉搜索树_II
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
                return new List<TreeNode>();
            else
                return generate(1, n);
        }

        public IList<TreeNode> generate(int start, int end)
        {
            IList<TreeNode> result = new List<TreeNode>();
            if (start > end)
            {
                result.Add(null);
                return result;
            }
            for (int i = start; i <= end; i++)
            {
                IList<TreeNode> leftTrees = generate(start, i - 1);
                IList<TreeNode> rightTrees = generate(i + 1, end);
                foreach (TreeNode l in leftTrees)
                {
                    foreach (TreeNode r in rightTrees)
                    {
                        TreeNode node = new TreeNode(i);
                        node.left = l;
                        node.right = r;
                        result.Add(node);
                    }
                }
            }
            return result;
        }
    }
}
