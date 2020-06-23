/*
567. 字符串的排列
https://leetcode-cn.com/problems/permutation-in-string/
*/
class Solution {
public:
    bool checkInclusion(string s1, string s2) {
        int left = 0, right = 0, valid = 0;
        unordered_map<char, int> need, window;
        for (auto c : s1) ++need[c];
        while (right < s2.size())
        {
            char c = s2[right];
            right++;
            if (need.count(c))
            {
                window[c]++;
                if (window[c] == need[c])
                    valid++;
            }

            while (right - left >= s1.size())
            {
                if (valid == need.size()) return true;
                char d = s2[left];
                left++;
                if (need.count(d))
                {
                    if (window[d] == need[d])
                        valid--;
                    window[d]--;
                }
            }
        }
        return false;
    }
};