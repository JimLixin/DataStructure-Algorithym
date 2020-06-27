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
    //哈希表额外空间
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

    //不使用额外空间
    Node* copyRandomListV2(Node* head) {
        if (head == nullptr) return nullptr;
        Node* cur = head;
        while (cur != nullptr)
        {
            Node* tmp = cur->next;
            cur->next = new Node(cur->val);
            cur->next->next = tmp;
            cur = tmp;
        }
        Node* newHead = new Node(0), * tail = newHead, * next = nullptr;
        cur = head;
        while (cur != nullptr)
        {
            cur->next->random = cur->random ? cur->random->next : nullptr;
            cur = cur->next->next;
        }
        cur = head;
        while (cur != nullptr)
        {
            Node* tmp = cur->next;
            cur->next = tmp->next;
            tail->next = tmp;
            tail = tail->next;
            cur = cur->next;
        }
        return newHead->next;
    }
};