/*
面试题 08.09. 括号
https://leetcode-cn.com/problems/bracket-lcci/
*/
class Solution {
private:
    string data;
    vector<string> res;
public:
    vector<string> generateParenthesis(int n) {
        dfs(0, 0, 0, n, (n << 1));
        return res;
    }

    void dfs(int step, int lcount, int rcount, int countLmt, int stepLmt)
    {
        if (step == stepLmt)
        {
            res.push_back(data);
            return;
        }
        if (lcount < countLmt)
        {
            data.push_back('(');
            dfs(step + 1, lcount + 1, rcount, countLmt, stepLmt);
            data.pop_back();
        }
        if (lcount > rcount)
        {
            data.push_back(')');
            dfs(step + 1, lcount, rcount + 1, countLmt, stepLmt);
            data.pop_back();
        }
    }
};