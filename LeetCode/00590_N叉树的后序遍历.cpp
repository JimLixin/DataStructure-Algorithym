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
590. N叉树的后序遍历
https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/
*/

//递归版本
class Solution {
public:
    vector<int> postorder(Node* root) {
        if (root == nullptr) return {};
        vector<int> res;
        dfs(res, root);
        return res;
    }

    void dfs(vector<int>& data, Node* node)
    {
        for (auto c : node->children)
        {
            dfs(data, c);
        }
        data.push_back(node->val);
    }
};

//迭代版本
class Solution2 {
public:
    vector<int> postorder(Node* root) {
        if (root == nullptr) return {};
        vector<int> res;
        stack<Node*> s;
        unordered_set<Node*> visited;
        Node* node = root;
        while (!s.empty() || node != nullptr)
        {
            if (node == nullptr)
            {
                node = s.top();
                s.pop();
            }
            if (visited.find(node) == visited.end() && !node->children.empty())
            {
                s.push(node);
                visited.insert(node);
                for (int i = node->children.size() - 1; i > 0; i--) s.push(node->children[i]);
                node = node->children[0];
            }
            else
            {
                res.push_back(node->val);
                node = nullptr;
            }
        }
        return res;
    }
};