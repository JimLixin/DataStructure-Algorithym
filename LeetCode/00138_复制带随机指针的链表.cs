using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 138. 复制带随机指针的链表
/// https://leetcode-cn.com/problems/copy-list-with-random-pointer/
/// </summary>
namespace Algorithym.LeetCode.RandomPointerNode
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class _00138_复制带随机指针的链表
    {
        /// <summary>
        /// 时间: O(N)
        /// 空间: O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            Dictionary<Node, Node> dic = new Dictionary<Node, Node>();
            Node cur = head;
            while (cur != null)
            {
                dic.Add(cur, new Node(cur.val));
                cur = cur.next;
            }
            cur = head;
            while (cur != null)
            {
                dic[cur].next = cur.next == null ? null : dic[cur.next];
                dic[cur].random = cur.random == null ? null : dic[cur.random];
                cur = cur.next;
            }
            return dic[head];
        }

        /// <summary>
        /// 时间: O(N)
        /// 空间: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node CopyRandomListV2(Node head)
        {
            if (head == null) return null;
            Node cur = head;
            while (cur != null)
            {
                Node tmp = cur.next;
                cur.next = new Node(cur.val);
                cur.next.next = tmp;
                cur = tmp;
            }
            cur = head;
            while (cur != null && cur.next != null)
            {
                cur.next.random = cur.random?.next;
                cur = cur.next.next;
            }
            Node newHead = new Node(0), index = newHead;
            cur = head;
            while (cur != null)
            {
                index.next = cur.next;
                index = index.next;
                cur.next = cur.next.next;
                cur = cur.next;
            }
            return newHead.next;
        }
    }
}
