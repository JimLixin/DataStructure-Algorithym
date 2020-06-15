/*
684. 冗余连接
https://leetcode-cn.com/problems/redundant-connection/
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

    void Union(int x, int y)
    {
        int rootX = FindRoot(x), rootY = FindRoot(y);
        if (rootX == rootY) return;
        int rankX = rank[rootX], rankY = rank[rootY];
        if (rankX > rankY)
            data[rootY] = rootX;
        else if (rankX < rankY)
            data[rootX] = rootY;
        else
        {
            data[rootX] = rootY;
            rank[rootY]++;
        }
        // cout << "data: ";
        // for(auto i : data)
        // {
        //     cout << i << ",";
        // }
        // cout << ", rank: ";
        // for(auto i : rank)
        // {
        //     cout << i << ",";
        // }
        // cout << " after union " << x << " and " << y << endl;
    }

    bool IsConnected(int x, int y)
    {
        return FindRoot(x) == FindRoot(y);
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
    vector<int> findRedundantConnection(vector<vector<int>>& edges) {
        int n = edges.size();
        vector<int> ans;
        UnionFind uf = UnionFind(n + 1);
        for (int i = 0; i < n; i++)
        {
            if (uf.IsConnected(edges[i][0], edges[i][1]))
            {
                ans = edges[i];
            }
            uf.Union(edges[i][0], edges[i][1]);
        }
        return ans;
    }
};