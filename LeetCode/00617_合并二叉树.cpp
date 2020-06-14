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
617. 合并二叉树
https://leetcode-cn.com/problems/merge-two-binary-trees/
*/
class Solution {
public:
    TreeNode* mergeTrees(TreeNode* t1, TreeNode* t2) {
        if (t1 == nullptr && t2 == nullptr) return NULL;
        int v = (t1 == nullptr ? 0 : t1->val) + (t2 == nullptr ? 0 : t2->val);
        TreeNode* node = t1 == nullptr ? t2 : t1;
        node->val = v;
        node->left = mergeTrees(t1 == nullptr ? NULL : t1->left, t2 == nullptr ? NULL : t2->left);
        node->right = mergeTrees(t1 == nullptr ? NULL : t1->right, t2 == nullptr ? NULL : t2->right);
        return node;
    }
};