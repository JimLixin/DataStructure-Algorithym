/*
1423. 可获得的最大点数
https://leetcode-cn.com/problems/maximum-points-you-can-obtain-from-cards/
*/
class Solution {
public:
    //滑动窗口思路
    int maxScore(vector<int>& cardPoints, int k) {
        int sum = accumulate(cardPoints.begin(), cardPoints.end(), 0);
        if (k == cardPoints.size()) return sum;
        int n = cardPoints.size(), left = 0, right = n - k - 1, curSum = accumulate(cardPoints.begin() + left, cardPoints.begin() + right + 1, 0), res = curSum;
        while (right < n - 1)
        {
            ++left;
            ++right;
            curSum = curSum - cardPoints[left - 1] + cardPoints[right];
            if (curSum < res) res = curSum;
        }
        return sum - res;
    }
    //贪心算法思路
    int maxScoreV2(vector<int>& cardPoints, int k) {
        if (k == cardPoints.size()) return accumulate(cardPoints.begin(), cardPoints.end(), 0);
        int sumK = accumulate(cardPoints.begin(), cardPoints.begin() + k, 0), res = sumK;
        int n = cardPoints.size();
        for (int i = n - 1; i >= n - k; i--)
        {
            sumK = sumK + cardPoints[i] - cardPoints[i - n + k];
            if (sumK > res) res = sumK;
        }
        return res;
    }
};