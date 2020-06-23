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
1302. 层数最深叶子节点的和
https://leetcode-cn.com/problems/deepest-leaves-sum/
*/
class Solution {
public:
    int deepestLeavesSum(TreeNode* root) {
        int ans = 0;
        queue<TreeNode*> q;
        q.push(root);
        while (!q.empty())
        {
            int tmp = 0;
            int cnt = q.size();
            for (int i = 0; i < cnt; i++)
            {
                TreeNode* node = q.front();
                q.pop();
                tmp += node->val;
                if (node->left) q.push(node->left);
                if (node->right) q.push(node->right);
            }
            ans = tmp;
        }
        return ans;
    }
};