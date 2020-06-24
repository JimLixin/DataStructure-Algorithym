/*
1004. 最大连续1的个数 III
https://leetcode-cn.com/problems/max-consecutive-ones-iii/
*/
class Solution {
public:
    int longestOnes(vector<int>& A, int K) {
        int left = 0, right = 0, maxCnt = 0, res = 0;
        while (right < A.size())
        {
            if (A[right++] == 1) maxCnt++;
            while (maxCnt + K < right - left)
            {
                if (A[left++] == 1) maxCnt--;
            }
            if (right - left > res) res = right - left;
        }
        return res;
    }
};