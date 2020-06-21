using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 29. 两数相除
/// https://leetcode-cn.com/problems/divide-two-integers/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00029_divide_two_integers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 1) return dividend;
            if (divisor == -1 && dividend == int.MinValue) return int.MaxValue;
            long result, a = dividend, b = divisor;
            if (dividend > 0 && divisor > 0)
                result = div(a, b);
            else if (dividend < 0 && divisor < 0)
                result = div(-a, -b);
            else
                result = -div(Math.Abs(a), Math.Abs(b));
            return (int)result;
        }

        public long div(long a, long b)
        {
            if (a < b) return 0;

            int i = 1;
            while (a > (b << i))
            {
                i <<= 1;
            }
            //Console.WriteLine($"a:{a}, b:{b},i:{i}");
            return (1 << (i >> 1)) + div(a - (b << (i >> 1)), b);
        }
    }
}
