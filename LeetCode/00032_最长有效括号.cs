using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 32. 最长有效括号
/// https://leetcode-cn.com/problems/longest-valid-parentheses/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00032_最长有效括号
    {
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int[] dp = new int[s.Length];
            int max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (s[i - 1] == '(')
                        dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                    else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1] == '(')
                        dp[i] = dp[i - 1] + ((i - dp[i - 1]) >= 2 ? dp[i - dp[i - 1] - 2] : 0) + 2;
                    if (dp[i] > max) max = dp[i];
                }
            }
            return max;
        }
    }
}

/* C++版本
class Solution {
public:
    int longestValidParentheses(string s) {
        //dp[i] - s中以位置i-1结尾的字符串的有效括号长度
        //如果 i-1位置为'(', 则当前没有可以匹配的括号对, dp[i] = 0
        //如果 i-1位置为')', 则要看i-2位置处的情况：
        //如果 i-2位置为'(', 说明i-1,i-2是一对匹配的括号, dp[i] = dp[i-2] + 2
        //如果 i-2位置为')', 有可能是多对括号嵌套，需要去找前一个能跟i-1匹配上的'('的位置k, 
        //而这个'('跟i-1中间可能存在着另一个有效的括号串，即为子问题dp[i-1], 
        //k = i - dp[i-1] - 2就是我们需要检查是否能跟i-1匹配的那个位置 ,看k位置处是否为'('， 
        //是则dp[i] = dp[i-1] + 2 + dp[k], dp[k]也有可能不存在，比如s是以嵌套括号对开始的。
        int n = s.size(), ans = 0;
        vector<int> dp(n + 1);
        for(int i = 2; i <= n; i++)
        {
            if(s[i-1] == '(') continue;
            if(s[i-2] == '(')
                dp[i] = dp[i-2] + 2;
            else
            {
                int k = i - dp[i-1] - 2;
                if(k >= 0 && s[k] == '(') 
                    dp[i] = dp[i-1] + 2 + (k > 0 ? dp[k] : 0);
            }
            ans = max(ans, dp[i]);
        }
        return ans;
    }
}; 
*/
