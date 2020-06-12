using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 165. 比较版本号
/// https://leetcode-cn.com/problems/compare-version-numbers/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00165_比较版本号
    {
        public int CompareVersion(string version1, string version2)
        {
            var arr1 = version1.Split(new char[] { '.' }).Select(i => Convert.ToInt32(i)).ToArray();
            var arr2 = version2.Split(new char[] { '.' }).Select(i => Convert.ToInt32(i)).ToArray();
            int p1 = 0, p2 = 0, n1 = arr1.Length, n2 = arr2.Length;
            while (p1 < n1 || p2 < n2)
            {
                if (p1 < n1 && p2 < n2)
                {
                    if (arr1[p1] > arr2[p2])
                        return 1;
                    else if (arr1[p1] < arr2[p2])
                        return -1;
                    else
                    {
                        p1++;
                        p2++;
                    }
                }
                else
                {
                    if (p1 < n1 && arr1[p1] == 0 || p2 < n2 && arr2[p2] == 0)
                    {
                        p1++;
                        p2++;
                    }
                    else
                        return p1 < n1 ? 1 : -1;
                }
            }
            return 0;
        }
    }
}
