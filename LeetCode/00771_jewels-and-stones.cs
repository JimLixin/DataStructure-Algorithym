using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 771. 宝石与石头
/// https://leetcode-cn.com/problems/jewels-and-stones/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00771_jewels_and_stones
    {
        public int NumJewelsInStones(string J, string S)
        {
            if (string.IsNullOrEmpty(J) || string.IsNullOrEmpty(S))
                return 0;
            int count = 0;
            HashSet<char> map = new HashSet<char>(J.ToCharArray());
            foreach (char c in S)
            {
                if (map.Contains(c))
                    count++;
            }
            return count;
        }
    }
}
