/*
1266. 访问所有点的最小时间
https://leetcode-cn.com/problems/minimum-time-visiting-all-points/
*/
class Solution {
public:
    int minTimeToVisitAllPoints(vector<vector<int>>& points) {
        int ans = 0;
        for (int i = 1; i < points.size(); ++i)
        {
            ans += max(abs(points[i][0] - points[i - 1][0]), abs(points[i][1] - points[i - 1][1]));
        }
        return ans;
    }
};