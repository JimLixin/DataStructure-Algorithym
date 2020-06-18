/*
1108. IP 地址无效化
https://leetcode-cn.com/problems/defanging-an-ip-address/
*/
class Solution {
public:
    string defangIPaddr(string address) {
        string res;
        for (auto c : address)
        {
            res += isdigit(c) ? to_string(c - 48) : "[.]";
        }
        return res;
    }
};