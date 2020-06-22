/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

/*
876. 链表的中间结点
https://leetcode-cn.com/problems/middle-of-the-linked-list/
*/
class Solution {
public:
    ListNode* middleNode(ListNode* head) {
        ListNode* fast = head, * slow = head;
        while (fast != nullptr && fast->next != nullptr)
        {
            fast = fast->next->next;
            slow = slow->next;
        }
        return slow;
    }
};