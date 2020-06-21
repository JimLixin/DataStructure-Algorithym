/*
290. 单词规律
https://leetcode-cn.com/problems/word-pattern/
*/
class Solution {
public:
    bool wordPattern(string pattern, string str) {
        int i = 0;
        unordered_map<string, char> map;
        unordered_map<char, string> map2;
        string word;
        stringstream ss(str);
        while (getline(ss, word, ' '))
        {
            if (i == pattern.size()) return false;
            if (map.count(word) && map[word] != pattern[i] || map2.count(pattern[i]) && map2[pattern[i]] != word)
                return false;
            else
            {
                map[word] = pattern[i];
                map2[pattern[i]] = word;
                i++;
            }
        }
        return i == pattern.size();
    }
};