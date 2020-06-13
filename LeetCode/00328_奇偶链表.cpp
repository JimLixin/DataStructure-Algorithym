/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

/*
328. 奇偶链表
https://leetcode-cn.com/problems/odd-even-linked-list/
*/
class Solution {
public:
    ListNode* oddEvenList(ListNode* head) {
        if (head == nullptr) return head;
        ListNode* p1 = head, * h2 = head->next, * p2 = h2;
        while (p2 && p2->next)
        {
            p1->next = p2->next;
            p1 = p2->next;
            p2->next = p1->next;
            p2 = p1->next;
        }
        p1->next = h2;
        return head;
    }
};