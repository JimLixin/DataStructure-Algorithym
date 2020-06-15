/*
1319. 连通网络的操作次数
https://leetcode-cn.com/problems/number-of-operations-to-make-network-connected/
*/
class UnionFind
{
private:
    vector<int> connection;
    vector<int> rank;
    int count;

public:
    UnionFind(int n)
    {
        connection = vector<int>(n, -1);
        rank = vector<int>(n, 0);
        count = n;
    }

    int GetCount()
    {
        return count;
    }

    bool IsConnected(int x, int y)
    {
        return FindRoot(x) == FindRoot(y);
    }

    void Union(int x, int y)
    {
        int rtx = FindRoot(x), rty = FindRoot(y);
        if (rtx == rty) return;
        int rkx = rank[rtx], rky = rank[rty];
        if (rkx > rky)
            connection[rty] = rtx;
        else if (rkx < rky)
            connection[rtx] = rty;
        else
        {
            connection[rtx] = rty;
            rank[rty]++;
        }
        count--;
    }

    int FindRoot(int x)
    {
        int root = x;
        while (connection[root] != -1)
        {
            root = connection[root];
        }
        return root;
    }
};

class Solution {
public:
    int makeConnected(int n, vector<vector<int>>& connections) {
        int addition = 0;
        UnionFind uf = UnionFind(n);
        for (auto conn : connections)
        {
            if (uf.IsConnected(conn[0], conn[1]))
                addition++;
            else
                uf.Union(conn[0], conn[1]);
        }
        return addition >= uf.GetCount() - 1 ? uf.GetCount() - 1 : -1;
    }
};
