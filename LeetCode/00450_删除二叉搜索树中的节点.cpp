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
450. 删除二叉搜索树中的节点
https://leetcode-cn.com/problems/delete-node-in-a-bst/
*/
class Solution {
public:
    TreeNode* deleteNode(TreeNode* root, int key) {
        if (root == nullptr) return root;
        TreeNode* node = root;
        if (node->val == key)
        {
            if (node->left == nullptr && node->right == nullptr)
                return nullptr;
            else if (node->left != nullptr)
            {
                int max = getMaxFromLeft(node);
                node->val = max;
                node->left = deleteNode(node->left, max);
            }
            else
            {
                int min = getMinFromRight(node);
                node->val = min;
                node->right = deleteNode(node->right, min);
            }
        }
        else if (node->val > key)
            node->left = deleteNode(node->left, key);
        else
            node->right = deleteNode(node->right, key);
        return root;
    }

    int getMinFromRight(TreeNode* node)
    {
        node = node->right;
        while (node->left != nullptr) node = node->left;
        return node->val;
    }

    int getMaxFromLeft(TreeNode* node)
    {
        node = node->left;
        while (node->right != nullptr) node = node->right;
        return node->val;
    }
};