/*
140. 单词拆分 II
https://leetcode-cn.com/problems/word-break-ii/
*/
class Solution {
public:
    vector<string> wordBreak(string s, vector<string>& wordDict) {
        if (s.empty()) return {};
        unordered_map<string, vector<string>> map;
        return dfs(map, wordDict, s);
    }

    vector<string> dfs(unordered_map<string, vector<string>>& map, vector<string>& wordDict, string s)
    {
        if (map.count(s)) return map[s];
        if (s.empty()) return { "" };
        vector<string> res;
        for (auto w : wordDict)
        {
            if (s.substr(0, w.size()) != w) continue;
            vector<string> rest = dfs(map, wordDict, s.substr(w.size()));
            for (auto item : rest)
            {
                res.push_back(w + (item.empty() ? "" : " " + item));
            }
        }
        map[s] = res;
        return res;
    }
};