/*
面试题 05.07. 配对交换
https://leetcode-cn.com/problems/exchange-lcci/
*/
class Solution {
public:
    int exchangeBits(int num) {
        return (num & 0xaaaaaaaa >> 1) | (num & 0x55555555 << 1);
    }
};