using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 406. 根据身高重建队列
/// https://leetcode-cn.com/problems/queue-reconstruction-by-height/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00406_根据身高重建队列
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            if (people == null || people.Length == 0 || people[0].Length == 0)
                return people;
            List<int[]> result = new List<int[]>();
            people = people.OrderByDescending(i => i[0]).ThenBy(i => i[1]).ToArray();
            for (int i = 0; i < people.Length; i++)
            {
                result.Insert(people[i][1], people[i]);
            }
            return result.ToArray();
        }
    }
}
