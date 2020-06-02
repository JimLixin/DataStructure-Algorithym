using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public class _00415_字符串相加
    {
        public string AddStrings(string num1, string num2)
        {
            if (string.IsNullOrEmpty(num1)) return num2;
            if (string.IsNullOrEmpty(num2)) return num1;
            StringBuilder sb = new StringBuilder();
            int carry = 0, p1 = num1.Length - 1, p2 = num2.Length - 1, x = 0, y = 0, sum = 0;
            while (p1 >= 0 && p2 >= 0)
            {
                x = num1[p1--] - 48;
                y = num2[p2--] - 48;
                sum = x + y + carry;
                carry = sum / 10;
                sb.Insert(0, (char)(sum % 10 + 48));
            }
            while (p1 >= 0)
            {
                x = num1[p1--] - 48;
                sum = x + carry;
                carry = sum / 10;
                sb.Insert(0, (char)(sum % 10 + 48));
            }
            while (p2 >= 0)
            {
                x = num2[p2--] - 48;
                sum = x + carry;
                carry = sum / 10;
                sb.Insert(0, (char)(sum % 10 + 48));
            }
            if (carry > 0) sb.Insert(0, 1);
            return sb.ToString();
        }
    }
}
