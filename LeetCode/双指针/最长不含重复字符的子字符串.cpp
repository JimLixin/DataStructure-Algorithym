/*
剑指 Offer 48. 最长不含重复字符的子字符串
https://leetcode-cn.com/problems/zui-chang-bu-han-zhong-fu-zi-fu-de-zi-zi-fu-chuan-lcof/
*/
class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int left = 0, right = 0, res = 0;
        unordered_map<char, int> data;

        while (right < s.size())
        {
            char c = s[right];
            right++;
            data[c]++;
            while (data[c] > 1)
            {
                char d = s[left];
                left++;
                data[d]--;
            }
            res = max(res, right - left);
        }
        return res;
    }
};