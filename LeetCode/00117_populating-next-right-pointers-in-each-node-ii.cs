using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.populating_next_right_pointers_in_each_node_ii
{
    /// <summary>
    /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
    /// </summary>
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
    public class populating_next_right_pointers_in_each_node_ii
    {
        Dictionary<int, Node> data = null;
        public Node Connect(Node root)
        {
            data = new Dictionary<int, Node>();
            return connect(root, 0);
        }

        public Node connect(Node node, int depth)
        {
            if (node == null)
                return null;
            if (data.ContainsKey(depth))
            {
                node.next = data[depth];
            }
            data[depth] = node;
            node.right = connect(node.right, depth + 1);
            node.left = connect(node.left, depth + 1);
            return node;
        }
    }

    public class populating_next_right_pointers_in_each_node_iiV2
    {
        public Node Connect(Node root, Node parent = null)
        {
            if (root == null)
                return null;
            if (parent != null)
            {
                if (root == parent.left && parent.right != null)
                {
                    root.next = parent.right;
                }
                else
                {
                    Node next = null;
                    parent = parent.next;
                    while (parent != null)
                    {
                        if (parent.left != null)
                        {
                            next = parent.left;
                            break;
                        }
                        else if (parent.right != null)
                        {
                            next = parent.right;
                            break;
                        }
                        parent = parent.next;
                    }
                    root.next = next;
                }
            }
            Connect(root.right, root);
            Connect(root.left, root);
            return root;
        }
    }
}
