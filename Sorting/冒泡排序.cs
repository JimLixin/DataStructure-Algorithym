using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.Sorting
{
    public class BubleSort
    {
        public static void Sort(int[] nums, bool asc = true)
        {
            if (nums == null || nums.Length == 0)
                return;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i-1; j++)
                {
                    if (asc)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            nums[j] = nums[j] ^ nums[j + 1];
                            nums[j + 1] = nums[j] ^ nums[j + 1];
                            nums[j] = nums[j] ^ nums[j + 1];
                        }
                    }
                    else
                    {
                        if (nums[j] < nums[j + 1])
                        {
                            nums[j] = nums[j] ^ nums[j + 1];
                            nums[j + 1] = nums[j] ^ nums[j + 1];
                            nums[j] = nums[j] ^ nums[j + 1];
                        }
                    }                    
                }
            }
        }
    }
}
