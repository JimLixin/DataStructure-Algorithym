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
1261. 在受污染的二叉树中查找元素
https://leetcode-cn.com/problems/find-elements-in-a-contaminated-binary-tree/
*/
class FindElements {
private:
    unordered_set<int> data;
    TreeNode* _root;
    void recover(TreeNode* root, int val)
    {
        root->val = val;
        data.insert(val);
        if (root->left) recover(root->left, val * 2 + 1);
        if (root->right) recover(root->right, val * 2 + 2);
    }
public:
    FindElements(TreeNode* root) {
        _root = root;
        recover(_root, 0);
    }

    bool find(int target) {
        return data.count(target);
    }
};

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements* obj = new FindElements(root);
 * bool param_1 = obj->find(target);
 */