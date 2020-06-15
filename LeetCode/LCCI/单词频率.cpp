/*
面试题 16.02. 单词频率
https://leetcode-cn.com/problems/words-frequency-lcci/
*/
class WordsFrequency {
private:
    unordered_map<string, int> dic;
public:
    WordsFrequency(vector<string>& book) {
        for (auto word : book) dic[word]++;
    }

    int get(string word) {
        return dic[word];
    }
};

/**
 * Your WordsFrequency object will be instantiated and called as such:
 * WordsFrequency* obj = new WordsFrequency(book);
 * int param_1 = obj->get(word);
 */