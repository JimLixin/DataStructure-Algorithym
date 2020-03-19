using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    public static class QuickSort
    {
        public static void Sort(int[] array, int start, int end, bool randonPivot = false)
        {
            int hi = end, low = start, pivot;
            if (randonPivot)
            {
                int pivotIndex = new Random().Next(low, hi);
                var tmp = array[pivotIndex];
                array[pivotIndex] = array[low];
                array[low] = tmp;
            }
            pivot = array[low];

            while (hi != low)
            {
                while (low != hi && array[hi] > pivot)
                {
                    hi--;
                }
                if (hi > low)
                {
                    array[low] = array[hi];
                    low++;
                }
                
                while (low != hi && array[low] < pivot)
                {
                    low++;
                }
                if (low < hi)
                {
                    array[hi] = array[low];
                    hi--;
                }
            }
            array[low] = pivot;
            if (low - start > 1)
            {
                Sort(array, start, low - 1);
            }
            if (end - low > 0)
            {
                Sort(array, low + 1, end);
            }   
        }
    }
}
