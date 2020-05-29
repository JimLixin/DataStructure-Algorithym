using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 860. 柠檬水找零
/// https://leetcode-cn.com/problems/lemonade-change/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _00860_柠檬水找零
    {
        public bool LemonadeChange(int[] bills)
        {
            if (bills == null || bills.Length == 0)
                return true;
            int[] changes = new int[11];
            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                    changes[5]++;
                else if (bills[i] == 10)
                {
                    if (changes[5]-- < 1) return false;
                    changes[10]++;
                }
                else
                {
                    int cnt = changes[10] < 1 ? 3 : 1;
                    if (changes[5] < cnt) return false;
                    changes[5] -= cnt;
                    if (changes[10] > 0) changes[10]--;
                }
            }
            return true;
        }
    }
}
