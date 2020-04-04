using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class fibonacci_number
    {
        public static int Answer()
        {
            int tmp1 = 0, tmp2 = 1, result = 0;
            for (int i = 2; i <= N; i++)
            {
                result = tmp1 + tmp2;
                tmp1 = tmp2;
                tmp2 = result;
            }
            return result == 0 ? (N == 0 ? 0 : 1) : result;
        }
    }
}
