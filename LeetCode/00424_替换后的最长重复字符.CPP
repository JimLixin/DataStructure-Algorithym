/*
424. 替换后的最长重复字符
https://leetcode-cn.com/problems/longest-repeating-character-replacement/
*/
class Solution {
public:
    int characterReplacement(string s, int k) {
        int res = 0, left = 0, right = 0, maxCnt = 0;
        char maxChar;
        vector<int> data(26);
        while (right < s.size())
        {
            char c = s[right];
            right++;
            data[c - 65]++;
            if (data[c - 65] > maxCnt)
            {
                maxCnt = data[c - 65];
                maxChar = c;
            }

            while (left < right && maxCnt + k < right - left)
            {
                char d = s[left];
                left++;
                data[d - 65]--;
                maxCnt--;
                for (int i = 0; i < 26; i++)
                {
                    if (data.at(i) > maxCnt)
                    {
                        maxCnt = data[i];
                        maxChar = i + 65;
                        break;
                    }
                }
            }
            if (right - left > res) res = right - left;
        }
        return res;
    }
};