using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    public class BTreeNode
    {
        public BTreeNode()
        {
            Data = new SortedList<int, BTreeNode>();
        }
        public BTreeNode(SortedList<int, BTreeNode> data)
        {
            Data = data;
        }
        public SortedList<int, BTreeNode> Data { get; set; }

        public bool IsLeaf()
        {
            if (Data == null)
                return true;
            foreach (var item in Data)
            {
                if (item.Value != null)
                    return false;
            }
            return true;
        }

        public BTreeNode Parent { get; set; }

        public void AddData(int value, BTreeNode child)
        {
            Data.Add(value, child);
        }
        public BTreeNode RemoveData(int value)
        {
            var target = Data[value];
            Data.Remove(value);
            return target;
        }
    }

    public class BTree
    {
        public BTree(int degree)
        {
            Degree = degree;
        }
        public int Degree { get; set; }

        public int KeyLimit { get { return Degree - 1;  }}

        public BTreeNode Root { get; set; }

        public BTreeNode BuildTree(int[] data)
        {
            foreach (var d in data)
            {
                Insert(d);
            }
            return Root;
        }

        public BTreeNode Insert(int newValue)
        {
            BTreeNode returnNode = null;
            if (Root == null)
            {
                returnNode = new BTreeNode();
                returnNode.AddData(newValue, null);
                Root = returnNode;
            }
            else
            {
                _insertTreeNode(Root, newValue);
            }
            return Root;
        }

        public void Travel()
        {
            if (Root != null)
            {
                _travel(Root);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Tree is not initialized...");
            }
        }

        private void _travel(BTreeNode node)
        {
            foreach (var item in node.Data)
            {
                if (item.Value != null)
                {
                    _travel(item.Value);
                }
                if (item.Key != int.MaxValue)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }

        private void Split(BTreeNode currentNode)
        {
            if (currentNode.Data.Where(i => i.Key != int.MaxValue).Count() > KeyLimit)
            {
                var isRoot = (currentNode.Parent == null);
                int indexToBeLevelUp = KeyLimit / 2;
                var targetElement = currentNode.Data.ElementAt(indexToBeLevelUp);
                var newData = new SortedList<int, BTreeNode>();
                for (int i = 0; i < indexToBeLevelUp; i++)
                {
                    var tmpNode = currentNode.Data.ElementAt(i);
                    currentNode.RemoveData(tmpNode.Key);
                    newData.Add(tmpNode.Key, tmpNode.Value);
                }
                currentNode.RemoveData(targetElement.Key);
                BTreeNode newSibling = new BTreeNode(newData);
                if (targetElement.Value != null)
                {
                    targetElement.Value.Parent = newSibling;
                    newSibling.AddData(int.MaxValue, targetElement.Value);
                }
                BTreeNode parent = (isRoot ? new BTreeNode() : currentNode.Parent);
                parent.AddData(targetElement.Key, newSibling);
                if (isRoot)
                {
                    parent.AddData(int.MaxValue, currentNode);
                }
                newSibling.Parent = parent;
                currentNode.Parent = parent;
                if (isRoot)
                {
                    Root = parent;
                }
                Split(parent);
            }
        }

        private void _insertTreeNode(BTreeNode currentNode, int newValue)
        {
            if (currentNode.IsLeaf())
            {
                currentNode.AddData(newValue, null);
                Split(currentNode);
            }
            else
            {
                //go down next level
                for(int i = 0; i< currentNode.Data.Count; i++)
                {
                    var item = currentNode.Data.ElementAt(i);
                    if (newValue < item.Key)
                    {
                        _insertTreeNode(item.Value, newValue);
                        break;
                    }
                }
            }
        }
    }
}
