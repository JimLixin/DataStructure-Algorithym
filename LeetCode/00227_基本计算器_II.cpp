/*
227. 基本计算器 II
https://leetcode-cn.com/problems/basic-calculator-ii/
*/
class Solution {
public:
    int calculate(string s) {
        long x = 0;
        stack<int> nums;
        stack<char> actions;
        for (auto c : s)
        {
            if (c == ' ') continue;
            if (isdigit(c))
            {
                x = x * 10 + c - 48;
                continue;
            }
            int tmp = 0;
            if (!actions.empty() && (actions.top() == '*' || actions.top() == '/'))
            {
                tmp = actions.top() == '*' ? nums.top() * x : nums.top() / x;
                nums.pop();
                actions.pop();
                nums.push(tmp);
            }
            else
                nums.push(x);
            actions.push(c);
            x = 0;
        }
        if (!actions.empty() && (actions.top() == '*' || actions.top() == '/'))
        {
            x = actions.top() == '*' ? nums.top() * x : nums.top() / x;
            nums.pop();
            actions.pop();
        }
        nums.push(x);
        int sum = 0;
        while (!nums.empty())
        {
            x = actions.empty() || actions.top() == '+' ? nums.top() : -nums.top();
            actions.pop();
            nums.pop();
            sum += x;
        }
        return sum;
    }
};