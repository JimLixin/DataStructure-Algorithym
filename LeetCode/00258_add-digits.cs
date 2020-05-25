using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 258. 各位相加
/// https://leetcode-cn.com/problems/add-digits/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00258_add_digits
    {
        public int AddDigits(int num)
        {
            while (num >= 10)
            {
                int result = 0;
                while (num != 0)
                {
                    result += num % 10;
                    num /= 10;
                }
                num = result;
            }
            return num;
        }
    }
}
