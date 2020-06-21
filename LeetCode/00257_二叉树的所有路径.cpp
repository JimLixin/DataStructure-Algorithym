/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */

/*
257. 二叉树的所有路径
https://leetcode-cn.com/problems/binary-tree-paths/
*/
class Solution {
public:

    vector<string> binaryTreePaths(TreeNode* root) {
        vector<string> res;
        string path;
        dfs(root, path, res);
        return res;
    }

    void dfs(TreeNode* node, string path, vector<string>& res)
    {
        if (node == nullptr) return;
        path.append(to_string(node->val));
        path.append("->");
        if (node->left == nullptr && node->right == nullptr)
        {
            path.erase(path.size() - 2);
            res.push_back(path);
        }
        dfs(node->left, path, res);
        dfs(node->right, path, res);
    }
};