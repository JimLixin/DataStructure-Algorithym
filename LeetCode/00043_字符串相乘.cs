using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 43. 字符串相乘
/// https://leetcode-cn.com/problems/multiply-strings/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00043_字符串相乘
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            if (num1 == "1") return num2;
            if (num2 == "1") return num1;
            string result = "";
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine($"{num1[i]},{num1.Length - 1 - i},{num2}");
                result = StringAdd(result, StringMultiply(num1[i], num1.Length - 1 - i, num2));
            }
            return result;
        }

        public string StringMultiply(char a, int zeros, string b)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                sb.Clear();
                sb.Append((a - 48) * (b[i] - 48));
                for (int k = b.Length - 1 - i; k > 0; k--) sb.Append('0');
                //Console.WriteLine($"Add {result} and {sb.ToString()}");
                result = StringAdd(result, sb.ToString());
            }
            for (int n = zeros; n > 0; n--) result += '0';
            return result;
        }

        public string StringAdd(string a, string b)
        {
            if (string.IsNullOrEmpty(a)) return b;
            if (string.IsNullOrEmpty(b)) return a;
            StringBuilder sb = new StringBuilder();
            int carry = 0, p1 = a.Length - 1, p2 = b.Length - 1, x = 0, y = 0, sum = 0;
            while (p1 >= 0 && p2 >= 0)
            {
                x = a[p1--] - 48;
                y = b[p2--] - 48;
                sum = x + y + carry;
                carry = sum / 10;
                sb.Insert(0, (char)(sum % 10 + 48));
            }
            while (p1 >= 0)
            {
                x = a[p1--] - 48;
                sum = x + carry;
                carry = sum / 10;
                sb.Insert(0, (char)(sum % 10 + 48));
            }
            while (p2 >= 0)
            {
                x = b[p2--] - 48;
                sum = x + carry;
                carry = sum / 10;
                sb.Insert(0, (char)(sum % 10 + 48));
            }
            if (carry > 0) sb.Insert(0, 1);
            return sb.ToString();
        }
    }
}
