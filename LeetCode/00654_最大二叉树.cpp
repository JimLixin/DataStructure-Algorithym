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
654. 最大二叉树
https://leetcode-cn.com/problems/maximum-binary-tree/
*/
class Solution {
public:
    TreeNode* constructMaximumBinaryTree(vector<int>& nums) {
        if (nums.empty()) return nullptr;
        return helper(nums, nums.begin(), nums.end());
    }

    TreeNode* helper(vector<int>& nums, vector<int>::iterator start, vector<int>::iterator end)
    {
        if (start >= end) return nullptr;
        auto maxPos = max_element(start, end);
        TreeNode* root = new TreeNode(*maxPos);
        root->left = helper(nums, start, maxPos);
        root->right = helper(nums, maxPos + 1, end);
        return root;
    }
};