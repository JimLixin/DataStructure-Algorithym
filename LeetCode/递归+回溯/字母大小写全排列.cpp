/*
784. 字母大小写全排列
https://leetcode-cn.com/problems/letter-case-permutation/
*/
class Solution {
public:
    vector<string> letterCasePermutation(string S) {
        vector<string> res = { S };
        dfs(res, S, 0);
        return res;
    }

    void dfs(vector<string>& res, string& S, int start)
    {
        if (start == S.size()) return;
        for (int i = start; i < S.size(); i++)
        {
            if (!isalpha(S[i])) continue;
            int tmp = start;
            S[i] ^= ' ';
            res.push_back(S);
            start = i + 1;
            dfs(res, S, start);
            start = tmp;
            S[i] ^= ' ';
        }
    }
};