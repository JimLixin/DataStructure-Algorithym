using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node() { }
        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }

    }
    public class 二叉搜索树与双向链表
    {
        Node head, pre;
        public Node TreeToDoublyList(Node root)
        {
            travel(root);
            head.left = pre;
            pre.right = head;
            return head;
        }

        public void travel(Node node)
        {
            if (node == null) return;
            travel(node.left);
            if (head == null)
            {
                head = node;
                pre = node;
            }
            else
            {
                pre.right = node;
                node.left = pre;
                pre = node;
            }
            travel(node.right);
        }
    }
}
