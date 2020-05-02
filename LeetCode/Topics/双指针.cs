using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Topics
{
    public class Remove_Duplicates
    {
        /// <summary>
        /// 删除排序数组中的重复项
        /// 注： 此例题要求的是删除后使每个元素最多不超过两次重复
        /// 我们可以实现一个更通用的方法 RemoveDuplicates(int[] nums, int k)
        /// 例子：https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array-ii/
        /// </summary>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int fast = 0, slow = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    count++;
                else
                    count = 1;
                nums[slow] = nums[fast];
                fast++;
                if (count <= 2)
                    slow++;
            }
            return slow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k">删除后使每个元素允许重复的最大次数</param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int fast = 0, slow = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    count++;
                else
                    count = 1;
                nums[slow] = nums[fast];
                fast++;
                if (count <= k)
                    slow++;
            }
            return slow;
        }

    }

    /// <summary>
    /// 283. 移动零
    /// Note：双指针
    /// https://leetcode-cn.com/problems/move-zeroes/
    /// </summary>
    public class move_zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int left = 0, right = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (right++ >= nums.Length) break;
                if (nums[i] != 0) left++;
                if (i < nums.Length - 1 && nums[i] == 0 && nums[i + 1] != 0)
                {
                    nums[right] = nums[right] ^ nums[left];
                    nums[left] = nums[right] ^ nums[left];
                    nums[right] = nums[right] ^ nums[left];
                    left++;
                }
            }
        }
    }

    /// <summary>
    /// 141. 环形链表
    /// https://leetcode-cn.com/problems/linked-list-cycle/
    /// </summary>
    public class linked_list_cycle
    {
        public bool HasCycle(ListNode head)
        {
            ListNode dumHead1 = new ListNode(0), dumHead2 = new ListNode(0), slow = dumHead1, fast = head;
            dumHead1.next = dumHead2;
            dumHead2.next = head;
            while (fast != null && fast.next != null)
            {
                if (fast == slow) return true;
                slow = slow.next;
                fast = fast.next.next;
            }
            return false;
        }
    }

    /// <summary>
    /// 167. 两数之和 II - 输入有序数组
    /// https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    public class two_sum_ii_input_array_is_sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return new int[0];
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                if (target == numbers[left] + numbers[right])
                    return new int[] { left + 1, right + 1 };
                if (target > numbers[left] + numbers[right])
                    left++;
                else
                    right--;
            }
            return new int[0];
        }
    }

    /// <summary>
    /// 234. 回文链表
    /// https://leetcode-cn.com/problems/palindrome-linked-list/
    /// </summary>
    public class palindrome_linked_list
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;
            ListNode slow = head, fast = head;
            Stack<int> s = new Stack<int>();
            while (true)
            {
                if (fast == null) break;
                if (fast.next == null)
                {
                    slow = slow.next;
                    break;
                }
                s.Push(slow.val);
                slow = slow.next;
                fast = fast.next.next;
            }
            while (s.Count > 0)
            {
                if (s.Pop() != slow.val)
                    return false;
                slow = slow.next;
            }
            return true;
        }
    }

    /// <summary>
    /// 344. 反转字符串
    /// https://leetcode-cn.com/problems/reverse-string/
    /// </summary>
    public class reverse_string
    {
        public void ReverseString(char[] s)
        {
            if (s == null || s.Length == 0) return;
            int left = 0, right = s.Length - 1;
            char tmp;
            while (left < right)
            {
                tmp = s[right];
                s[right] = s[left];
                s[left] = tmp;
                left++;
                right--;
            }
        }
    }

    /// <summary>
    /// 345. 反转字符串中的元音字母
    /// https://leetcode-cn.com/problems/reverse-vowels-of-a-string/
    /// </summary>
    public class reverse_vowels_of_a_string
    {
        public string ReverseVowels(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            HashSet<char> map = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            int left = 0, right = s.Length - 1;
            char[] str = s.ToCharArray();
            char tmp;
            bool flag1, flag2;
            while (left < right)
            {
                flag1 = map.Contains(str[left]);
                flag2 = map.Contains(str[right]);
                if (flag1 && flag2)
                {
                    tmp = str[right];
                    str[right] = str[left];
                    str[left] = tmp;
                    left++;
                    right--;
                }
                if (!flag1) left++;
                if (!flag2) right--;
            }
            return new String(str);
        }
    }
}
