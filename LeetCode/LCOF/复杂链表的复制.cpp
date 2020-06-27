/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* next;
    Node* random;

    Node(int _val) {
        val = _val;
        next = NULL;
        random = NULL;
    }
};
*/

/*
剑指 Offer 35. 复杂链表的复制
https://leetcode-cn.com/problems/fu-za-lian-biao-de-fu-zhi-lcof/
*/
class Solution {
public:
    Node* copyRandomList(Node* head) {
        if (head == nullptr) return nullptr;
        Node* cur = head;
        unordered_map<Node*, Node*> map;
        while (cur != nullptr)
        {
            map[cur] = new Node(cur->val);
            cur = cur->next;
        }
        cur = head;
        while (cur != nullptr)
        {
            map[cur]->next = map[cur->next];
            map[cur]->random = map[cur->random];
            cur = cur->next;
        }
        return map[head];
    }
};