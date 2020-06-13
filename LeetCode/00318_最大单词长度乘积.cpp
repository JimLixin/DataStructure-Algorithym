/*
318. 最大单词长度乘积
https://leetcode-cn.com/problems/maximum-product-of-word-lengths/
*/

/*
暴力解法(超时)
*/
class Solution {
public:
    int maxProduct(vector<string>& words) {
        int n = words.size(), max = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (!hasIntersection(words[i], words[j]))
                {
                    int k = words[i].size() * words[j].size();
                    //cout << words[i] <<":" << words[i].size()<<"," << words[j] << ":"<< words[j].size()<< "," << k << endl;
                    if (k > max) max = k;
                }
            }
        }
        return max;
    }

    bool hasIntersection(string a, string b)
    {
        int n1 = a.size(), n2 = b.size();
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                if (a[i] == b[j])
                    return true;
            }
        }
        return false;
    }
};

/*
位运算+预计算，优化“查询两个字符串公共部分”的性能
Note: 26个字母在一个单词中是否出现 - 可以以0|1的形式存储在一个Int变量中
*/
class Solution2{
public:
    int maxProduct(vector<string>& words) {
        int n = words.size(), ans = 0;
        if (n == 0) return 0;
        int bitmasks[n], len[n];
        for (int i = 0; i < n; i++)
        {
            int b = 0;
            for (auto c : words[i])
            {
                b |= 1 << (c - 97);
            }
            bitmasks[i] = b;
            len[i] = words[i].size();
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((bitmasks[i] & bitmasks[j]) == 0)
                    ans = max(ans, len[i] * len[j]);
            }
        }
        return ans;
    }
};