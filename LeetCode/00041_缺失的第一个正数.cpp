/*
41. 缺失的第一个正数
https://leetcode-cn.com/problems/first-missing-positive/
*/
class Solution {
public:
    //排序+遍历数组
    //时间: O(N*logN)
    //空间: O(1)
    int firstMissingPositive(vector<int>& nums) {
        int n = 1;
        sort(nums.begin(), nums.end());
        for (int i = 0; i < nums.size(); i++)
        {
            if (nums[i] <= 0 || i > 0 && nums[i] == nums[i - 1]) continue;
            if (nums[i] != n)
                return n;
            else
                n++;
        }
        return n;
    }

    //哈希表 +　遍历
    //时间: O(N)
    //空间: O(N)
    int firstMissingPositiveV2(vector<int>& nums) {
        unordered_set<int> dic;
        for (auto n : nums) dic.insert(n);
        for (int i = 1; i <= nums.size() + 1; i++)
        {
            if (!dic.count(i))
                return i;
        }
        return nums.size() + 1;
    }

    //原地哈希
    //时间: O(N)
    //空间: O(1)
    int firstMissingPositiveV3(vector<int>& nums) {
        int n = nums.size();
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                int tmp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = tmp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }
        return n + 1;
    }
};