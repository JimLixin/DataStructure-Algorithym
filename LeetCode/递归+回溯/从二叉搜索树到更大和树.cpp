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
 1038. 从二叉搜索树到更大和树
 https://leetcode-cn.com/problems/binary-search-tree-to-greater-sum-tree/
 */
class Solution {
public:
    TreeNode* bstToGst(TreeNode* root) {
        int sum = 0;
        helper(root, sum);
        return root;
    }

    void helper(TreeNode* node, int& sum)
    {
        if (node == nullptr) return;
        helper(node->right, sum);
        sum += node->val;
        node->val = sum;
        helper(node->left, sum);
    }
};
