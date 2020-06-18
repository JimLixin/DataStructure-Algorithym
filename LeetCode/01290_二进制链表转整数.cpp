/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

/*
1290. 二进制链表转整数
https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
*/
class Solution {
public:
    int getDecimalValue(ListNode* head) {
        int res = 0;
        while (head != nullptr)
        {
            res = res * 2 + head->val;
            head = head->next;
        }
        return res;
    }
};