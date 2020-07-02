/*
378. 有序矩阵中第K小的元素
https://leetcode-cn.com/problems/kth-smallest-element-in-a-sorted-matrix/
*/
class Solution {
public:
    int kthSmallest(vector<vector<int>>& matrix, int k) {
        int res = 0;
        while (k > 0)
        {
            int min = INT_MAX, index = -1;
            for (int i = 0; i < matrix.size(); i++)
            {
                if (!matrix[i].empty() && matrix[i].front() < min)
                {
                    min = matrix[i].front();
                    index = i;
                }
            }
            res = min;
            matrix[index].erase(matrix[index].begin());
            k--;
        }
        return res;
    }
};