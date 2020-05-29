using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 341. 扁平化嵌套列表迭代器
/// https://leetcode-cn.com/problems/flatten-nested-list-iterator/
/// </summary>
namespace Algorithym.LeetCode
{
    public interface NestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class NestedIterator
    {
        private Queue<int> q;
        public NestedIterator(IList<NestedInteger> nestedList)
        {
            q = new Queue<int>();
            build(nestedList);
        }

        private void build(IList<NestedInteger> nestedList)
        {
            foreach (NestedInteger item in nestedList)
            {
                if (item.IsInteger())
                    q.Enqueue(item.GetInteger());
                else
                    build(item.GetList());
            }
        }

        public bool HasNext()
        {
            return q.Count > 0;
        }

        public int Next()
        {
            return q.Dequeue();
        }
    }
}
