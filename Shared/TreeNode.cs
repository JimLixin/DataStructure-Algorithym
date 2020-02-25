using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.Shared
{
    public class TreeNode
    {
        public TreeNode Parent { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        public int Value { get; set; }

        public TreeNode(){}

        public TreeNode(int nodeValue)
        {
            Value = nodeValue;
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
            switch (travelOrder)
            {
                case TravelType.PreOrder:
                    Console.Write($"{Value} ");
                    PrintLeftChild(travelOrder);
                    PrintRightChild(travelOrder);
                    break;
                case TravelType.InOrder:
                    PrintLeftChild(travelOrder);
                    Console.Write($"{Value} ");
                    PrintRightChild(travelOrder);
                    break;
                case TravelType.PostOrder:
                    PrintLeftChild(travelOrder);
                    PrintRightChild(travelOrder);
                    Console.Write($"{Value} ");
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

        public TreeNode GetLargestLeftChild()
        {
            return null;
        }

        public int GetHeight()
        {
            int leftHeight = LeftChild == null ? 0 : LeftChild.GetHeight();
            int rightHeight = RightChild == null ? 0 : RightChild.GetHeight();

            return (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
        }
    }
}
