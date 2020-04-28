/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */

//面试题68 - II. 二叉树的最近公共祖先
//https://leetcode-cn.com/problems/er-cha-shu-de-zui-jin-gong-gong-zu-xian-lcof/
class Solution {
public:
	TreeNode* lowestCommonAncestor(TreeNode* root, TreeNode* p, TreeNode* q) {
		if (root == NULL || p->val == root->val || q->val == root->val)
			return root;

		TreeNode * leftNode = lowestCommonAncestor(root->left, p, q);
		TreeNode * rightNode = lowestCommonAncestor(root->right, p, q);
		if (leftNode == NULL && rightNode == NULL) return NULL;
		if (leftNode == NULL) return rightNode;
		if (rightNode == NULL) return leftNode;
		return root;
	}
};