﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 297. 二叉树的序列化与反序列化
/// https://leetcode-cn.com/problems/serialize-and-deserialize-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00297_二叉树的序列化与反序列化
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return string.Empty;
            StringBuilder sb = new StringBuilder();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int cnt = q.Count;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode node = q.Dequeue();
                    sb.Append(node == null ? "null" : node.val.ToString());
                    sb.Append(',');
                    //Console.WriteLine(sb.ToString());
                    if (node != null)
                    {
                        q.Enqueue(node.left);
                        q.Enqueue(node.right);
                    }
                }
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Insert(0, "[");
            sb.Append("]");
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;
            string[] nodes = data.Substring(1, data.Length - 2).Split(",".ToCharArray());
            if (nodes.Length == 0) return null;
            //Console.WriteLine(string.Join(",",nodes));
            int i = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode root = new TreeNode(int.Parse(nodes[i++]));
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int cnt = q.Count;
                for (int j = 0; j < cnt; j++)
                {
                    TreeNode node = q.Dequeue();
                    node.left = nodes[i] == "null" ? null : new TreeNode(int.Parse(nodes[i]));
                    i++;
                    node.right = nodes[i] == "null" ? null : new TreeNode(int.Parse(nodes[i]));
                    i++;
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
            }
            return root;
        }
    }
}
