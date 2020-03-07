using Algorithym.Shared;
using System;

namespace Algorithym
{
    public enum SegmentTreeType
    {
        Max = 1,
        Min = 2,
        Sum = 3
    }

    public class SegmentTreeNode
    {
        public SegmentTreeNode(int start, int end, int value)
        {
            Start = start;
            End = end;
            Value = value;
        }

        public SegmentTreeNode LeftChild { get; set; }

        public SegmentTreeNode RightChild { get; set; }

        public int Start { get; set; }

        public int End { get; set; }

        public int Value { get; set; }
    }

    /// <summary>
    /// Segment tree implemented by list
    /// </summary>
    public class SegmentTree_List
    {
        public SegmentTreeType SegmentTreeType { get; set; }

        public SegmentTreeNode Root { get; private set; }

        public SegmentTree_List(SegmentTreeType treeType)
        {
            SegmentTreeType = treeType;
        }

        public SegmentTreeNode BuildTree(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                return null;
            Root = _build(0, inputArray.Length - 1, inputArray);
            return Root;
        }

        public void Update(int index, int value)
        {
            if (index < 0)
                return;

            _update(Root, index, value);
        }

        public int Query(int start, int end)
        {
            return _query(Root, start, end);
        }

        private int _query(SegmentTreeNode node, int start, int end)
        {
            if (start <= node.Start && node.End <= end)
                return node.Value;
            int retValue = 0;
            if (SegmentTreeType == SegmentTreeType.Max)
            {
                retValue = int.MinValue;
            }
            else if (SegmentTreeType == SegmentTreeType.Min)
            {
                retValue = int.MaxValue;
            }
            if (start <= (node.Start + node.End) / 2)
            {
                retValue = getValueByType(retValue, _query(node.LeftChild, start, end));
            }
            if ((node.Start + node.End) / 2 + 1 <= end)
            {
                retValue = getValueByType(retValue, _query(node.RightChild, start, end));
            }
            return retValue;
        }

        private void _update(SegmentTreeNode node, int index, int value)
        {
            if (node.Start == node.End && node.Start == index)
            {
                node.Value = value;
                return;
            }
            if (index <= (node.Start + node.End) / 2)
            {
                _update(node.LeftChild, index, value);
            }
            else
            {
                _update(node.RightChild, index, value);
            }
            node.Value = getValueByType(node.LeftChild.Value, node.RightChild.Value);
        }

        private SegmentTreeNode _build(int start, int end, int[] array)
        {
            SegmentTreeNode node = new SegmentTreeNode(start, end, array[start]);
            if (start == end)
                return node;

            node.LeftChild = _build(start, (start + end) / 2, array);
            node.RightChild = _build((start + end) / 2 + 1, end, array);
            node.Value = getValueByType(node.LeftChild.Value, node.RightChild.Value);
            return node;
        }

        private int getValueByType(int value1, int value2)
        {
            int retValue = 0;
            switch (SegmentTreeType)
            {
                case SegmentTreeType.Max:
                    retValue = Math.Max(value1, value2);
                    break;
                case SegmentTreeType.Min:
                    retValue = Math.Min(value1, value2);
                    break;
                case SegmentTreeType.Sum:
                    retValue = value1 + value2;
                    break;
            }
            return retValue;
        }
    }

    /// <summary>
    /// Segment tree implemented by array
    /// </summary>
    public class SegmentTree_Array
    {
        public SegmentTreeType SegmentTreeType { get; set; }

        private int[] _internalData;

        private int arrayLen;

        public SegmentTree_Array(SegmentTreeType treeType)
        {
            SegmentTreeType = treeType;
        }
        
        public void BuildTree(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                return;

            arrayLen = inputArray.Length;

            // Allocate memory for segment tree 
            //Height of segment tree 
            int x = (int)(Math.Ceiling(Math.Log(arrayLen) / Math.Log(2)));

            //Maximum size of segment tree 
            int max_size = 2 * (int)Math.Pow(2, x) - 1;

            _internalData = new int[max_size];

            _build(inputArray, 0, arrayLen - 1, 0);
        }

        private int _build(int[] array, int start, int end, int index)
        {
            if (start == end)
            {
                _internalData[index] = array[start];
                return array[start];
            }
            int mid = (start + end) / 2;
            _internalData[index] = _merge(_build(array, start, mid, 2 * index + 1), _build(array, mid + 1, end, 2 * index + 2));
            return _internalData[index];
        }

        public void Update(int index, int value)
        {
            _update(0, arrayLen - 1, index, value, 0);
        }

        private void _update(int start, int end, int i, int val, int idx)
        {
            // leaf node. update element.
            if (start == end)
            {
                _internalData[idx] = val;
                return;
            }

            int mid = (start + end) / 2;
            // left tree
            if (i <= mid)
            {
                _update(start, mid, i, val, 2 * idx + 1);
            }
            // right tree
            else
            {
                _update(mid + 1, end, i, val, 2 * idx + 2);
            }
            _internalData[idx] = _internalData[2 * idx + 1] + _internalData[2 * idx + 2];
        }

        public int Query(int start, int end)
        {
            return _query(0, 0, arrayLen - 1, start, end);
        }

        private int _query(int index, int arrayStart, int arrayEnd, int queryStart, int queryEnd)
        {
            if (arrayStart > queryEnd || arrayEnd < queryStart)
                return (SegmentTreeType == SegmentTreeType.Max ? int.MinValue : (SegmentTreeType == SegmentTreeType.Min ? int.MaxValue : 0));

            if (arrayStart >= queryStart && arrayEnd <= queryEnd)
                return _internalData[index];

            int mid = (arrayStart + arrayEnd) / 2;
            return _merge(_query(2*index+1, arrayStart, mid, queryStart, queryEnd), _query(2 * index + 2, mid+1, arrayEnd, queryStart, queryEnd));
        }

        private int _merge(int value1, int value2)
        {
            int retValue = 0;
            switch (SegmentTreeType)
            {
                case SegmentTreeType.Max:
                    retValue = Math.Max(value1, value2);
                    break;
                case SegmentTreeType.Min:
                    retValue = Math.Min(value1, value2);
                    break;
                case SegmentTreeType.Sum:
                    retValue = value1 + value2;
                    break;
            }
            return retValue;
        }
    }
}
