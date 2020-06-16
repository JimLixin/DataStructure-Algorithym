/*
211. 添加与搜索单词 - 数据结构设计
https://leetcode-cn.com/problems/add-and-search-word-data-structure-design/
*/
class WordDictionary {
private:
    WordDictionary* next[26] = { nullptr };
    bool isEnd = false;
public:
    /** Initialize your data structure here. */
    WordDictionary() {

    }

    /** Adds a word into the data structure. */
    void addWord(string word) {
        WordDictionary* node = this;
        for (auto c : word)
        {
            if (node->next[c - 97] == nullptr)
            {
                node->next[c - 97] = new WordDictionary();
            }
            node = node->next[c - 97];
        }
        node->isEnd = true;
    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    bool search(string word) {
        WordDictionary* node = this;
        for (int i = 0; i < word.size(); i++)
        {
            char c = word[i];
            if (c == '.')
            {
                for (auto n : node->next)
                {
                    if (n && n->search(word.substr(i + 1)))
                        return true;
                }
                return false;
            }
            node = node->next[c - 97];
            if (node == nullptr)
                return false;
        }
        return node->isEnd;
    }
};

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary* obj = new WordDictionary();
 * obj->addWord(word);
 * bool param_2 = obj->search(word);
 */