/*
1014. 最佳观光组合
https://leetcode-cn.com/problems/best-sightseeing-pair/
*/
class Solution {
public:
    int maxScoreSightseeingPair(vector<int>& A) {
        int a = A[0], b = 0;
        for (int i = 1; i < A.size(); i++)
        {
            b = max(b, a + A[i] - i);
            a = max(a, A[i] + i);
        }
        return b;
    }
};