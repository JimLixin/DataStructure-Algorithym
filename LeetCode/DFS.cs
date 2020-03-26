using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class DfsSolution
    {

        public static List<List<int>> ans = new List<List<int>>();

        //public static int[] path = new int[100];

        public static bool[] v = new bool[100];

        public static void robot(int idx, int[] nums)
        {
            if (idx >= nums.Length)
            {
                List<int> tmp = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (v[i])
                    {
                        tmp.Add(nums[i]);
                    }
                }
                ans.Add(tmp);
                return;
            }
            //不选
            v[idx] = false;
            robot(idx + 1, nums);
            //选
            v[idx] = true;
            robot(idx + 1, nums);
        }

        public static List<List<int>> subsets(int[] nums)
        {
            ans.Clear();
            //先排序，然后dfs每个元素选或者不选，最后叶子节点就是所有解
            //Arrays.sort(nums);
            int n = nums.Length;
            //选择排序 冒泡是交换相邻的2个元素
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int t = nums[i];
                        nums[i] = nums[j];
                        nums[j] = t;
                    }
                }
            }

            robot(0, nums);
            return ans;
        }
    }

    /// <summary>
    /// https://zhuanlan.zhihu.com/p/27112937
    /// Reference this article and you will truely understand DFS
    /// </summary>
    public class DfsPermutationGenerator
    {
        private int[] result;
        private bool[] vis;
        private int _n;

        public DfsPermutationGenerator(int n)
        {
            _n = n;
            result = new int[n];
            vis = new bool[n+1];
        }

        public void Make()
        {
            _make(0);
        }

        private void _make(int level)
        {
            if (level == _n)
            {
                for (int i = 0; i < _n; i++)
                {
                    Console.Write($"{result[i]} ");
                }
                Console.WriteLine("\r\n");
                return;
            }
            for (int i = 1; i <= _n; i++)
            {
                if (!vis[i])
                {
                    vis[i] = true;
                    result[level] = i;
                    _make(level + 1);
                    vis[i] = false;
                }
            }
        }
    }

    public static class DfsPermutation
    {
        private static int n;
        private static int[] data;
        private static bool[] vis;
        private static IList<IList<int>> result = new List<IList<int>>();

        public static IList<IList<int>> Make(int[] nums)
        {
            n = nums.Length;
            data = new int[n];
            vis = new bool[n+1];
            _make(0, nums);

            return result;
        }

        private static void _make(int step, int[] nums)
        {
            if (step == n)
            {
                IList<int> item = new List<int>(data);
                result.Add(item);
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (!vis[i])
                {
                    vis[i] = true;
                    data[step] = nums[i];
                    _make(step + 1, nums);
                    vis[i] = false;
                }
            }
        }
    }
}
