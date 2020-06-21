/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

//83. 删除排序链表中的重复元素
//https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/
class Solution {
public:
	ListNode* deleteDuplicates(ListNode* head) {
		ListNode* dumHead = new ListNode(0), * current = dumHead, * previous = NULL;
		dumHead->next = head;

		while (current != NULL)
		{
			if (previous != dumHead && previous != NULL && previous->val == current->val)
				previous->next = current->next;
			else
				previous = current;
			current = current->next;
		}
		return dumHead->next;
	}
};