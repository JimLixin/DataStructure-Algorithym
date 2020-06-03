using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 89. 格雷编码
/// https://leetcode-cn.com/problems/gray-code/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00089_格雷编码
    {
        /// <summary>
        /// 使用栈实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<int> GrayCode(int n)
        {
            int k = 0;
            Stack<int> s = new Stack<int>();
            s.Push(0);

            while (k < n)
            {
                var arr = s.ToArray();
                foreach (int i in arr)
                {
                    s.Push(i + (int)Math.Pow(2, k));
                }
                k++;
            }
            var result = s.ToList();
            result.Reverse();
            return result;
        }
    }
}
