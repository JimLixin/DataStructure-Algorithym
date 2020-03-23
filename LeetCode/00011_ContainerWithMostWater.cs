using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public static class ContainerWithMostWater
    {
        public static int Answer(int[] height)
        {
            int len = height.Length;
            int max = 0, volume = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    volume = (j - i) * Math.Min(height[i], height[j]);
                    if (max < volume)
                        max = volume;
                }
            }
            return max;
        }

        public static int AnswerV2(int[] height)
        {
            int maxArea = 0;
            int left = 0, right = height.Length - 1;
            int leftValue, rightValue, tmp;
            while (left < right)
            {
                leftValue = height[left];
                rightValue = height[right];
                tmp = Math.Min(leftValue, rightValue) * (right - left);
                if (tmp > maxArea)
                    maxArea = tmp;
                if (leftValue > rightValue)
                    right--;
                else
                    left++;
            }
            return maxArea;
        }
    }
}
