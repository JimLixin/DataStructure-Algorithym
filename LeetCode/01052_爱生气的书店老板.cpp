/*
1052. 爱生气的书店老板
https://leetcode-cn.com/problems/grumpy-bookstore-owner/
*/
class Solution {
public:
    int maxSatisfied(vector<int>& customers, vector<int>& grumpy, int X) {
        int maxAngry = 0, satisfy = 0, angry = 0, left = 0, right = 0;
        while (right < customers.size())
        {
            if (grumpy[right] == 0)
                satisfy += customers[right];
            else
                angry += customers[right];
            right++;

            while (right - left > X)
            {
                if (grumpy[left] == 1)
                    angry -= customers[left];
                left++;
            }
            if (maxAngry < angry) maxAngry = angry;
        }
        return satisfy + maxAngry;
    }
};