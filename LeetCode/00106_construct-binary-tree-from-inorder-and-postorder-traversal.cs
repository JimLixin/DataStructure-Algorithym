using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public class construct_binary_tree_from_inorder_and_postorder_traversal
    {
        Dictionary<int, int> dic = null;
        int[] inOrder = null;
        int[] postOrder = null;
        int postIndex = 0;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            dic = new Dictionary<int, int>();
            inOrder = inorder;
            postOrder = postorder;
            postIndex = postorder.Length - 1;
            for (int i = 0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }
            return buildTree(0, postorder.Length);
        }

        public TreeNode buildTree(int left, int right)
        {
            if (left == right)
                return null;
            //Console.WriteLine($"left:{left}, right:{right}, postIndex:{postIndex}");
            int val = postOrder[postIndex];
            int mid = dic[val];
            TreeNode node = new TreeNode(val);
            //Console.WriteLine($"New node {val}, mid:{mid}. Left tree: {left}->{mid}, right tree: {mid+1}->{right}");
            postIndex--;
            node.right = buildTree(mid + 1, right);
            node.left = buildTree(left, mid);

            return node;
        }
    }
}
