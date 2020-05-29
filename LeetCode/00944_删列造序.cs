using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 944. 删列造序
/// https://leetcode-cn.com/problems/delete-columns-to-make-sorted/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00944_删列造序
    {
        public int MinDeletionSize(string[] A)
        {
            int count = 0, index = 0;
            while (index < A[0].Length)
            {
                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i][index] < A[i - 1][index])
                    {
                        count++;
                        break;
                    }
                }
                index++;
            }
            return count;
        }
    }
}
