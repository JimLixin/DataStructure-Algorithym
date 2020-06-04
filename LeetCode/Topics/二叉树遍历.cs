using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Topics
{
    /*
    先序遍历:
     class Solution {
public:
    vector<int> preorderTraversal(TreeNode* root) {
        vector<int> res;  //保存结果
        stack<TreeNode*> call;  //调用栈
        if(root!=nullptr) call.push(root);  //首先介入root节点
        while(!call.empty()){
            TreeNode *t = call.top();
            call.pop();  //访问过的节点弹出
            if(t!=nullptr){
                if(t->right) call.push(t->right);  //右节点先压栈，最后处理
                if(t->left) call.push(t->left);
                call.push(t);  //当前节点重新压栈（留着以后处理），因为先序遍历所以最后压栈
                call.push(nullptr);  //在当前节点之前加入一个空节点表示已经访问过了
            }else{  //空节点表示之前已经访问过了，现在需要处理除了递归之外的内容
                res.push_back(call.top()->val);  //call.top()是nullptr之前压栈的一个节点，也就是上面call.push(t)中的那个t
                call.pop();  //处理完了，第二次弹出节点（彻底从栈中移除）
            }
        }
        return res;
    }

    后序遍历:
    class Solution {
public:
    vector<int> postorderTraversal(TreeNode* root) {
        vector<int> res;
        stack<TreeNode*> call;
        if(root!=nullptr) call.push(root);
        while(!call.empty()){
            TreeNode *t = call.top();
            call.pop();
            if(t!=nullptr){
                call.push(t);  //在右节点之前重新插入该节点，以便在最后处理（访问值）
                call.push(nullptr); //nullptr跟随t插入，标识已经访问过，还没有被处理
                if(t->right) call.push(t->right);
                if(t->left) call.push(t->left);
            }else{
                res.push_back(call.top()->val);
                call.pop();
            }
        }
        return res;   
    }
};

};
         */
    class 二叉树遍历
    {
        public int[] InOrderTravesal(TreeNode root)
        {
            List<int> data = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || s.Count > 0)
            {
                while (node != null)
                {
                    s.Push(node);
                    node = node.left;
                }
                node = s.Pop();
                data.Add(node.val);
                node = node.right;
            }
            return data.ToArray();
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || s.Count > 0)
            {
                if (node == null)
                    node = s.Pop();
                result.Add(node.val);
                if (node.right != null)
                    s.Push(node.right);
                node = node.left;
            }
            return result;
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            while (s.Count > 0)
            {
                TreeNode node = s.Peek();
                if (node == null)
                {
                    s.Pop();    //弹出null指针
                    result.Add(s.Pop().val);    //保存当前节点
                    continue;
                }
                s.Push(null);   //压入null指针
                if (node.right != null)
                    s.Push(node.right);
                if (node.left != null)
                    s.Push(node.left);
            }
            return result;
        }
    }
}
