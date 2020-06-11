/*
面试题 17.09. 第 k 个数
https://leetcode-cn.com/problems/get-kth-magic-number-lcci/
*/
class Solution {
public:
    int getKthMagicNumber(int k) {
        if (k <= 0) return 0;
        vector<int> ans(k, 1);
        int p3 = 0, p5 = 0, p7 = 0;
        for (int i = 1; i < k; i++)
        {
            int v3 = ans[p3] * 3;
            int v5 = ans[p5] * 5;
            int v7 = ans[p7] * 7;
            ans[i] = min(min(v3, v5), v7);
            if (ans[i] == v3) p3++;
            if (ans[i] == v5) p5++;
            if (ans[i] == v7) p7++;
        }
        return ans[k - 1];
    }
};