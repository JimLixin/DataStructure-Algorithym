using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 179. 最大数
/// https://leetcode-cn.com/problems/largest-number/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00179_最大数
    {
        public string LargestNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return "";
            Array.Sort(nums, new NumCompare());
            if (nums[0] == 0) return "0";
            return string.Join("", nums);
        }
    }

    class NumCompare : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y) return 0;
            string strX = x.ToString(), strY = y.ToString();
            string a = strX + strY, b = strY + strX;
            return b.CompareTo(a);
        }
    }
}
