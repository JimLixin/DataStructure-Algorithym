using System;

namespace Algorithym
{
    public enum SegmentTreeType
    {
        Max = 1,
        Min = 2,
        Sum = 3
    }

    /// <summary>
    /// Segment tree implemented by list
    /// </summary>
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

    public class SegmentTree
    {
        public SegmentTreeType SegmentTreeType { get; set; }

        public SegmentTreeNode Root { get; private set; }

        public SegmentTree(SegmentTreeType treeType)
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
}
