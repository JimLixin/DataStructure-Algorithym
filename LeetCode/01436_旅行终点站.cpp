/*
1436. 旅行终点站
https://leetcode-cn.com/problems/destination-city/
*/
class Solution {
public:
    string destCity(vector<vector<string>>& paths) {
        unordered_map<string, string> map;
        for (auto p : paths) map[p[0]] = p[1];
        for (auto iter = map.begin(); iter != map.end(); ++iter)
        {
            if (map.count(iter->second) == 0)
                return iter->second;
        }
        return nullptr;
    }
};