/*
648. 单词替换
https://leetcode-cn.com/problems/replace-words/
*/
class Trie
{
private:
    Trie* next[26] = { nullptr };
    bool isEnd = false;
public:
    Trie() {}

    ~Trie()
    {
        for (auto n : next) if (n) delete n;
    }

    void Insert(string word)
    {
        Trie* node = this;
        for (auto c : word)
        {
            if (node->next[c - 97] == nullptr)
                node->next[c - 97] = new Trie();
            node = node->next[c - 97];
        }
        node->isEnd = true;
    }

    string Replace(string word)
    {
        Trie* node = this;
        for (int i = 0; i < word.size(); i++)
        {
            node = node->next[word[i] - 97];
            if (node == nullptr) break;
            if (node->isEnd) return word.substr(0, i + 1);
        }
        return word;
    }
};

class Solution {
public:
    string replaceWords(vector<string>& dict, string sentence) {
        Trie dic = Trie();
        for (auto s : dict) dic.Insert(s);
        string word, res;
        stringstream ss(sentence);
        while (getline(ss, word, ' '))
            res += dic.Replace(word) + ' ';
        return res.substr(0, res.size() - 1);
    }
};