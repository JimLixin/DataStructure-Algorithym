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
1028. 从先序遍历还原二叉树
https://leetcode-cn.com/problems/recover-a-tree-from-preorder-traversal/
*/
class Solution {
public:
    TreeNode* recoverFromPreorder(string S) {
        int pos = 0;
        stack<TreeNode*> s;
        while (pos < S.size())
        {
            int level = 0;
            while (S[pos] == '-')
            {
                ++level;
                ++pos;
            }
            int val = 0;
            while (pos < S.size() && S[pos] != '-')
            {
                val = val * 10 + (S[pos] - '0');
                ++pos;
            }
            TreeNode* node = new TreeNode(val);
            if (level == s.size())
            {
                if (!s.empty())
                    s.top()->left = node;
            }
            else
            {
                while (level != s.size())
                {
                    s.pop();
                }
                s.top()->right = node;
            }
            s.push(node);
        }
        while (s.size() > 1)
        {
            s.pop();
        }
        return s.top();
    }
};