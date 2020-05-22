using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    /// </summary>
    public class construct_binary_tree_from_preorder_and_inorder_traversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0)
                return null;
            return makeTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }

        public TreeNode makeTree(int[] preOrder, int pStart, int pEnd, int[] inOrder, int iStart, int iEnd)
        {
            if (pStart > pEnd)
                return null;
            int val = preOrder[pStart], pivot = -1;
            TreeNode node = new TreeNode(val);
            if (pStart == pEnd)
                return node;
            pivot = Array.IndexOf(inOrder, val, iStart, iEnd - iStart + 1);
            node.left = makeTree(preOrder, pStart + 1, pStart + pivot - iStart, inOrder, iStart, pivot - 1);
            node.right = makeTree(preOrder, pStart + pivot - iStart + 1, pEnd, inOrder, pivot + 1, iEnd);
            return node;
        }
    }

    public class construct_binary_tree_from_preorder_and_inorder_traversalV2
    {
        int pre_idx = 0;
        int[] preorder;
        int[] inorder;
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {

            this.preorder = preorder;
            this.inorder = inorder;

            for (int i = 0; i < inorder.Length; i++)
            {
                indexMap.Add(inorder[i], i);
            }
            return TraverseTree(0, inorder.Length);
        }

        public TreeNode TraverseTree(int leftIndex, int rightIndex)
        {

            if (leftIndex == rightIndex)
                return null;

            var rootValue = preorder[pre_idx];
            var rootNode = new TreeNode(rootValue);
            var rootIndex = indexMap[rootValue];

            pre_idx++;

            rootNode.left = TraverseTree(leftIndex, rootIndex);
            rootNode.right = TraverseTree(rootIndex + 1, rightIndex);

            return rootNode;
        }
    }

    /// <summary>
    /// 第三遍做的代码
    /// </summary>
    public class construct_binary_tree_from_preorder_and_inorder_traversalV3
    {
        int[] _preorder;
        Dictionary<int, int> inOrderMap;
        int preIndex;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            _preorder = preorder;
            inOrderMap = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++) inOrderMap.Add(inorder[i], i);
            return build(0, inorder.Length - 1);
        }

        public TreeNode build(int start, int end)
        {
            if (start > end) return null;
            int val = _preorder[preIndex++], mid = inOrderMap[val];
            TreeNode node = new TreeNode(val);
            node.left = build(start, mid - 1);
            node.right = build(mid + 1, end);
            return node;
        }
    }
}
