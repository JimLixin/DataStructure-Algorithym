/*
832. 翻转图像
https://leetcode-cn.com/problems/flipping-an-image/
*/
class Solution {
public:
    vector<vector<int>> flipAndInvertImage(vector<vector<int>>& A) {
        int rows = A.size(), cols = A[0].size();
        for (int i = 0; i < rows; ++i)
        {
            int l = 0, r = cols - 1;
            while (l < r)
            {
                if (A[i][l] == A[i][r])
                {
                    A[i][l] = 1 - A[i][l];
                    A[i][r] = 1 - A[i][r];
                }
                ++l;
                --r;
            }
            if (l == r) A[i][l] = 1 - A[i][l];
        }
        return A;
    }
};