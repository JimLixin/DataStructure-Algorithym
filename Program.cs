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
            var arrayData = new int[] { 6, 2, 3, 1, 7, 14, 5, 8, 20 };
            //Binary Search Tree
            //Online visualize demo about how to build Binary Search Tree: https://www.cs.usfca.edu/~galles/visualization/BST.html
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.BuildTree(arrayData);

            int height = binarySearchTree.GetHeight(binarySearchTree.Root);
            Console.WriteLine($"Height of current BST is: {height}");

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
        }
    }
}
