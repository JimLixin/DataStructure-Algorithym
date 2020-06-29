/*
1409. 查询带键的排列
https://leetcode-cn.com/problems/queries-on-a-permutation-with-key/
*/
class Solution {
public:
    vector<int> processQueries(vector<int>& queries, int m) {
        vector<int> res;
        unordered_map<int, int> data;
        for (int i = 0; i < queries.size(); i++) data[queries[i]] = queries[i] - 1;
        for (int i = 0; i < queries.size(); i++)
        {
            int n = data[queries[i]];
            res.push_back(n);
            for (auto iter = data.begin(); iter != data.end(); iter++)
            {
                if (iter->second < n) iter->second++;
                else if (iter->second == n) iter->second = 0;
            }
        }
        return res;
    }
};