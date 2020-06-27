/*
1282. 用户分组
https://leetcode-cn.com/problems/group-the-people-given-the-group-size-they-belong-to/
*/
class Solution {
public:
    vector<vector<int>> groupThePeople(vector<int>& groupSizes) {
        vector<vector<int>> res;
        unordered_map<int, vector<int>> map;
        for (int i = 0; i < groupSizes.size(); i++) map[groupSizes[i]].push_back(i);
        for (auto iter = map.begin(); iter != map.end(); iter++)
        {
            int s = iter->second.size(), gSize = iter->first;
            for (auto it = iter->second.begin(); it != iter->second.end(); it = next(it, gSize))
            {
                vector<int> tmp(it, next(it, gSize));
                res.push_back(tmp);
            }
        }
        return res;
    }
};