using Algorithym.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryHeapTest();
            BinarySearchTreeTest();
            AVLTreeTest();
            RedBlackTreeTest();

            Console.ReadLine();
        }

        static void BinaryHeapTest()
        {
            int tmpData, i = 0;
            var random = new Random();
            var arrayList = new List<int>();
            while(i < 50)
            {
                tmpData = random.Next() % 100;
                if (!arrayList.Contains(tmpData))
                {
                    arrayList.Add(tmpData);
                    i++;
                }
            }
            var inputData = arrayList.ToArray();
            BinaryHeap heap = new BinaryHeap(inputData, HeapType.MaxHeap);
            int top = heap.PopulateTop();
            top = heap.PopulateTop();
            top = heap.PopulateTop();
            top = heap.PopulateTop();
            heap.Insert(200);

            int[] sortedArray = heap.Sort();
        }

        static void BinarySearchTreeTest()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 6, 2, 3, 1, 7, 14, 5, 8, 20 };
            //Binary Search Tree
            //Online visualize demo about how to build Binary Search Tree: https://www.cs.usfca.edu/~galles/visualization/BST.html
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.BuildTree(arrayData);

            int height = binarySearchTree.GetHeight(binarySearchTree.Root);
            Console.WriteLine($"Height of current BST Tree is: {height}");

            binarySearchTree.Traval(TravelType.InOrder);
            binarySearchTree.Traval(TravelType.PreOrder);
            binarySearchTree.Traval(TravelType.PostOrder);

            //Expected Output:
            //Travel order -> InOrder
            //1 2 3 5 6 7 8 14 20
            //Travel order -> PreOrder
            //6 2 1 3 5 7 14 8 20
            //Travel order -> PostOrder
            //1 5 3 2 8 20 14 7 6

            //Thinking: Inorder of a BST is actually equal to a sorting
            Console.WriteLine("<================================================>\r\n");
        }

        static void AVLTreeTest()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 5,14,23,38,46,75,98,134,2,18,27,34,41,65,88,92 };
            //AVL tree
            //Online visualize demo about how to build AVL Tree: https://www.cs.usfca.edu/~galles/visualization/AVLtree.html
            BinarySearchTree avlTree = new BinarySearchTree(TreeType.AVL);
            
            //Build tree by input array
            //avlTree.BuildTree(arrayData);

            //Build tree by insert one by one
            avlTree.Insert(5);
            avlTree.Insert(14);
            avlTree.Insert(23);
            avlTree.Insert(38);
            avlTree.Insert(46);
            avlTree.Insert(75);
            avlTree.Insert(98);
            avlTree.Insert(134);
            avlTree.Insert(2);
            avlTree.Insert(18);
            avlTree.Insert(27);
            avlTree.Insert(34);
            avlTree.Insert(41);
            avlTree.Insert(65);
            avlTree.Insert(88);
            avlTree.Insert(92);

            int height = avlTree.GetHeight(avlTree.Root);
            Console.WriteLine($"Height of current AVL Tree is: {height}");

            avlTree.Traval(TravelType.InOrder);
            avlTree.Traval(TravelType.PreOrder);
            avlTree.Traval(TravelType.PostOrder);

            //Thinking: InOrder of a BST is actually equal to a sorting
            Console.WriteLine("<================================================>\r\n");
        }

        static void RedBlackTreeTest()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 65, 32, 98, 11, 46, 75, 120, 5, 99, 18, 27, 57, 102, 83, 88, 92 };
            //RedBlack tree
            //Online visualize demo about how to build RedBlack Tree: https://www.cs.usfca.edu/~galles/visualization/RedBlack.html
            BinarySearchTree rbTree = new BinarySearchTree(TreeType.RedBlack);

            //Build tree by input array
            rbTree.BuildTree(arrayData);

            //Build tree by insert one by one
            //rbTree.Insert(5);
            //rbTree.Insert(14);
            //rbTree.Insert(23);
            //rbTree.Insert(38);
            //rbTree.Insert(46);
            //rbTree.Insert(75);
            //rbTree.Insert(98);
            //rbTree.Insert(134);
            //rbTree.Insert(2);
            //rbTree.Insert(18);
            //rbTree.Insert(27);
            //rbTree.Insert(34);
            //rbTree.Insert(41);
            //rbTree.Insert(65);
            //rbTree.Insert(88);
            //rbTree.Insert(92);

            int height = rbTree.GetHeight(rbTree.Root);
            Console.WriteLine($"Height of current RedBlack Tree is: {height}");

            rbTree.Traval(TravelType.InOrder);
            rbTree.Traval(TravelType.PreOrder);
            rbTree.Traval(TravelType.PostOrder);

            //Thinking: InOrder of a BST is actually equal to a sorting
            Console.WriteLine("<================================================>\r\n");
        }
    }
}
