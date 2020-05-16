//LCP 01. 猜数字
//https://leetcode-cn.com/problems/guess-numbers/
class Solution {
public:
    int game(vector<int>& guess, vector<int>& answer) {
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            count += (guess[i] == answer[i] ? 1 : 0);
        }
        //std::cout << "hello world!" << guess.size() << std::endl;
        return count;
    }
};