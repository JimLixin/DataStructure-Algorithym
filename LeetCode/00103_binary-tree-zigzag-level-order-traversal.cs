using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
    /// </summary>
    public class binary_tree_zigzag_level_order_traversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            Stack<TreeNode>[] stacks = new Stack<TreeNode>[2];
            stacks[0] = new Stack<TreeNode>();
            stacks[1] = new Stack<TreeNode>();

            int level = 0, index = 0;

            stacks[0].Push(root);
            while (stacks.Any(s => s.Count > 0))
            {
                result.Add(new List<int>());
                int count = stacks[index].Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = stacks[index].Pop();
                    result[level].Add(node.val);
                    if (index == 0)
                    {
                        if (node.left != null)
                        {
                            stacks[1 - index].Push(node.left);
                        }
                        if (node.right != null)
                        {
                            stacks[1 - index].Push(node.right);
                        }
                    }
                    else
                    {
                        if (node.right != null)
                        {
                            stacks[1 - index].Push(node.right);
                        }
                        if (node.left != null)
                        {
                            stacks[1 - index].Push(node.left);
                        }
                    }
                }
                level++;
                index = 1 - index;
            }
            return result;
        }
    }
}
