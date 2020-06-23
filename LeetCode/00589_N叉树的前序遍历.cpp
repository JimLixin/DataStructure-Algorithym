/*
// Definition for a Node.
class Node {
public:
    int val;
    vector<Node*> children;

    Node() {}

    Node(int _val) {
        val = _val;
    }

    Node(int _val, vector<Node*> _children) {
        val = _val;
        children = _children;
    }
};
*/

/*
589. N叉树的前序遍历
https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/
*/

/*
递归版本
*/
class Solution {
public:
    vector<int> preorder(Node* root) {
        if (root == nullptr) return {};
        vector<int> res;
        dfs(res, root);
        return res;
    }

    void dfs(vector<int>& data, Node* node)
    {
        data.push_back(node->val);
        for (auto child : node->children)
        {
            dfs(data, child);
        }
    }
};

/*
迭代版本
*/
class Solution2 {
public:
    vector<int> preorder(Node* root) {
        if (root == nullptr) return {};
        vector<int> res;
        Node* node = root;
        stack<Node*> s;
        while (!s.empty() || node != nullptr)
        {
            if (node == nullptr)
            {
                node = s.top();
                s.pop();
            }
            res.push_back(node->val);
            if (!node->children.empty())
            {
                for (int i = node->children.size() - 1; i > 0; i--) s.push(node->children[i]);
                node = node->children[0];
            }
            else
                node = nullptr;
        }
        return res;
    }
};