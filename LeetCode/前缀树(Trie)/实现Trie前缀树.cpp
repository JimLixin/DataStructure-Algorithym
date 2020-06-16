/*
208. 实现 Trie (前缀树)
https://leetcode-cn.com/problems/implement-trie-prefix-tree/
*/
class Trie {
private:
    bool isEnd = false;
    Trie* next[26] = { nullptr };
public:
    /** Initialize your data structure here. */
    Trie() {

    }

    /** Inserts a word into the trie. */
    void insert(string word) {
        Trie* node = this;
        for (auto c : word)
        {
            if (node->next[c - 97] == nullptr)
            {
                node->next[c - 97] = new Trie();
            }
            node = node->next[c - 97];
        }
        node->isEnd = true;
    }

    /** Returns if the word is in the trie. */
    bool search(string word) {
        Trie* node = this;
        for (auto c : word)
        {
            node = node->next[c - 97];
            if (node == nullptr)
            {
                return false;
            }
        }
        return node->isEnd;
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    bool startsWith(string prefix) {
        Trie* node = this;
        for (auto c : prefix)
        {
            node = node->next[c - 97];
            if (node == nullptr)
            {
                return false;
            }
        }
        return true;
    }
};

/**
 * Your Trie object will be instantiated and called as such:
 * Trie* obj = new Trie();
 * obj->insert(word);
 * bool param_2 = obj->search(word);
 * bool param_3 = obj->startsWith(prefix);
 */