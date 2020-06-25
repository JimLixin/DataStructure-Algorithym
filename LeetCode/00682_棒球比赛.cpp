/*
682. 棒球比赛
https://leetcode-cn.com/problems/baseball-game/
*/
class Solution {
public:
    int calPoints(vector<string>& ops) {
        int res = 0;
        stack<int> s;
        for (auto o : ops)
        {
            if (o == "+")
            {
                int a = s.top();
                s.pop();
                int b = a + s.top();
                s.push(a);
                s.push(b);
            }
            else if (o == "D")
                s.push(s.top() * 2);
            else if (o == "C")
                s.pop();
            else
                s.push(stoi(o));
        }
        while (!s.empty())
        {
            res += s.top();
            s.pop();
        }
        return res;
    }
};