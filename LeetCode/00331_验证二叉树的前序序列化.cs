using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 331. 验证二叉树的前序序列化
/// https://leetcode-cn.com/problems/verify-preorder-serialization-of-a-binary-tree/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00331_验证二叉树的前序序列化
    {
        int index, len;
        string[] nodes;
        public bool IsValidSerialization(string preorder)
        {
            nodes = preorder.Split(",".ToCharArray());
            index = 0;
            len = nodes.Length;
            return dfs() && index == len;
        }

        public bool dfs()
        {
            if (index >= len) return false;
            return nodes[index++] == "#" ? true : dfs() && dfs();
        }
    }
}
