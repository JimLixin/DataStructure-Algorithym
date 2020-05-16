using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1431. 拥有最多糖果的孩子
/// https://leetcode-cn.com/problems/kids-with-the-greatest-number-of-candies/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01431_kids_with_the_greatest_number_of_candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>();
            if (candies == null || candies.Length == 0)
                return result;
            int max = candies.Max(), least = max - extraCandies;
            for (int i = 0; i < candies.Length; i++)
            {
                result.Add(candies[i] >= least);
            }
            return result;
        }
    }
}
