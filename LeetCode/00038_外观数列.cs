using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 38. 外观数列
/// https://leetcode-cn.com/problems/count-and-say/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00038_count_and_say
    {
        public string CountAndSay(int n)
        {
            string num = "1";
            for (int i = 1; i < n; i++)
            {
                int count = 1, len = num.Length;
                for (int j = 1; j < len; j++)
                {
                    if (num[j] != num[j - 1])
                    {
                        num += count.ToString() + num[j - 1];
                        count = 1;
                    }
                    else
                        count++;
                }
                num += count.ToString() + num[len - 1];
                num = num.Substring(len);

            }
            return num;
        }
    }
}
