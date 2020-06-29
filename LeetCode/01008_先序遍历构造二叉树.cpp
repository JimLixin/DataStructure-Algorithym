/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */

/*
1008. 先序遍历构造二叉树
https://leetcode-cn.com/problems/construct-binary-search-tree-from-preorder-traversal/
*/
class Solution {
public:
    TreeNode* bstFromPreorder(vector<int>& preorder) {
        return build(preorder, 0, preorder.size() - 1);
    }

    TreeNode* build(vector<int>& preorder, int start, int end)
    {
        if (start > end) return nullptr;
        TreeNode* root = new TreeNode(preorder[start]);
        int index = start;
        for (; index <= end; index++)
        {
            if (preorder[index] > preorder[start]) break;
        }
        root->left = build(preorder, start + 1, index - 1);
        root->right = build(preorder, index, end);
        return root;
    }
};