using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 990. 等式方程的可满足性
/// https://leetcode-cn.com/problems/satisfiability-of-equality-equations/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00990_等式方程的可满足性
    {
        public bool EquationsPossible(string[] equations)
        {
            UnionFind uf = new UnionFind(26);
            foreach (string e in equations)
            {
                if (e[1] == '=')
                    uf.Union(e[0] - 97, e[3] - 97);
            }
            foreach (string e in equations)
            {
                if (e[1] == '!' && uf.FindRoot(e[0] - 97) == uf.FindRoot(e[3] - 97))
                    return false;
            }
            return true;
        }
    }

    public class UnionFind
    {
        private int[] data;
        private int[] rank;
        public UnionFind(int nums)
        {
            data = new int[nums];
            rank = new int[nums];
            for (int i = 0; i < nums; i++)
            {
                data[i] = -1;
                rank[i] = 0;
            }
        }

        public void Union(int x, int y)
        {
            int rootX = FindRoot(x), rootY = FindRoot(y);
            if (rootX == rootY) return;
            int xRank = rank[rootX], yRank = rank[rootY];
            if (xRank > yRank)
                data[rootY] = rootX;
            else if (xRank < yRank)
                data[rootX] = rootY;
            else
            {
                data[rootY] = rootX;
                rank[rootX]++;
            }
        }

        public int FindRoot(int x)
        {
            int root = x;
            while (data[root] != -1) root = data[root];
            return root;
        }
    }
}
