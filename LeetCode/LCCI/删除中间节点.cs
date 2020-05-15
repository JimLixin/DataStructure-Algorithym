using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 02.03. 删除中间节点
/// https://leetcode-cn.com/problems/delete-middle-node-lcci/
/// </summary>
namespace Algorithym.LeetCode.LCCI
{
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
