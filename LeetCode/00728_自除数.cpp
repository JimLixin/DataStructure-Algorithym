/*
728. 自除数
https://leetcode-cn.com/problems/self-dividing-numbers/
*/
class Solution {
public:
    vector<int> selfDividingNumbers(int left, int right) {
        vector<int> res;
        for (int n = left; n <= right; n++)
        {
            int tmp = n;
            bool flag = true;
            while (tmp != 0)
            {
                if (tmp % 10 == 0 || n % (tmp % 10) != 0)
                {
                    flag = false;
                    break;
                }
                tmp /= 10;
            }
            if (flag) res.push_back(n);
        }
        return res;
    }
};