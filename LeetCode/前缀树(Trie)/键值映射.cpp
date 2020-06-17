/*
677. 键值映射
https://leetcode-cn.com/problems/map-sum-pairs/
*/
class MapSum {
private:
    MapSum* next[26] = { nullptr };
    int weight = 0;
    bool isEnd = false;
public:
    /** Initialize your data structure here. */
    MapSum() {

    }

    void addWeight(int w)
    {
        weight += w;
    }

    void setWeight(int w)
    {
        weight = w;
    }

    int getWeight()
    {
        return weight;
    }

    bool SearchWord(string word)
    {
        MapSum* node = this;
        for (auto c : word)
        {
            node = node->next[c - 97];
            if (node == nullptr)
                return false;
        }
        return node->isEnd;
    }

    void insert(string key, int val) {
        bool existWord = SearchWord(key);
        MapSum* node = this;
        for (auto c : key)
        {
            if (node->next[c - 97] == nullptr)
                node->next[c - 97] = new MapSum();
            if (existWord)
                node->next[c - 97]->setWeight(val);
            else
                node->next[c - 97]->addWeight(val);
            node = node->next[c - 97];
        }
        node->isEnd = true;
    }

    int sum(string prefix) {
        MapSum* node = this;
        for (auto c : prefix)
        {
            node = node->next[c - 97];
            if (node == nullptr)
                return 0;
        }
        return node->getWeight();
    }
};

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum* obj = new MapSum();
 * obj->insert(key,val);
 * int param_2 = obj->sum(prefix);
 */