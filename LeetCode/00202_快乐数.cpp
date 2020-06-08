/*
202. 快乐数
https://leetcode-cn.com/problems/happy-number/
*/
class Solution {
public:
    bool isHappy(int n) {
        unordered_set<int> map;
        while (n != 1)
        {
            int result = 0;
            while (n != 0)
            {
                result += pow(n % 10, 2);
                n /= 10;
            }
            n = result;
            if (map.find(n) != map.end()) return false;
            map.insert(n);
        }
        return true;
    }
};