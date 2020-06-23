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
429. N叉树的层序遍历
https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/
*/
class Solution {
public:
    vector<vector<int>> levelOrder(Node* root) {
        if (root == nullptr) return {};
        vector<vector<int>> res;
        queue<Node*> q;
        q.push(root);
        while (!q.empty())
        {
            int cnt = q.size();
            vector<int> data(cnt);
            for (int i = 0; i < cnt; i++)
            {
                Node* tmp = q.front();
                q.pop();
                data[i] = tmp->val;
                for (auto c : tmp->children) q.push(c);
            }
            res.push_back(data);
        }
        return res;
    }
};