/*
1309. 解码字母到整数映射
https://leetcode-cn.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
*/
class Solution {
public:
    string freqAlphabets(string s) {
        string res;
        unordered_map<char, char> map1 = { {'1','a'},{'2','b'},{'3','c'},{'4','d'},{'5','e'},{'6','f'},{'7','g'},{'8','h'},{'9','i'} };
        unordered_map<string, char> map2 = { {"10#",'j'},{"11#",'k'},{"12#",'l'},{"13#",'m'},{"14#",'n'},{"15#",'o'},{"16#",'p'},{"17#",'q'},{"18#",'r'},{"19#",'s'},{"20#",'t'},{"21#",'u'},{"22#",'v'},{"23#",'w'},{"24#",'x'},{"25#",'y'},{"26#",'z'} };
        int i = s.size() - 1;
        while (i >= 0)
        {
            if (s[i] == '#')
            {
                res += map2[s.substr(i - 2, 3)];
                i -= 3;
            }
            else
            {
                res += map1[s[i]];
                i--;
            }
        }
        reverse(res.begin(), res.end());
        return res;
    }
};