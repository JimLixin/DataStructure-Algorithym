/*
547. 朋友圈
https://leetcode-cn.com/problems/friend-circles/
*/
class UnionFind
{
private:
    vector<int> data;
    vector<int> rank;
public:
    UnionFind(int n)
    {
        data = vector<int>(n, -1);
        rank = vector<int>(n, 0);
    }

    int GetCount()
    {
        int res = 0;
        for (auto i : data)
        {
            if (i == -1) res++;
        }
        return res;
    }

    void Union(int x, int y)
    {
        int rootX = FindRoot(x), rootY = FindRoot(y);
        if (rootX == rootY) return;
        int rankX = rank[x], rankY = rank[y];
        if (rankX > rankY)
            data[rootY] = rootX;
        else if (rankX < rankY)
            data[rootX] = rootY;
        else
        {
            data[rootX] = rootY;
            rank[rootY]++;
        }
    }

    int FindRoot(int x)
    {
        int root = x;
        while (data[root] != -1) root = data[root];
        return root;
    }
};

class Solution {
public:
    int findCircleNum(vector<vector<int>>& M) {
        int n = M.size();
        UnionFind uf = UnionFind(n);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (i != j && M[i][j] == 1)
                    uf.Union(i, j);
            }
        }
        return uf.GetCount();
    }
};