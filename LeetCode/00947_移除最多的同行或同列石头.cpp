/*
947. 移除最多的同行或同列石头
https://leetcode-cn.com/problems/most-stones-removed-with-same-row-or-column/
*/
class UnionFind
{
private:
    int count;
    vector<int> data;
public:
    UnionFind(int n)
    {
        data = vector<int>(n, -1);
        count = n;
    }

    int GetCount()
    {
        return count;
    }

    void Union(int x, int y)
    {
        int a = FindRoot(x), b = FindRoot(y);
        if (a != b)
        {
            data[a] = b;
            count--;
        }
    }

    int FindRoot(int x)
    {
        int root = x;
        while (data[root] != -1)
        {
            root = data[root];
        }
        return root;
    }
};

class Solution {
public:
    int removeStones(vector<vector<int>>& stones) {
        int n = stones.size();
        UnionFind uf = UnionFind(20000);
        for (int i = 0; i < n; i++)
        {
            uf.Union(stones[i][0], stones[i][1] + 10000);
        }
        unordered_set<int> roots;
        for (int i = 0; i < n; i++)
        {
            roots.insert(uf.FindRoot(stones[i][0]));
        }
        return n - roots.size();
    }
};