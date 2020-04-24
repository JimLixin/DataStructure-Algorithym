using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCOF
{
    /// <summary>
    /// 面试题13. 机器人的运动范围
    /// https://leetcode-cn.com/problems/ji-qi-ren-de-yun-dong-fan-wei-lcof/
    /// </summary>
    public class ji_qi_ren_de_yun_dong_fan_wei_lcof
    {
        int count, M, N;
        bool[,] matrix;
        public int MovingCount(int m, int n, int k)
        {
            matrix = new bool[m, n];
            M = m;
            N = n;
            dfs(0, 0, k);
            return count;
        }

        public void dfs(int x, int y, int k)
        {
            if (x < 0 || y < 0 || x >= M || y >= N || matrix[x, y] || addNumbers(x, y) > k)
                return;
            matrix[x, y] = true;
            count++;
            dfs(x + 1, y, k);
            dfs(x - 1, y, k);
            dfs(x, y + 1, k);
            dfs(x, y - 1, k);
        }

        public int addNumbers(int a, int b)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a = a / 10;
            }
            while (b > 0)
            {
                sum += b % 10;
                b = b / 10;
            }
            return sum;
        }
    }
}
