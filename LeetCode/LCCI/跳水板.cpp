/*
面试题 16.11. 跳水板
https://leetcode-cn.com/problems/diving-board-lcci/
*/
class Solution {
public:
    vector<int> divingBoard(int shorter, int longer, int k) {
        if (k == 0)
            return vector<int>{};
        unordered_set<int> set;
        for (int i = 0; i <= k; ++i)
        {
            int j = k - i;
            set.insert(shorter * i + longer * j);
        }
        vector<int> res(set.begin(), set.end());
        sort(res.begin(), res.end());
        return res;
    }

};