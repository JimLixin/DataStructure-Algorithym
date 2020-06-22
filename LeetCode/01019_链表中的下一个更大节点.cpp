/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */

/*
1019. 链表中的下一个更大节点
https://leetcode-cn.com/problems/next-greater-node-in-linked-list/
*/
class Solution {
public:
    vector<int> nextLargerNodes(ListNode* head) {
        if (head == nullptr) return vector<int>();
        int cnt = 0;
        ListNode* pre = nullptr, * cur = head;
        while (cur != nullptr)
        {
            ListNode* tmp = cur->next;
            cur->next = pre;
            pre = cur;
            cur = tmp;
            cnt++;
        }
        stack<int> s;
        vector<int> ans(cnt);
        while (pre != nullptr)
        {
            while (!s.empty() && s.top() <= pre->val) s.pop();
            cnt--;
            ans[cnt] = s.empty() ? 0 : s.top();
            s.push(pre->val);
            pre = pre->next;
        }
        return ans;
    }
};