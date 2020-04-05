/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

//https://leetcode.com/problems/swap-nodes-in-pairs/
class Solution {
public:
	ListNode* swapPairs(ListNode* head) {
		if (head == NULL)
			return head;
		ListNode * swap1 = head;
		ListNode * dummyHead = new ListNode(0), *previous = dummyHead;
		dummyHead->next = head;
		while (swap1 && swap1->next)
		{
			previous->next = swap1->next;
			swap1->next = swap1->next->next;
			previous->next->next = swap1;

			previous = swap1;
			swap1 = previous->next;
		}
		return dummyHead->next;
	}
};