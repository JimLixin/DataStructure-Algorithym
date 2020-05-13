using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 429. N叉树的层序遍历
/// https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/
/// </summary>
namespace Algorithym.LeetCode
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public class _00429_n_ary_tree_level_order_traversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<Node> q = new Queue<Node>();
            int level = 0;
            q.Enqueue(root);
            while (q.Count > 0)
            {
                result.Add(new List<int>());
                int cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    Node node = q.Dequeue();
                    result[level].Add(node.val);
                    for (int j = 0; j < node.children.Count; j++)
                    {
                        q.Enqueue(node.children[j]);
                    }
                }
                level++;
            }
            return result;
        }
    }
}
