/*
1441. 用栈操作构建数组
https://leetcode-cn.com/problems/build-an-array-with-stack-operations/
*/
class Solution {
public:
    vector<string> buildArray(vector<int>& target, int n) {
        int m = INT_MIN;
        vector<string> res;
        vector<int> data(n + 1);
        for (int i = 0; i < target.size(); i++)
        {
            data[target[i]]++;
            m = max(m, target[i]);
        }
        for (int i = 1; i <= m; i++)
        {
            res.push_back("Push");
            if (data[i] == 0) res.push_back("Pop");
        }
        return res;
    }

    vector<string> buildArrayV2(vector<int>& target, int n) {
        int idx = 0;
        vector<string> res;
        for (int i = 1; i <= n; i++)
        {
            if (idx == target.size()) break;
            if (target[idx] == i)
            {
                res.push_back("Push");
                idx++;
            }
            else
            {
                res.push_back("Push");
                res.push_back("Pop");
            }
        }
        return res;
    }
};