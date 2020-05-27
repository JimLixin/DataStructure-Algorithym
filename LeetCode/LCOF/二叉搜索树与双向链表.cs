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
    /// <summary>
    /// 递归
    /// </summary>
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

    /// <summary>
    /// 迭代: 需要验证！LeetCode issue which cause this solution cannot be tested online for time being!
    /// </summary>
    public class 二叉搜索树与双向链表V2
    {
        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            Stack<Node> s = new Stack<Node>();
            Node node = root, head = null, pre = null;
            while (node != null)
            {
                while (node != null)
                {
                    s.Push(node);
                    node = node.left;
                }
                node = s.Pop();
                if (pre != null) pre.right = node;
                pre = node;
                if (head == null) head = node;
                if (node.right != null) node.right.left = node;
                node = node.right;
                pre = node;
            }
            pre.right = head;
            head.left = pre;
            return head;
        }
    }
}
