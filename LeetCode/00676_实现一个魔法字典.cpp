/*
676. 实现一个魔法字典
https://leetcode-cn.com/problems/implement-magic-dictionary/
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
        for (auto n : next)
        {
            if (n) delete n;
        }
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

    bool SearchWord(string word)
    {
        Trie* node = this;
        for (auto c : word)
        {
            node = node->next[c - 97];
            if (!node) return false;
        }
        return node->isEnd;
    }

};

class MagicDictionary {
private:
    Trie dic;
public:
    /** Initialize your data structure here. */
    MagicDictionary() {
        dic = Trie();
    }

    /** Build a dictionary through a list of words */
    void buildDict(vector<string> dict) {
        for (auto s : dict)
        {
            dic.Insert(s);
        }
    }

    /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
    bool search(string word) {
        string origin = word;
        for (auto& c : word)
        {
            char tmp = c;
            for (char r = 'a'; r <= 'z'; r++)
            {
                if (r == c) continue;
                c = r;
                if (word != origin && dic.SearchWord(word))
                    return true;

            }
            c = tmp;
        }
        return false;
    }
};

/**
 * Your MagicDictionary object will be instantiated and called as such:
 * MagicDictionary* obj = new MagicDictionary();
 * obj->buildDict(dict);
 * bool param_2 = obj->search(word);
 */