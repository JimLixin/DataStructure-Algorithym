using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 23. 合并K个排序链表
/// https://leetcode-cn.com/problems/merge-k-sorted-lists/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// K指针
    /// 执行用时 :692 ms, 在所有 C# 提交中击败了19.15%的用户
    /// 内存消耗 :29.2 MB, 在所有 C# 提交中击败了50.00%的用户
    /// </summary>
    public class _00023_merge_k_sorted_lists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode dumHead = new ListNode(0), tail = dumHead;
            int k = lists.Length;
            while (true)
            {
                int index = -1;
                ListNode min = null;
                for (int i = 0; i < k; i++)
                {
                    if (lists[i] == null) continue;
                    if (min == null || lists[i].val < min.val)
                    {
                        min = lists[i];
                        index = i;
                    }
                }
                if (min == null) break;
                ListNode next = min.next;
                min.next = null;
                lists[index] = next;
                if (dumHead.next == null)
                {
                    dumHead.next = min;
                    tail = dumHead.next;
                }
                else
                {
                    tail.next = min;
                    tail = tail.next;
                }
            }
            return dumHead.next;
        }
    }

    /// <summary>
    /// 1.将K个list中的所有数据都读取到一个数组中
    /// 2.对数组进行排序
    /// 3.根据排序后的数组重建list
    /// 
    /// 执行用时 :144 ms, 在所有 C# 提交中击败了69.30%的用户
    /// 内存消耗 :29.5 MB, 在所有 C# 提交中击败了50.00%的用户
    /// </summary>
    public class _00023_merge_k_sorted_listsV2
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode dumHead = new ListNode(0), tail = dumHead;
            List<int> data = new List<int>();
            int k = lists.Length;
            for (int i = 0; i < k; i++)
            {
                ListNode cur = lists[i];
                while (cur != null)
                {
                    data.Add(cur.val);
                    cur = cur.next;
                }
            }
            int[] dataArr = data.ToArray();
            Array.Sort(dataArr);
            for (int i = 0; i < dataArr.Length; i++)
            {
                if (dumHead.next == null)
                {
                    dumHead.next = new ListNode(dataArr[i]);
                    tail = dumHead.next;
                }
                else
                {
                    tail.next = new ListNode(dataArr[i]);
                    tail = tail.next;
                }
            }
            return dumHead.next;
        }
    }

    /// <summary>
    /// 分治法
    /// 
    /// 执行用时 :136 ms, 在所有 C# 提交中击败了80.00%的用户
    /// 内存消耗 :29.1 MB, 在所有 C# 提交中击败了100.00%的用户
    /// </summary>
    public class _00023_merge_k_sorted_listsV3
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            if (lists.Length < 2) return lists[0];
            return merge(lists, 0, lists.Length - 1);
        }

        public ListNode merge(ListNode[] lists, int left, int right)
        {
            if (left == right) return lists[left];
            int mid = left + (right - left) / 2;
            return mergeTwoList(merge(lists, left, mid), merge(lists, mid + 1, right));
        }

        public ListNode mergeTwoList(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            ListNode dumHead = new ListNode(0), tail = dumHead;
            while (list1 != null && list2 != null)
            {
                ListNode node = null;
                if (list1.val > list2.val)
                {
                    node = list2;
                    list2 = list2.next;
                }
                else
                {
                    node = list1;
                    list1 = list1.next;
                }
                node.next = null;
                if (dumHead.next == null)
                {
                    dumHead.next = node;
                    tail = dumHead.next;
                }
                else
                {
                    tail.next = node;
                    tail = tail.next;
                }
            }
            while (list1 != null)
            {
                ListNode tmp = list1;
                tail.next = tmp;
                tail = tail.next;
                list1 = list1.next;
            }
            while (list2 != null)
            {
                ListNode tmp = list2;
                tail.next = tmp;
                tail = tail.next;
                list2 = list2.next;
            }
            return dumHead.next;
        }
    }
}
