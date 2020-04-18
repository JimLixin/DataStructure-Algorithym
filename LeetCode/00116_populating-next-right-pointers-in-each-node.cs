using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.populating_next_right_pointers_in_each_node
{

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    /// <summary>
    /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    /// </summary>
    public class populating_next_right_pointers_in_each_node
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return null;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int qCount = q.Count;
                Node pre = null;
                for (int i = 0; i < qCount; i++)
                {
                    Node n = q.Dequeue();
                    if (pre != null)
                        pre.next = n;
                    pre = n;

                    if (n.left != null)
                        q.Enqueue(n.left);
                    if (n.right != null)
                        q.Enqueue(n.right);
                }
            }
            return root;
        }
    }

    public class populating_next_right_pointers_in_each_nodeV2
    {
        public Node Connect(Node root)
        {
            Dictionary<int, Node> depths = new Dictionary<int, Node>();
            SetNextPointer(root, depths, 0);
            return root;
        }

        private void SetNextPointer(Node root, Dictionary<int, Node> depths, int depth)
        {
            if (root == null) { return; }
            if (depths.ContainsKey(depth))
            {
                root.next = depths[depth];
            }
            depths[depth] = root;
            SetNextPointer(root.right, depths, depth + 1);
            SetNextPointer(root.left, depths, depth + 1);
        }
    }
}
