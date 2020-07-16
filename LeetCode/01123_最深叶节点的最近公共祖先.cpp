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
1123. 最深叶节点的最近公共祖先
https://leetcode-cn.com/problems/lowest-common-ancestor-of-deepest-leaves/
*/
class Solution {
public:
    TreeNode* ancestor = nullptr;
    int max_depth = 0;

    int dfs(TreeNode* node, int depth)
    {
        if (node == nullptr) return depth - 1;
        int leftDepth = dfs(node->left, depth + 1);
        int rightDepth = dfs(node->right, depth + 1);
        max_depth = max(max_depth, max(leftDepth, rightDepth));
        if (leftDepth == max_depth && rightDepth == max_depth)
            ancestor = node;
        return max(leftDepth, rightDepth);
    }

    TreeNode* lcaDeepestLeaves(TreeNode* root) {
        max_depth = 0;
        ancestor = nullptr;
        dfs(root, 0);
        return ancestor;
    }
};