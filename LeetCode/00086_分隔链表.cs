using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 86. 分隔链表
/// https://leetcode-cn.com/problems/partition-list/
/// </summary>
/// 
namespace Algorithym.LeetCode
{

    public class partition_list
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
                return null;
            ListNode current = head, leftHead = null, leftTail = null, rightHead = null, rightTail = null;
            while (current != null)
            {
                ListNode tmp = new ListNode(current.val);
                if (current.val < x)
                {
                    if (leftHead == null)
                    {
                        leftHead = tmp;
                        leftTail = tmp;
                    }
                    else
                    {
                        leftTail.next = tmp;
                        leftTail = leftTail.next;
                    }
                }
                else
                {
                    if (rightHead == null)
                    {
                        rightHead = tmp;
                        rightTail = tmp;
                    }
                    else
                    {
                        rightTail.next = tmp;
                        rightTail = rightTail.next;
                    }
                }
                current = current.next;
            }

            if (leftTail != null)
            {
                leftTail.next = rightHead;
                return leftHead;
            }
            return rightHead;
        }
    }
}
