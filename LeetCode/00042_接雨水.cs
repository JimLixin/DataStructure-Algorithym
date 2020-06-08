using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 42. 接雨水
/// https://leetcode-cn.com/problems/trapping-rain-water/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00042_接雨水
    {
        /// <summary>
        /// 方法一
        /// 接完雨水，很容易看出这个数组有什么特点，就像一个山峰一样。
        /// 在最大值左边不严格递增，右边不严格递减。
        /// 因此只需要把原数组变成符合这样要求的数组就行了，改变的量就是接的雨水。
        /// 具体实现只需要先找到最大值索引，左右各自遍历一遍
        /// 两边都维护一个值来表示之前的最大值以保证单调性，
        /// 如果比最大值小，雨水量就加上这个差值，
        /// 如果大于等于，就更新最大值。
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;
            int max = height[0], maxIndex = -1, cur = 0, result = 0;
            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                    maxIndex = i;
                }
            }
            cur = height[0];
            for (int i = 1; i < maxIndex; i++)
            {
                if (height[i] >= cur)
                    cur = height[i];
                else
                    result += cur - height[i];
            }
            cur = height[height.Length - 1];
            for (int i = height.Length - 2; i > maxIndex; i--)
            {
                if (height[i] >= cur)
                    cur = height[i];
                else
                    result += cur - height[i];
            }
            return result;
        }

        /// <summary>
        /// 方法二
        /// 大家应该都知道韦恩图是什么，由此启发可以得到本题思路。
        /// 如下图，从左往右遍历，不管是雨水还是柱子，都计算在有效面积内，并且每次累加的值根据遇到的最高的柱子逐步上升。面积记为S1。
        /// 从左往右遍历得S1，每步S1+=max1且max1逐步增大
        /// 同样地，从右往左遍历可得S2。
        /// 从右往左遍历得S2，每步S2+=max2且max2逐步增大
        /// 于是我们有如下发现，S1 + S2会覆盖整个矩形，并且：重复面积 = 柱子面积 + 积水面积
        /// 最终， 积水面积 = S1 + S2 - 矩形面积 - 柱子面积
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapV2(int[] height)
        {
            return 0;
        }

        /// <summary>
        /// 方法三
        /// 利用左右指针的下标差值计算出每一行雨水+柱子的体积，如图第一行体积为11，第二行为8，第三行为1。
        /// 累加得到整体体积tmp=20tmp=20（每一层从左边第一个方格到右边最后一个方格之间一定是被蓝黑两种颜色的方格填满的，
        /// 不会存在空白，这也是为什么能按层求的关键）
        /// 计算柱子体积，为height：[0,1,0,2,1,0,1,3,2,1,2,1] height：[0,1,0,2,1,0,1,3,2,1,2,1] 
        /// 数组之和SUM=14SUM=14（也可以直接用sum()函数，不过时间复杂度就是O(2n)了）
        /// 返回结果 tmp-SUMtmp−SUM就是雨水的体积
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapV3(int[] height)
        {
            return 0;
        }

        /// <summary>
        /// 方法四
        /// 单调栈
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapV4(int[] height)
        {
            return 0;
        }

        /// <summary>
        /// 方法五
        /// 双指针
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapV5(int[] height)
        {
            return 0;
        }

        /// <summary>
        /// 方法六
        /// 动态规划
        /// 此种方法的巧妙之处在于不需要完整地求出左侧的最大值和右侧的最大值，
        /// 即可求出左侧最大值和右侧最大值中的较小值
        /// 这里引用大佬的解析大佬的解析
        /// 双指针法真的妙，那么如何理解双指针法呢？听我来给你捋一捋。（捋的过程和原解中的C++在细节方面的处理是有出入的）
        /// 我们先明确几个变量的意思：
        /// left_max：左边的最大值，它是从左往右遍历找到的
        /// right_max：右边的最大值，它是从右往左遍历找到的
        /// left：从左往右处理的当前下标
        /// right：从右往左处理的当前下标
        /// 定理一：在某个位置i处，它能存的水，取决于它左右两边的最大值中较小的一个。
        /// 定理二：当我们从左往右处理到left下标时，左边的最大值left_max对它而言是可信的，但right_max对它而言是不可信的。（见下图，由于中间状况未知，对于left下标而言，right_max未必就是它右边最大的值）
        /// 定理三：当我们从右往左处理到right下标时，右边的最大值right_max对它而言是可信的，但left_max对它而言是不可信的。
        /// 对于位置left而言，它左边最大值一定是left_max，右边最大值“大于等于”right_max，这时候，如果left_max<right_max成立，那么它就知道自己能存多少水了。无论右边将来会不会出现更大的right_max，都不影响这个结果。 所以当left_max<right_max时，我们就希望去处理left下标，反之，我们希望去处理right下标。
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int TrapV6(int[] height)
        {
            return 0;
        }
    }
}
