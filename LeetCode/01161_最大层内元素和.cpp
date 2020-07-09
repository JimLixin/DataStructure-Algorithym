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
1161. 最大层内元素和
https://leetcode-cn.com/problems/maximum-level-sum-of-a-binary-tree/
*/
class Solution {
public:
    int maxLevelSum(TreeNode* root) {
        int maxSum = INT_MIN, minLevel = INT_MAX, cur = 1;
        queue<TreeNode*> q;
        q.push(root);
        while (!q.empty())
        {
            int cnt = q.size(), sum = 0;
            for (int i = 0; i < cnt; i++)
            {
                TreeNode* node = q.front();
                q.pop();
                sum += node->val;
                if (node->left != nullptr)
                    q.push(node->left);
                if (node->right != nullptr)
                    q.push(node->right);
            }
            cout << "Sum:" << sum << ", cur level: " << cur << endl;
            if (sum > maxSum)
            {
                maxSum = sum;
                minLevel = cur;
            }
            else if (sum == maxSum)
            {
                minLevel = min(minLevel, cur);
            }
            cur++;
        }
        return minLevel;
    }
};