/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;

    Node() {}

    Node(int _val) {
        val = _val;
        left = NULL;
        right = NULL;
    }

    Node(int _val, Node* _left, Node* _right) {
        val = _val;
        left = _left;
        right = _right;
    }
};
*/


/*
面试题36. 二叉搜索树与双向链表
https://leetcode-cn.com/problems/er-cha-sou-suo-shu-yu-shuang-xiang-lian-biao-lcof/
*/
class Solution {
public:
    Node* treeToDoublyList(Node* root) {
        if (!root) return root;
        stack<Node*> s;
        Node* node = root, * head = nullptr, * pre = nullptr;
        while (!s.empty() || node != NULL)
        {
            while (node != NULL)
            {
                s.push(node);
                node = node->left;
            }
            node = s.top();
            s.pop();
            if (pre == nullptr)
            {
                pre = node;
                head = node;
            }
            else
            {
                pre->right = node;
                node->left = pre;
                pre = node;
            }
            node = node->right;
        }
        pre->right = head;
        head->left = pre;
        return head;
    }
};