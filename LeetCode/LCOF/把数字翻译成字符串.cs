﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 回溯
    /// 面试题46. 把数字翻译成字符串
    /// https://leetcode-cn.com/problems/ba-shu-zi-fan-yi-cheng-zi-fu-chuan-lcof/
    /// </summary>
    public class 把数字翻译成字符串
    {
        Dictionary<string, string> dic;
        StringBuilder sb;
        int result;
        public int TranslateNum(int num)
        {
            dic = new Dictionary<string, string>(){
            {"0", "a"},
            {"1", "b"},
            {"2", "c"},
            {"3", "d"},
            {"4", "e"},
            {"5", "f"},
            {"6", "g"},
            {"7", "h"},
            {"8", "i"},
            {"9", "j"},
            {"10", "k"},
            {"11", "l"},
            {"12", "m"},
            {"13", "n"},
            {"14", "o"},
            {"15", "p"},
            {"16", "q"},
            {"17", "r"},
            {"18", "s"},
            {"19", "t"},
            {"20", "u"},
            {"21", "v"},
            {"22", "w"},
            {"23", "x"},
            {"24", "y"},
            {"25", "z"}
        };
            sb = new StringBuilder();
            dfs(num.ToString());
            return result;
        }

        public void dfs(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                result++;
                return;
            }

            for (int i = 1; i <= input.Length; i++)
            {
                string key = input.Substring(0, i);
                if (dic.ContainsKey(key))
                {
                    sb.Append(dic[key]);
                    dfs(input.Substring(i));
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
    }

    public class SolutionV2
    {
        int result;
        public int TranslateNum(int num)
        {
            dfs(num.ToString());
            return result;
        }

        public void dfs(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                result++;
                return;
            }
            for (int i = 1; i <= Math.Min(input.Length, 3); i++)
            {
                string cur = input.Substring(0, i);
                if (i == 1 || !cur.StartsWith("0") && int.Parse(cur) < 26)
                    dfs(input.Substring(i));
            }
        }
    }

    /// <summary>
    /// 动态规划
    /// </summary>
    public class SolutionV3
    {
        public int TranslateNum(int num)
        {
            if (num < 10) return 1;
            string numStr = num.ToString();
            int len = numStr.Length;
            int[] dp = new int[len + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 1; i < len; i++)
            {
                int pre = Convert.ToInt16(numStr[i - 1].ToString()) * 10 + Convert.ToInt16(numStr[i].ToString());
                if (pre <= 9 || pre >= 26)
                {
                    dp[i + 1] = dp[i];
                }
                else
                {
                    dp[i + 1] = dp[i - 1] + dp[i];
                }
            }
            Console.WriteLine(string.Join("", dp));
            return dp[len];
        }
    }
}
