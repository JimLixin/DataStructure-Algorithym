/*
1456. 定长子串中元音的最大数目
https://leetcode-cn.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
*/
class Solution {
public:
    int maxVowels(string s, int k) {
        int left = 0, right = 0, cnt = 0, res = 0;
        unordered_set<char> vowels = { 'a','e','i','o','u' };
        while (right < s.size())
        {
            if (vowels.count(s[right++]) > 0)
                cnt++;
            while (right - left > k)
            {
                if (vowels.count(s[left++]) > 0)
                    cnt--;
            }
            if (cnt > res) res = cnt;
        }
        return res;
    }
};