using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 278. 第一个错误的版本
/// https://leetcode-cn.com/problems/first-bad-version/
/// </summary>
namespace Algorithym.LeetCode.二分查找
{
    public class _00278_first_bad_version
    {
        public bool IsBadVersion(int n)
        {
            return true;
        }

        /// <summary>
        /// 原始方法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FirstBadVersion(int n)
        {
            if (n < 1) return n;
            long start = 1, end = n, mid = -1;
            while (start < end)
            {
                mid = (start + end) >> 1;
                if (IsBadVersion((int)mid))
                    end = mid;
                else
                    start = mid + 1;
            }
            return (int)((start + end) >> 1);
        }

        /// <summary>
        /// 防止溢出的版本
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FirstBadVersionV2(int n)
        {
            if (n < 1) return n;
            int start = 1, end = n, mid = -1;
            while (start < end)
            {
                mid = start + (end - start) / 2;  //prevent overflow!
                if (IsBadVersion(mid))
                    end = mid;
                else
                    start = mid + 1;
            }
            return start;
        }
    }
}
