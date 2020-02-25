using Algorithym.Shared;
using System;
using System.Linq;

namespace Algorithym
{
    //public enum TravelType
    //{
    //    //Depth first travel
    //    PreOrder = 1,
    //    InOrder = 2,
    //    PostOrder = 3,
    //    BreadthFirstTravel = 4
    //}

    /// <summary>
    /// BST
    /// </summary>
    public class BinarySearchTree
    {
        public TreeNode Root { get; private set; }

        public TreeNode BuildTree(int[] inputArray)
        {
            if (inputArray == null || !inputArray.Any())
            {
                Console.WriteLine("Input array is empty, return without nothing...");
                return null;
            }
            Root = new TreeNode(inputArray[0]);
            for (int i = 1; i < inputArray.Length; i++)
            {
                Root.InsertTreeNode(new TreeNode(inputArray[i]));
            }
            return Root;
        }

        public void Traval(TravelType type)
        {
            if (Root != null)
            {
                Console.WriteLine($"Travel type -> {type.ToString()}");
                if (type == TravelType.BreadthFirstTravel)
                {
                    Console.Write($"{Root.Value} ");
                }
                else
                {
                    Root.PrintTreeNode(type);
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Tree is not initialized...");
            }
        }

        public int GetHeight(TreeNode node)
        {
            return Root.GetHeight();
        }

        //public int GetHeight(TreeNode node)
        //{
        //    if (node == null)
        //        return 0;

        //    int leftHeight = GetHeight(node.LeftChild);
        //    int rightHeight = GetHeight(node.RightChild);

        //    return (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
        //}
    }

    //public class TreeNode
    //{
    //    public TreeNode LeftChild { get; set; }

    //    public TreeNode RightChild { get; set; }

    //    public int Value { get; set; }

    //    public TreeNode(int nodeValue)
    //    {
    //        Value = nodeValue;
    //    }

    //    private void PrintLeftChild(TravelType travelOrder)
    //    {
    //        if(LeftChild != null)
    //            LeftChild.PrintTreeNode(travelOrder);
    //    }

    //    private void PrintRightChild(TravelType travelOrder)
    //    {
    //        if (RightChild != null)
    //            RightChild.PrintTreeNode(travelOrder);
    //    }

    //    public void PrintTreeNode(TravelType travelOrder)
    //    {
    //        switch (travelOrder)
    //        {
    //            case TravelType.PreOrder:
    //                Console.Write($"{Value} ");
    //                PrintLeftChild(travelOrder);
    //                PrintRightChild(travelOrder);
    //                break;
    //            case TravelType.InOrder:
    //                PrintLeftChild(travelOrder);
    //                Console.Write($"{Value} ");
    //                PrintRightChild(travelOrder);
    //                break;
    //            case TravelType.PostOrder:
    //                PrintLeftChild(travelOrder);
    //                PrintRightChild(travelOrder);
    //                Console.Write($"{Value} ");
    //                break;
    //        }
    //    }
    //}

    
}
