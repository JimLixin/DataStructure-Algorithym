using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
    /// </summary>
    public class convert_sorted_list_to_binary_search_tree
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
                return null;
            IList<int> data = new List<int>();
            while (head != null)
            {
                data.Add(head.val);
                head = head.next;
            }
            return buildTree(data.ToArray(), 0, data.Count - 1);
        }

        public TreeNode buildTree(int[] nums, int start, int end)
        {
            if (start > end)
                return null;
            int mid = start + (end - start) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = buildTree(nums, start, mid - 1);
            node.right = buildTree(nums, mid + 1, end);
            return node;
        }
    }

    public class convert_sorted_list_to_binary_search_treeV2
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            return buildHelper(head);
        }

        public TreeNode buildHelper(ListNode head)
        {
            if (head == null)
                return null;

            //find mid
            ListNode fast = head.next;
            ListNode slow = head;
            ListNode pre = null;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next; //可以为null
                pre = slow;
                slow = slow.next;
            }

            //cut list
            if (pre != null)
            {
                pre.next = null;
            }


            TreeNode root = new TreeNode(slow.val);
            if (slow != head)
                root.left = buildHelper(head);
            root.right = buildHelper(slow.next);
            return root;
        }
    }
}
