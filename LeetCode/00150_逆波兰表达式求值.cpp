/*
150. 逆波兰表达式求值
https://leetcode-cn.com/problems/evaluate-reverse-polish-notation/
*/
class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        int result = 0;
        stack<int> s;
        for (auto c : tokens)
        {
            if (c == "+")
            {
                int a = s.top();
                s.pop();
                int b = s.top();
                s.pop();
                s.push(a + b);
                //cout << a << "+" << b << " is:" << a+b << endl;
            }
            else if (c == "-")
            {
                int a = s.top();
                s.pop();
                int b = s.top();
                s.pop();
                //cout << a << "-"  << b << " is:" << a-b << endl;
                s.push(b - a);
            }
            else if (c == "*")
            {
                int a = s.top();
                s.pop();
                int b = s.top();
                s.pop();
                //cout << a << "*"  << b << " is:" << a*b << endl;
                s.push(a * b);
            }
            else if (c == "/")
            {
                int a = s.top();
                s.pop();
                int b = s.top();
                s.pop();
                //cout << b << "/" << a << " is:" << b/a << endl;
                s.push(b / a);
            }
            else
                s.push(atoi(c.c_str()));
        }
        return s.top();
    }
};