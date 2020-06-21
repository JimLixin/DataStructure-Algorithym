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
 124. 二叉树中的最大路径和
 https://leetcode-cn.com/problems/binary-tree-maximum-path-sum/
 */
class Solution {
public:
    int sum = INT_MIN;
    int maxPathSum(TreeNode* root) {
        dfs(root);
        return sum;
    }

    int dfs(TreeNode* root)
    {
        if (root == nullptr) return 0;
        int left = max(0, dfs(root->left));
        int right = max(0, dfs(root->right));
        sum = max(sum, left + root->val + right);
        return max(root->val + left, root->val + right);
    }
};