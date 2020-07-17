/*
1475. 商品折扣后的最终价格
https://leetcode-cn.com/problems/final-prices-with-a-special-discount-in-a-shop/
*/
class Solution {
public:
    //单调栈
    vector<int> finalPrices(vector<int>& prices) {
        stack<int> s;
        vector<int> ans(prices.size());
        prices.push_back(0);
        for (int i = 0; i < prices.size(); ++i)
        {
            while (!s.empty() && prices[s.top()] >= prices[i])
            {
                ans[s.top()] = prices[s.top()] - prices[i];
                s.pop();
            }
            s.push(i);
        }
        return ans;
    }

    //暴力解法
    vector<int> finalPricesV2(vector<int>& prices) {
        for (int i = 0; i < prices.size(); ++i)
        {
            for (int j = i + 1; j < prices.size(); ++j)
            {
                if (prices[j] <= prices[i])
                {
                    prices[i] -= prices[j];
                    break;
                }
            }
        }
        return prices;
    }
};