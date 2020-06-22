/*
933. 最近的请求次数
https://leetcode-cn.com/problems/number-of-recent-calls/
*/
class RecentCounter {
private:
    queue<int> q;
public:
    RecentCounter() {

    }

    int ping(int t) {
        while (!q.empty() && q.front() < t - 3000) q.pop();
        q.push(t);
        return q.size();
    }
};

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter* obj = new RecentCounter();
 * int param_1 = obj->ping(t);
 */