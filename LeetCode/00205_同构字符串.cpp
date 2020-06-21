/*
205. 同构字符串
https://leetcode-cn.com/problems/isomorphic-strings/
*/
class Solution {
public:
    //原始版本
    bool isIsomorphic(string s, string t) {
        if (s.size() != t.size()) return false;
        int n = s.size();
        unordered_map<char, char> map;
        unordered_map<char, char> map2;
        for (int i = 0; i < n; i++)
        {
            if (map.count(s[i]) > 0 && map[s[i]] != t[i] || map2.count(t[i]) > 0 && map2[t[i]] != s[i])
                return false;
            else
            {
                map[s[i]] = t[i];
                map2[t[i]] = s[i];
            }
        }
        return true;
    }

    //优化版本
    bool isIsomorphicV2(string s, string t) {
        if (s.size() != t.size()) return false;
        int map1[256] = { 0 }, map2[256] = { 0 }, n = s.size();
        for (int i = 0; i < n; ++i)
        {
            if (map1[s[i]] != map2[t[i]]) return false;
            map1[s[i]] = i + 1;
            map2[t[i]] = i + 1;
        }
        return true;
    }
};