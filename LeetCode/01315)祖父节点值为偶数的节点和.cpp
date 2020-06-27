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
1315. 祖父节点值为偶数的节点和
https://leetcode-cn.com/problems/sum-of-nodes-with-even-valued-grandparent/
*/
class Solution {
public:
    int sumEvenGrandparent(TreeNode* root) {
        int res = 0;
        dfs(root, nullptr, nullptr, res);
        return res;
    }

    void dfs(TreeNode* node, TreeNode* parent, TreeNode* grand, int& res)
    {
        if (node == nullptr) return;
        if (grand && (grand->val & 1) == 0)
            res += node->val;
        dfs(node->left, node, parent, res);
        dfs(node->right, node, parent, res);
    }
};