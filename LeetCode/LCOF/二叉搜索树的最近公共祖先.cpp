/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */

//面试题68 - I. 二叉搜索树的最近公共祖先
//https://leetcode-cn.com/problems/er-cha-sou-suo-shu-de-zui-jin-gong-gong-zu-xian-lcof/
class Solution {
public:
	TreeNode* lowestCommonAncestor(TreeNode* root, TreeNode* p, TreeNode* q) {
		if (p->val > root->val && q->val > root->val)
			return lowestCommonAncestor(root->right, p, q);
		if (p->val < root->val && q->val < root->val)
			return lowestCommonAncestor(root->left, p, q);
		return root;
	}
};