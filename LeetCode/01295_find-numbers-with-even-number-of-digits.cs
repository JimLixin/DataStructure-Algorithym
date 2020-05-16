using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1295. 统计位数为偶数的数字
/// https://leetcode-cn.com/problems/find-numbers-with-even-number-of-digits/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _01295_find_numbers_with_even_number_of_digits
    {
        /// <summary>
        /// 常规解法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int digits = 0;
                while (nums[i] != 0)
                {
                    nums[i] /= 10;
                    digits++;
                }
                if ((digits & 1) == 0)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// 枚举 + 数学
        /// 我们也可以使用语言内置的以 10 为底的对数函数 log10() 来得到整数 x 包含的数字个数。
        /// 一个包含 k 个数字的整数 x 满足不等式 10^{k-1} \leq x < 10^k10 k−1≤x<10 k。
        /// 将不等式取对数，得到 k - 1 \leq \log_{10}(x) < kk−1≤log10(x)<k，因此
        /// 我们可以用 k = \lfloor\log_{10}(x) + 1\rfloork=⌊log 10(x)+1⌋ 得到 x 包含的数字个数 k，
        /// 其中 \lfloor a \rfloor⌊a⌋ 表示将 aa 进行下取整，例如\lfloor 5.2 \rfloor = 5⌊5.2⌋
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumbersV2(int[] nums)
        {
            int ans = 0;
            foreach(int num in nums)
            {
                if ((int)(Math.Log10(num) + 1) % 2 == 0)
                {
                    ++ans;
                }
            }
            return ans;
        }
    }
}
