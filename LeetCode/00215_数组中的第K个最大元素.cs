using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 215. 数组中的第K个最大元素
/// https://leetcode-cn.com/problems/kth-largest-element-in-an-array/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00215_数组中的第K个最大元素
    {
        /// <summary>
        /// 堆排序
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthLargest(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return -1;
            MinHeap heap = new MinHeap(k);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < k)
                    heap.Insert(nums[i]);
                else if (nums[i] > heap.Top())
                    heap.Insert(nums[i]);
            }
            return heap.Populate();
        }
    }

    public class MinHeap
    {
        private int[] data = null;
        private int pos;
        private int _size;

        public MinHeap(int size)
        {
            _size = size;
            data = new int[_size];
            pos = 0;
        }

        public void Insert(int val)
        {
            if (pos == _size) Populate();
            int cur = pos, parent = (cur & 1) == 0 ? (cur - 1) / 2 : cur / 2;
            data[pos++] = val;
            if (cur > 0) HeapifyUp(cur, parent);
        }

        public int Top()
        {
            return data[0];
        }

        public int Populate()
        {
            int result = data[0];
            data[0] = data[--pos];
            HeapifyDown(0, 1, 2);
            return result;
        }

        private void HeapifyUp(int current, int parent)
        {
            if (current < 0 || parent < 0) return;
            if (data[current] < data[parent])
            {
                Swap(current, parent);
                HeapifyUp(parent, ((parent & 1) == 0 ? (parent - 1) / 2 : parent / 2));
            }
        }

        private void HeapifyDown(int current, int left, int right)
        {
            if (left >= _size && right >= _size) return;
            int index = -1;
            if (left < _size && right < _size)
                index = data[left] < data[right] ? left : right;
            else
                index = left >= _size ? right : left;

            if (data[index] < data[current])
            {
                Swap(current, index);
                HeapifyDown(index, index * 2 + 1, index * 2 + 2);
            }
        }

        private void Swap(int i, int j)
        {
            if (i == j)
                return;
            data[i] = data[i] ^ data[j];
            data[j] = data[i] ^ data[j];
            data[i] = data[i] ^ data[j];
        }
    }
}
