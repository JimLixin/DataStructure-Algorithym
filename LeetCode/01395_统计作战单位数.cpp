/*
1395. 统计作战单位数
https://leetcode-cn.com/problems/count-number-of-teams/
*/
class Solution {
public:
    //暴力解法: O(N^3)
    int numTeams(vector<int>& rating) {
        int n = rating.size(), res = 0;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    //if(rating[i] > rating[j] && rating[j] > rating[k] || rating[i] < rating[j] && rating[j] < rating[k])
                    if ((long long)(rating[i] - rating[j]) * (rating[j] - rating[k]) > 0)
                        res++;
                }
            }
        }
        return res;
    }

    //固定中点位置，计算左右两侧分别大于/小于中点值的数量
    //O(N^2)
    int numTeams(vector<int>& rating) {
        int n = rating.size(), res = 0;
        for (int i = 1; i < n - 1; i++)
        {
            int a = 0, b = 0, c = 0, d = 0;
            for (int j = 0; j < i; j++)
            {
                if (rating[j] < rating[i]) a++;
                else b++;
            }
            for (int j = i + 1; j < n; j++)
            {
                if (rating[j] < rating[i]) c++;
                else d++;
            }
            res += a * d + b * c;
        }
        return res;
    }
};