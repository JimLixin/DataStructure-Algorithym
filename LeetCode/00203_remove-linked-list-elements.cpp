/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

//https://leetcode.com/problems/remove-linked-list-elements/
class Solution {
public:
	ListNode* removeElements(ListNode* head, int val) {
		ListNode* dumHead = new ListNode(0);
		dumHead->next = head;
		ListNode* current = dumHead->next, * previous = dumHead;

		while (current)
		{
			if (current->val == val)
				previous->next = current->next;
			else
				previous = previous->next;
			current = current->next;
		}
		return dumHead->next;
	}
};