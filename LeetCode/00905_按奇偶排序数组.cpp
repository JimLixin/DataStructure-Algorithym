/*
905. 按奇偶排序数组
https://leetcode-cn.com/problems/sort-array-by-parity/
*/
class Solution {
public:
    vector<int> sortArrayByParity(vector<int>& A) {
        int left = 0, right = A.size() - 1;
        while (left < right)
        {
            while (left < right && (A[left] & 1) == 0) left++;
            while (left < right && (A[right] & 1) > 0) right--;
            if (left >= right) break;
            A[left] = A[left] ^ A[right];
            A[right] = A[left] ^ A[right];
            A[left] = A[left] ^ A[right];
        }
        return A;
    }
};