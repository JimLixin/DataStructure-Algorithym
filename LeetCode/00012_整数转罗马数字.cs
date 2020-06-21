using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 12. 整数转罗马数字
    /// https://leetcode-cn.com/problems/integer-to-roman/
    /// </summary>
    public static class IntegerToRoman
    {
        public static string Answer(int num)
        {
            int[] metrics = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
            int digitCount = 0, metric = 0, prefix = 0;
            bool needPrefix = false;
            string output = "";

            for (int i = 0; i < metrics.Length; i++)
            {
                if (num <= 0)
                    break;

                metric = metrics[i];
                digitCount = num / metric;
                if (i == metrics.Length - 1)
                {
                    //Less than 4
                    output += GetRommanDigit(metric, digitCount, false);
                    break;
                }
                prefix = metrics[i % 2 == 0 ? (i + 2) : (i + 1)];
                needPrefix = ((num - num % prefix) == (metric - prefix));

                if (digitCount == 0 && !needPrefix)
                    continue;

                output += GetRommanDigit(metric, digitCount, needPrefix);
                num -= (needPrefix ? (metric - prefix) : digitCount * metric);

                if (i % 2 == 0 && !needPrefix)
                {
                    needPrefix = ((num - num % prefix) == (metric - prefix));
                    if (needPrefix)
                    {
                        output += GetRommanDigit(metric, digitCount, needPrefix);
                        num -= (metric - prefix);
                    }
                }
            }


            return output;
        }

        public static string GetRommanDigit(int metric, int digitCount, bool needPrefix)
        {
            switch (metric)
            {
                case 1:
                    return String.Concat(Enumerable.Repeat("I", digitCount));
                case 5:
                    return needPrefix ? "IV" : "V";
                case 10:
                    return needPrefix ? "IX" : String.Concat(Enumerable.Repeat("X", digitCount));
                case 50:
                    return needPrefix ? "XL" : "L";
                case 100:
                    return needPrefix ? "XC" : String.Concat(Enumerable.Repeat("C", digitCount));
                case 500:
                    return needPrefix ? "CD" : "D";
                case 1000:
                    return needPrefix ? "CM" : String.Concat(Enumerable.Repeat("M", digitCount));
            }
            return "";
        }
    }
}
