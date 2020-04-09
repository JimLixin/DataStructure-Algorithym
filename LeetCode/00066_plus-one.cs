using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    public class plus_one
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return new int[] { 1 };
            int len = digits.Length;
            digits[len - 1] += 1;
            for (int i = len - 1; i > 0; i--)
            {
                if (digits[i] < 10)
                    break;
                digits[i - 1] += digits[i] / 10;
                digits[i] = digits[i] % 10;
            }
            if (digits[0] / 10 > 0)
            {
                digits[0] = digits[0] % 10;
                return (new int[] { 1 }).Concat(digits).ToArray();
            }
            return digits;
        }
    }
}
