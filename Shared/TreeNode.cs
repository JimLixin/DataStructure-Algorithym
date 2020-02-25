using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.Shared
{
    public class TreeNode
    {
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

        public virtual void InsertTreeNode(TreeNode newNode)
        {
            if (newNode.Value > Value)
            {
                if (RightChild == null)
                    RightChild = newNode;
                else
                    RightChild.InsertTreeNode(newNode);
            }
            else if (newNode.Value < Value)
            {
                if (LeftChild == null)
                    LeftChild = newNode;
                else
                    LeftChild.InsertTreeNode(newNode);
            }
            else
            {
                throw new Exception($"Duplicated node values {newNode.Value} detected!");
            }
        }

        public int GetHeight()
        {
            //if (node == null)
            //    return 0;

            int leftHeight = LeftChild == null ? 0 : LeftChild.GetHeight();
            int rightHeight = RightChild == null ? 0 : RightChild.GetHeight();

            return (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
        }
    }
    //public static class TreeNodeExtention
    //{
    //    public static void InsertTreeNode(this TreeNode treeRoot, TreeNode newNode)
    //    {
    //        if (newNode.Value > treeRoot.Value)
    //        {
    //            if (treeRoot.RightChild == null)
    //                treeRoot.RightChild = newNode;
    //            else
    //                treeRoot.RightChild.InsertTreeNode(newNode);
    //        }
    //        else if (newNode.Value < treeRoot.Value)
    //        {
    //            if (treeRoot.LeftChild == null)
    //                treeRoot.LeftChild = newNode;
    //            else
    //                treeRoot.LeftChild.InsertTreeNode(newNode);
    //        }
    //        else
    //        {
    //            throw new Exception($"Duplicated node values {newNode.Value} detected!");
    //        }
    //    }
    //}
}
