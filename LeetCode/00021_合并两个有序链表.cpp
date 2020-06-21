/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

/*
21. 合并两个有序链表
https://leetcode-cn.com/problems/merge-two-sorted-lists/
*/
class Solution {
public:
	ListNode* mergeTwoLists(ListNode* l1, ListNode* l2) {
		ListNode* tmp;

		ListNode* head = new ListNode(0);
		head->next = l1;

		ListNode* previousL1 = head;
		ListNode* currentL1 = l1;
		ListNode* currentL2 = l2;
		while (currentL2 != NULL)
		{
			if (currentL1 == NULL)
			{
				previousL1->next = currentL2;
				break;
			}
			if (currentL2->val <= currentL1->val)
			{
				tmp = currentL2->next;
				currentL2->next = currentL1;
				previousL1->next = currentL2;
				currentL2 = tmp;
			}
			currentL1 = currentL1->next;
			previousL1 = previousL1->next;
		}
		return head->next;
	}
};