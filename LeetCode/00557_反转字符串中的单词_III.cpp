/*
557. 反转字符串中的单词 III
https://leetcode-cn.com/problems/reverse-words-in-a-string-iii/
*/

//原始版本(开辟额外空间追加字符串)
class Solution {
public:
    string reverseWords(string s) {
        int i = 0;
        string tmp, res;
        while (i < s.size() || tmp != "")
        {
            if (i < s.size() && s[i] != ' ')
                tmp.insert(0, 1, s[i]);
            else
            {
                res += tmp;
                tmp = "";
                if (i < s.size()) res += " ";
            }
            i++;
        }
        return res;
    }
};

//原地置换字符串
class Solution2 {
public:
    string reverseWords(string s) {
        size_t start = 0, end = 0;
        while (start < s.size())
        {
            end = s.find(' ', start);
            if (end == string::npos) break;

            reverse(s, start, end - 1);
            start = end + 1;
        }
        reverse(s, start, s.size() - 1);
        return s;
    }

    void reverse(string& s, int start, int end)
    {
        char c;
        while (start < end)
        {
            c = s[end];
            s[end] = s[start];
            s[start] = c;
            ++start;
            --end;
        }
    }
};