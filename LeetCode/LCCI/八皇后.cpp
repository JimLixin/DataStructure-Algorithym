/*
面试题 08.12. 八皇后
https://leetcode-cn.com/problems/eight-queens-lcci/
*/
class Solution {
private:
    vector<int> solution;
    vector<vector<string>> res;
public:
    vector<vector<string>> solveNQueens(int n) {
        solution = vector<int>(n, -n - 1);
        solve(n, 0);
        return res;
    }

    void solve(int n, int row)
    {
        if (row == n)
        {
            if (full())
            {
                vector<string> board(n, string(n, '.'));
                for (int i = 0; i < solution.size(); i++) board[i][solution[i]] = 'Q';
                res.push_back(board);
            }
            return;
        }
        for (int col = 0; col < n; col++)
        {
            if (valid(row, col))
            {
                solution[row] = col;
                solve(n, row + 1);
                solution[row] = -n - 1;
            }
        }
    }

    bool full()
    {
        for (int i = 0; i < solution.size(); i++)
        {
            if (solution[i] < 0) return false;
        }
        return true;
    }

    bool valid(int row, int col)
    {
        if (solution[row] >= 0) return false;
        for (int i = 0; i < solution.size(); i++)
        {
            if (solution[i] == col || abs(i - row) == abs(solution[i] - col))
                return false;
        }
        return true;
    }
};