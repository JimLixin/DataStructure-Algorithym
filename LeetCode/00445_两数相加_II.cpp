/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

/*
445. 两数相加 II
https://leetcode-cn.com/problems/add-two-numbers-ii/
*/
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        string a, b, sum;
        while (l1 != nullptr && l2 != nullptr)
        {
            a += l1->val + 48;
            b += l2->val + 48;
            l1 = l1->next;
            l2 = l2->next;
        }
        while (l1 != nullptr)
        {
            a += l1->val + 48;
            l1 = l1->next;
        }
        while (l2 != nullptr)
        {
            b += l2->val + 48;
            l2 = l2->next;
        }
        sum = stringAdd(a, b);
        ListNode* head = new ListNode(0), * cur = head;
        for (auto c : sum)
        {
            cur->next = new ListNode(c - 48);
            cur = cur->next;
        }
        return head->next;
    }

    string stringAdd(string& a, string& b)
    {
        string res;
        int l1 = a.size(), l2 = b.size(), p1 = l1 - 1, p2 = l2 - 1, carry = 0;
        while (p1 >= 0 && p2 >= 0)
        {
            int tmp = carry + a[p1--] + b[p2--] - 96;
            res += tmp % 10 + 48;
            carry = tmp / 10;
        }
        while (p1 >= 0)
        {
            int tmp = carry + a[p1--] - 48;
            res += tmp % 10 + 48;
            carry = tmp / 10;
        }
        while (p2 >= 0)
        {
            int tmp = carry + b[p2--] - 48;
            res += tmp % 10 + 48;
            carry = tmp / 10;
        }
        if (carry > 0) res += '1';
        reverse(res.begin(), res.end());
        return res;
    }
};