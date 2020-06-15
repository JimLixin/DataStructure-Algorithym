/*
200. 岛屿数量
https://leetcode-cn.com/problems/number-of-islands/
*/

/*
深度优先遍历
*/
class Solution {
public:
    int numIslands(vector<vector<char>>& grid) {
        int rows = grid.size();
        if (rows == 0) return 0;
        int cols = grid[0].size(), ans = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    ans++;
                    dfs(grid, i, j);
                }
            }
        }
        return ans;
    }

    void dfs(vector<vector<char>>& grid, int r, int c)
    {
        int rows = grid.size(), cols = grid[0].size();
        grid[r][c] = '0';
        if (r + 1 < rows && grid[r + 1][c] == '1')
            dfs(grid, r + 1, c);
        if (r - 1 >= 0 && grid[r - 1][c] == '1')
            dfs(grid, r - 1, c);
        if (c + 1 < cols && grid[r][c + 1] == '1')
            dfs(grid, r, c + 1);
        if (c - 1 >= 0 && grid[r][c - 1] == '1')
            dfs(grid, r, c - 1);
    }
};

/*
广度优先遍历
*/
class Solution2 {
public:
    int numIslands(vector<vector<char>>& grid) {
        int rows = grid.size();
        if (rows == 0) return 0;
        int cols = grid[0].size(), ans = 0;
        queue<pair<int, int>> q;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    ans++;
                    grid[i][j] = '0';
                    clear(q);
                    q.push({ i, j });
                    while (!q.empty())
                    {
                        pair<int, int> pos = q.front();
                        q.pop();
                        int r = pos.first, c = pos.second;
                        if (r + 1 < rows && grid[r + 1][c] == '1')
                        {
                            q.push({ r + 1, c });
                            grid[r + 1][c] = '0';
                        }
                        if (r - 1 >= 0 && grid[r - 1][c] == '1')
                        {
                            q.push({ r - 1, c });
                            grid[r - 1][c] = '0';
                        }
                        if (c + 1 < cols && grid[r][c + 1] == '1')
                        {
                            q.push({ r, c + 1 });
                            grid[r][c + 1] = '0';
                        }

                        if (c - 1 >= 0 && grid[r][c - 1] == '1')
                        {
                            q.push({ r, c - 1 });
                            grid[r][c - 1] = '0';
                        }

                    }
                }
            }
        }
        return ans;
    }

    void clear(queue<pair<int, int>>& q) {
        queue<pair<int, int>> empty;
        swap(empty, q);
    }
};