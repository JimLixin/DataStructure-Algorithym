using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 738. 单调递增的数字
/// https://leetcode-cn.com/problems/monotone-increasing-digits/
/// </summary>
namespace Algorithym.LeetCode.贪心算法
{
    public class _00738_单调递增的数字
    {
        public int MonotoneIncreasingDigits(int N)
        {
            if (N <= 0) return 0;
            if (N < 10) return N;

            StringBuilder num = new StringBuilder(N.ToString());
            int result = 0, pos = -1;
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] - '0' < num[i - 1] - '0')
                {
                    pos = i - 1;
                    break;
                }
            }
            if (pos == -1)
                return N;
            else
            {
                int index = 0;
                for (int i = pos; i > 0; i--)
                {
                    if ((num[i] - '0') - (num[i - 1] - '0') > 0)
                    {
                        index = i;
                        break;
                    }
                }
                if (index == 0 && num[index] == '1')
                {
                    num = num.Remove(index, 1);
                    num[index] = '9';
                }
                else
                    num[index]--;
                for (int i = index + 1; i < num.Length; i++) num[i] = '9';
                return int.Parse(num.ToString());
            }
        }
    }
}
