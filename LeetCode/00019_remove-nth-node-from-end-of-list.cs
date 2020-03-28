using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{

    public static class remove_nth_node_from_end_of_list
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (n < 1)
            {
                return null;
            }
            int index = 0;
            ListNode current = head;
            List<ListNode> data = new List<ListNode>();
            while (current != null)
            {
                data.Add(current);
                current = current.next;
                index++;
            }

            if (n > index)
                return null;
            if (n == index)
                return head.next;
            if (n == 1)
            {
                data[index - 2].next = null;
                return head;
            }

            data[index - n - 1].next = data[index - n + 1];
            return head;
        }

        public static ListNode TwoPassSolution(ListNode head, int n)
        {
            ListNode temp = new ListNode(0);
            temp.next = head;
            int size = 0;
            ListNode first = head;
            while (first != null)
            {
                size++;
                first = first.next;
            }
            size -= n;
            Console.WriteLine(size);
            first = temp;
            while (size > 0)
            {
                size--;
                first = first.next;
            }
            first.next = first.next.next;
            return temp.next;
        }

        public static ListNode OnePassSolution(ListNode head, int n)
        {
            ListNode temp = new ListNode(0);
            temp.next = head;
            ListNode firstpointer = temp;
            ListNode secondpointer = temp;
            for (int i = 1; i <= n + 1; i++) // this will set the distance between first and second pointer to the n
            {
                firstpointer = firstpointer.next;
            }
            while (firstpointer != null) // this will help the secondpointer reach the desired location to delete
            {
                firstpointer = firstpointer.next;
                secondpointer = secondpointer.next;
            }
            secondpointer.next = secondpointer.next.next;
            return temp.next;
        }
    }
}
