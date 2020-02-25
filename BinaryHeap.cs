using System;

namespace Algorithym
{
    public enum HeapType
    {
        MinHeap = 1,
        MaxHeap = 2
    }
    public class BinaryHeap
    {
        private int[] storage = null;

        private HeapType _heapType;

        public BinaryHeap(int[] inputData, HeapType heapType)
        {
            storage = new int[inputData.Length];
            inputData.CopyTo(storage, 0);
            _heapType = heapType;
            BuildHeap();
        }

        private void BuildHeap()
        {
            if (storage == null || storage.Length <= 0)
            {
                Console.WriteLine("No input data for building heap...");
                return;
            }

            int currentIndex = storage.Length - 1;
            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex % 2 == 0 ? (currentIndex - 2) / 2 : (currentIndex - 1) / 2);
                int siblingIndex = (currentIndex % 2 == 0 ? currentIndex - 1 : -1);
                HeapifyDown(currentIndex, siblingIndex, parentIndex);

                currentIndex -= (siblingIndex > 0 ? 2 : 1);
            }
        }

        private void HeapifyDown(int childIndex1, int childIndex2, int parentIndex)
        {
            int swapChildIndex = (childIndex1 > storage.Length - 1 && childIndex2 > storage.Length - 1) ? -1 : (
                    (childIndex1 > storage.Length - 1 || childIndex1 < 0) ? childIndex2 :
                    ((childIndex2 > storage.Length - 1 || childIndex2 < 0) ? childIndex1 : (_heapType == HeapType.MinHeap ?
                    (storage[childIndex1] - storage[childIndex2] > 0 ? childIndex2 : childIndex1) :
                    (storage[childIndex1] - storage[childIndex2] > 0 ? childIndex1 : (childIndex2))))
                );

            if (swapChildIndex > 0 && 
                    (_heapType == HeapType.MinHeap && storage[swapChildIndex] < storage[parentIndex] ||
                    _heapType == HeapType.MaxHeap && storage[swapChildIndex] > storage[parentIndex]))
            {
                Swap(swapChildIndex, parentIndex);
                HeapifyDown(2 * swapChildIndex + 1, 2 * swapChildIndex + 2, swapChildIndex);
            }
        }

        private void HeapifyUp(int childIndex, int parentIndex)
        {
            if (childIndex >= 0 && parentIndex >= 0 &&
                (_heapType == HeapType.MinHeap && storage[childIndex] < storage[parentIndex] ||
                    _heapType == HeapType.MaxHeap && storage[childIndex] > storage[parentIndex]))
            {
                Swap(childIndex, parentIndex);
                HeapifyUp(parentIndex, (parentIndex % 2 == 0 ? (parentIndex - 2) / 2 : (parentIndex - 1) / 2));
            }
        }

        private void Swap(int indexA, int indexB)
        {
            int temp;
            temp = storage[indexA];
            storage[indexA] = storage[indexB];
            storage[indexB] = temp;
        }

        public void Insert(int newData)
        {
            Array.Resize(ref storage, storage.Length + 1);
            storage[storage.Length - 1] = newData;

            int currentIndex = storage.Length - 1;
            int parentIndex = (currentIndex % 2 == 0 ? (currentIndex - 2) / 2 : (currentIndex - 1) / 2);
            HeapifyUp(currentIndex, parentIndex);
        }

        public void Change(int i, int newValue)
        {
            if (i < 0 || i > storage.Length - 1)
                return;
            
            if (_heapType == HeapType.MinHeap && newValue < storage[i] ||
                    _heapType == HeapType.MaxHeap && newValue > storage[i])
            {
                storage[i] = newValue;
                HeapifyUp(i, (i % 2 == 0 ? (i - 2) / 2 : (i - 1) / 2));
            }
        }

        public void Delete(int i)
        {
            Change(i, _heapType == HeapType.MinHeap ? int.MinValue : int.MaxValue);
            PopulateTop();
        }

        public int PopulateTop()
        {
            int retVal = storage[0];
            storage[0] = storage[storage.Length - 1];
            Array.Resize(ref storage, storage.Length - 1);
            HeapifyDown(1, 2, 0);
            return retVal;
        }

        public int GetTop()
        {
            return storage[0];
        }

        public int[] Sort()
        {
            int[] retData = new int[storage.Length];

            int i = 0;
            while (storage.Length > 0)
            {
                retData[i] = PopulateTop();
                i++;
            }
            return retData;
        }
    }
}
