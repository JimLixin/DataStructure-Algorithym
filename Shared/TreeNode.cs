using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.Shared
{
    public class TreeNode
    {
        public TreeNode() { }

        public TreeNode(int nodeValue)
        {
            Value = nodeValue;
        }

        public TreeNode Parent { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        public int Value { get; set; }

        public void DeleteChild(TreeNode node)
        {
            if (node.Value == LeftChild.Value)
            {
                LeftChild = null;
            }
            else if (node.Value == RightChild.Value)
            {
                RightChild = null;
            }
            node = null;
        }

        private void PrintLeftChild(TravelType travelOrder)
        {
            if (LeftChild != null)
                LeftChild.PrintTreeNode(travelOrder);
        }

        private void PrintRightChild(TravelType travelOrder)
        {
            if (RightChild != null)
                RightChild.PrintTreeNode(travelOrder);
        }

        public void PrintTreeNode(TravelType travelOrder)
        {
            bool nodeIsRed = (this is RedBlackTreeNode && (this as RedBlackTreeNode).Color == TreeNodeColor.Red);
            string valueToPrint = (nodeIsRed ? "|" : "") + $"{Value}" + (nodeIsRed ? "|" : "") + " ";
            switch (travelOrder)
            {
                case TravelType.PreOrder:
                    Console.Write(valueToPrint);
                    PrintLeftChild(travelOrder);
                    PrintRightChild(travelOrder);
                    break;
                case TravelType.InOrder:
                    PrintLeftChild(travelOrder);
                    Console.Write(valueToPrint);
                    PrintRightChild(travelOrder);
                    break;
                case TravelType.PostOrder:
                    PrintLeftChild(travelOrder);
                    PrintRightChild(travelOrder);
                    Console.Write(valueToPrint);
                    break;
            }
        }

        public virtual TreeNode InsertTreeNode(TreeNode newNode)
        {
            if (newNode.Value >= Value)
            {
                if (RightChild == null)
                {
                    RightChild = newNode;
                    newNode.Parent = this;
                }
                else
                {
                    RightChild.InsertTreeNode(newNode);
                }
            }
            else
            {
                if (LeftChild == null)
                {
                    LeftChild = newNode;
                    newNode.Parent = this;
                }
                else
                {
                    LeftChild.InsertTreeNode(newNode);
                }
            }
            return newNode;
        }

        public int GetHeight()
        {
            int leftHeight = LeftChild == null ? 0 : LeftChild.GetHeight();
            int rightHeight = RightChild == null ? 0 : RightChild.GetHeight();

            return (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
        }
    }

    public class RedBlackTreeNode : TreeNode
    {
        public RedBlackTreeNode(TreeNodeColor color, int nodeValue)
        {
            Color = color;
            Value = nodeValue;
        }
        public TreeNodeColor Color { get; set; }
    }
}
