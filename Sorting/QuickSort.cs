using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    public static class QuickSort
    {
        public static void Sort(int[] array, int start, int end)
        {
            int hi = end, low = start, pivot = array[low];

            while (hi != low)
            {
                while (low != hi && array[hi] > pivot)
                {
                    hi--;
                }
                if (hi <= low)
                {
                    break;
                }
                FillInElement(array, hi, low);
                low++;

                while (low != hi && array[low] < pivot)
                {
                    low++;
                }
                if (low >= hi)
                {
                    break;
                }
                FillInElement(array, low, hi);
                hi--;
            }
            array[low] = pivot;
            if (low - 1 - start > 1)
            {
                Sort(array, start, low - 1);
            }
            if (end - low + 1 > 1)
            {
                Sort(array, low + 1, end);
            }
            
        }

        public static void SortV2(int[] array, int start, int end)
        {
            int hi = end, low = start, pivot;
            pivot = array[low];
            //What if we randomly pick up a pivot instead of element at low?
            int pivotIndex = new Random().Next(low, hi);
            pivot = array[pivotIndex];

            while (hi != low)
            {
                while (low != hi && array[hi] > pivot)
                {
                    hi--;
                }
                if (hi <= low)
                {
                    break;
                }
                FillInElement(array, hi, low);
                low++;

                while (low != hi && array[low] < pivot)
                {
                    low++;
                }
                if (low >= hi)
                {
                    break;
                }
                FillInElement(array, low, hi);
                hi--;
            }
            array[low] = pivot;
            if (low - 1 - start > 1)
            {
                SortV2(array, start, low - 1);
            }
            if (end - low + 1 > 1)
            {
                SortV2(array, low + 1, end);
            }

        }

        private static void FillInElement(int[] array, int source, int target)
        {
            array[target] = array[source];
            array[source] = int.MinValue;
        }
    }
}
