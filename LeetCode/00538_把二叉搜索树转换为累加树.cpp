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
538. 把二叉搜索树转换为累加树
https://leetcode-cn.com/problems/convert-bst-to-greater-tree/
*/

/*
原始版本（中序遍历两次）
*/
class Solution {
public:
    TreeNode* convertBST(TreeNode* root) {
        stack<TreeNode*> s;
        TreeNode* node = root;
        vector<int> prefix;
        while (node != nullptr || !s.empty())
        {
            while (node != nullptr)
            {
                s.push(node);
                node = node->left;
            }
            node = s.top();
            s.pop();
            int item = (prefix.size() == 0 ? 0 : prefix.back()) + node->val;
            prefix.push_back(item);
            node = node->right;
        }
        int n = prefix.size(), cur = 0;
        node = root;
        while (node != nullptr || !s.empty())
        {
            while (node != nullptr)
            {
                s.push(node);
                node = node->left;
            }
            node = s.top();
            s.pop();
            node->val += prefix[n - 1] - prefix[cur++];
            node = node->right;
        }
        return root;
    }
};
/*
反序中序遍历（递归）
*/
class Solution2 {
private:
    int sum = 0;
public:
    TreeNode* convertBST(TreeNode* root) {
        if (root != NULL)
        {
            convertBST(root->right);
            sum += root->val;
            root->val = sum;
            //cout << root->val << endl;
            convertBST(root->left);
        }
        return root;
    }
};

/*
反序中序遍历（迭代）
*/
class Solution3 {
public:
    TreeNode* convertBST(TreeNode* root) {
        int sum = 0;
        stack<TreeNode*> s;
        TreeNode* node = root;
        while (node != NULL || !s.empty())
        {
            while (node != NULL)
            {
                s.push(node);
                node = node->right;
            }
            node = s.top();
            s.pop();
            sum += node->val;
            node->val = sum;
            node = node->left;
        }
        return root;
    }
};