/*
面试题 17.18. 最短超串
https://leetcode-cn.com/problems/shortest-supersequence-lcci/
*/
class Solution {
public:
    vector<int> shortestSeq(vector<int>& big, vector<int>& small) {
        if (big.empty() || big.size() < small.size()) return {};
        vector<int> res;
        unordered_map<int, int> required, current;
        int left = 0, right = 0, matched = 0, k = small.size(), min = INT_MAX, l = 0, r = 0;
        for (auto i : small) required[i]++;
        while (right < big.size())
        {
            int n = big[right];
            right++;
            if (required.count(n) > 0)
            {
                current[n]++;
                if (current[n] == required[n])
                    matched++;
            }
            while (matched == k)
            {
                if (right - left < min)
                {
                    min = right - left;
                    res = { left, right - 1 };
                }
                int m = big[left];
                left++;
                if (required.count(m) > 0)
                {
                    if (current[m] == required[m])
                        matched--;
                    current[m]--;
                }
            }
        }
        return res;
    }
};