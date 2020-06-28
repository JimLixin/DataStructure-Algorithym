/*
657. 机器人能否返回原点
https://leetcode-cn.com/problems/robot-return-to-origin/
*/
class Solution {
public:
    bool judgeCircle(string moves) {
        int x = 0, y = 0;
        for (auto c : moves)
        {
            if (c == 'U')
                y++;
            else if (c == 'D')
                y--;
            else if (c == 'L')
                x--;
            else
                x++;
        }
        return x == 0 && y == 0;
    }
};