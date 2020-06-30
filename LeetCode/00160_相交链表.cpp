/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

/*
160. 相交链表
https://leetcode-cn.com/problems/intersection-of-two-linked-lists/
*/
class Solution {
public:
    ListNode* getIntersectionNode(ListNode* headA, ListNode* headB) {
        if (!headA || !headB) return nullptr;
        ListNode* a = headA, * b = headB;
        while (a != b)
        {
            a = a ? a->next : headB;
            b = b ? b->next : headA;
        }
        return a;
    }
};