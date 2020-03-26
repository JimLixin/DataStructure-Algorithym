using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public static class ThreeSum
    {
        private static Dictionary<string, IList<int>> result = new Dictionary<string, IList<int>>();
        //private static IList<IList<int>> result = new List<IList<int>>();
        private static bool[] vis;
        private static int[] data;
        private static int[] tmp;

        private static readonly int NSUM = 3;
        private static readonly int SUM = 0;

        public static IList<IList<int>> Answer(int[] nums)
        {
            if (nums == null || nums.Length < NSUM)
                return null;

            int n = nums.Length;
            vis = new bool[NSUM + 1];
            data = new int[NSUM];
            for (int i = 0; i < NSUM; i++)
            {
                data[i] = -1;
            }
            tmp = new int[NSUM];

            _answer(0,0, nums);
            return result.Values.ToList();
        }

        private static void _answer(int step, int index, int[] nums)
        {
            if (step >= NSUM)
            {
                tmp = data.Select(i => nums[i]).ToArray();
                if (vis[step - 1] && tmp.Sum() == SUM)
                {   
                    Array.Sort(tmp);
                    string key = string.Join("", tmp);
                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, new List<int>(tmp));
                    }
                }
                return;
            }
            for (int i = ((index >= 2 && index < nums.Length - 2) ? index + 1 : 0); i < nums.Length; i++)
            {
                if (!vis[step] && !data.Contains(i))
                {
                    vis[step] = true;
                    data[step] = i;
                    _answer(step + 1, i, nums);
                    vis[step] = false;
                }
            }

            //if (step >= NSUM)
            //{
            //    if (vis[step - 1] && data.Sum() == SUM)
            //    {
            //        Array.Copy(data, tmp, data.Length);
            //        Array.Sort(tmp);
            //        string key = string.Join("", tmp);
            //        if (!result.ContainsKey(key))
            //        {
            //            result.Add(key, new List<int>(data));
            //        }
            //    }
            //    return;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //if (step > 0 && nums[i] == data[step - 1])
            //    //    continue;
            //    if (!vis[step] && !data.Contains(nums[i]))
            //    {
            //        vis[step] = true;
            //        data[step] = nums[i];
            //        _answer(step + 1, nums);
            //        vis[step] = false;
            //    }
            //}

        }
    }
}

