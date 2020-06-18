/*
1313. 解压缩编码列表
https://leetcode-cn.com/problems/decompress-run-length-encoded-list/
*/
class Solution {
public:
    vector<int> decompressRLElist(vector<int>& nums) {
        vector<int> res;
        for (int i = 0; i < nums.size() / 2; i++)
        {
            for (int j = 0; j < nums[2 * i]; j++)
            {
                res.push_back(nums[2 * i + 1]);
            }
        }
        return res;
    }
};