﻿using Algorithym.LeetCode;
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
            var result = generate_parentheses.GenerateParenthesis(4);
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            //ThreeSumClosestHelper threeSumClostest = new ThreeSumClosestHelper();
            //var result = threeSumClostest.ThreeSumClosest(new int[] { -1, 2, 1, 4 }, 1);

            //var result = ThreeSum.Answer(new int[] { -1, 0, 1, 2, -1, -4, 3, 4, -5, 6 });
            //var result = ThreeSum.Answer(new int[] { 0,0,0,0,0});
            //foreach (var s in result)
            //{
            //    Console.WriteLine(string.Join(" ", s));
            //}

            //var result = LetterCombinationsOfAPhoneNumber.Answer("789");
            //foreach (var s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //var result = DfsPermutation.Make(new int[] { 1,3,6,2});

            //DfsPermutationGenerator dfs = new DfsPermutationGenerator(9);
            //dfs.Make();

            //DfsSolution.subsets(new int[] { 1,2,3});

            RomanToInteger.RomanToInt("MCMXCIV");
            StringtoInteger.Answer("-91283472332");

            LeetCodeTesting();

            QuickSortTest();
            BinaryHeapTest();
            BinarySearchTreeTest();
            BinarySearchTreeMirrorTest();
            AVLTreeTest();
            RedBlackTreeTest();
            SplayTreeTest();
            SegmentTreeTest_Max();
            SegmentTreeTest_Min();
            SegmentTreeTest_Sum();
            BTreeTest();

            Console.ReadLine();
        }

        public static void dfs(int step)
        {

        }

        public static void LeetCodeTesting()
        {
            string data = ZigZagConvert.Answer2("PAYPALISHIRING", 4);
        }

        static void QuickSortTest()
        {
            Console.WriteLine("<=================== Quick sort start =======================>");
            int[] array = new int[] { 47, 18, 150, 10, 27, 31, 6, 88, 2, 112, 10, 66, 20, 98, 36, 188, 6, 51, 42, 79, 13, 22, 6, 74, 47, 79, 13, 22, 6, 74, 47 };
            Console.WriteLine(string.Join("  ", array));
            Console.WriteLine("Sorting...");
            QuickSort.Sort(array, 0, array.Length - 1, randonPivot: false);
            Console.WriteLine(string.Join("  ", array));
            Console.WriteLine("<=================== Quick sort end =======================>");
        }

        static void BinaryHeapTest()
        {
            Console.WriteLine("<================================================>");
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
            Console.WriteLine($"Input data is: {string.Join(", ", inputData)}");
            BinaryHeap heap = new BinaryHeap(inputData, HeapType.MinHeap);
            //int top = heap.PopulateTop();
            //top = heap.PopulateTop();
            //top = heap.PopulateTop();
            //top = heap.PopulateTop();
            //heap.Insert(200);

            int[] sortedArray = heap.Sort();
            Console.WriteLine($"After {HeapType.MaxHeap.ToString()} sort: {string.Join(",", sortedArray)}");
            Console.WriteLine("<================================================>");
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

        /// <summary>
        /// Answer for this question: https://practice.geeksforgeeks.org/problems/mirror-tree/1
        /// </summary>
        static void BinarySearchTreeMirrorTest()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 6, 2, 3, 1, 7, 14, 5, 8, 20 };
            
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.BuildTree(arrayData);

            Console.WriteLine("Inorder travel before mirror is:");
            binarySearchTree.Traval(TravelType.InOrder);

            binarySearchTree.Mirror();

            Console.WriteLine("Inorder travel before mirror is:");
            binarySearchTree.Traval(TravelType.InOrder);

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

            avlTree.Delete(75);
            avlTree.Delete(38);
            avlTree.Delete(65);
            avlTree.Delete(2);

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
            Console.WriteLine($"|x| stand for Red node.");

            rbTree.Traval(TravelType.InOrder);
            rbTree.Traval(TravelType.PreOrder);
            rbTree.Traval(TravelType.PostOrder);

            //Thinking: InOrder of a BST is actually equal to a sorting
            Console.WriteLine("<================================================>\r\n");
        }

        static void SplayTreeTest()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 65, 32, 98, 11, 46, 75, 120, 5, 99, 18, 27, 57, 102, 83, 88, 92 };
            //Splay tree
            //Online visualize demo about how to build Splay Tree: https://www.cs.usfca.edu/~galles/visualization/SplayTree.html
            BinarySearchTree splayTree = new BinarySearchTree(TreeType.Splay);

            //Build tree by input array
            splayTree.BuildTree(arrayData);

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

            splayTree.Delete(99);

            int height = splayTree.GetHeight(splayTree.Root);
            Console.WriteLine($"Height of current Splay Tree is: {height}");
            splayTree.Traval(TravelType.InOrder);
            splayTree.Traval(TravelType.PreOrder);
            splayTree.Traval(TravelType.PostOrder);

            //Thinking: InOrder of a BST is actually equal to a sorting
            Console.WriteLine("<================================================>\r\n");
        }

        static void SegmentTreeTest_Max()
        {
            Console.WriteLine("<================================================>");
            //var arrayData = new int[] { 65, 32, 98, 11, 46, 75, 120, 5, 99, 18, 27, 57, 102, 83, 88, 92 };
            var arrayData = new int[] { 65, 32, 98, 11, 46, 75, 55, 5, 99 };
            //Segment tree
            //Online visualize demo about how to build Segment Tree: https://visualgo.net/zh/segmenttree
            SegmentTree_List tree1 = new SegmentTree_List(SegmentTreeType.Max);
            SegmentTree_Array tree2 = new SegmentTree_Array(SegmentTreeType.Max);

            //Build tree by input array
            tree1.BuildTree(arrayData);
            tree2.BuildTree(arrayData);

            //Update Nth element to new value
            tree1.Update(3, 123);
            tree2.Update(3, 123);

            //Find max value in [N,M] section
            int start = 4, end = 7;
            int target1 = tree1.Query(start, end);
            int target1_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target1}");
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target1_2}");

            start = 2; end = 6;
            int target2 = tree1.Query(start, end);
            int target2_2 = tree1.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target2}");
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target2_2}");

            start = 1; end = 5;
            int target3 = tree1.Query(start, end);
            int target3_2 = tree1.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target3}");
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target3_2}");
            Console.WriteLine("<================================================>\r\n");
        }

        static void SegmentTreeTest_Min()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 65, 32, 98, 11, 46, 75, 120, 5, 99, 18, 27, 57, 102, 83, 88, 92 };
            //Segment tree
            //Online visualize demo about how to build Segment Tree: https://visualgo.net/zh/segmenttree
            SegmentTree_List tree1 = new SegmentTree_List(SegmentTreeType.Min);
            SegmentTree_Array tree2 = new SegmentTree_Array(SegmentTreeType.Min);

            //Build tree by input array
            tree1.BuildTree(arrayData);
            tree2.BuildTree(arrayData);

            //Update Nth element to new value
            tree1.Update(3, 123);
            tree2.Update(3, 123);

            //Find min value in [N,M] section
            int start = 4, end = 7;
            int target1 = tree1.Query(start, end);
            int target1_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target1}");
            Console.WriteLine($"{tree2.SegmentTreeType.ToString()} value of [{start}, {end}] is {target1_2}");

            start = 2; end = 6;
            int target2 = tree1.Query(start, end);
            int target2_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target2}");
            Console.WriteLine($"{tree2.SegmentTreeType.ToString()} value of [{start}, {end}] is {target2_2}");

            start = 1; end = 5;
            int target3 = tree1.Query(start, end);
            int target3_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target3}");
            Console.WriteLine($"{tree2.SegmentTreeType.ToString()} value of [{start}, {end}] is {target3_2}");
            Console.WriteLine("<================================================>\r\n");
        }

        static void SegmentTreeTest_Sum()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 65, 32, 98, 11, 46, 75, 120, 5, 99, 18, 27, 57, 102, 83, 88, 92 };
            //Segment tree
            //Online visualize demo about how to build Segment Tree: https://visualgo.net/zh/segmenttree
            SegmentTree_List tree1 = new SegmentTree_List(SegmentTreeType.Sum);
            SegmentTree_Array tree2 = new SegmentTree_Array(SegmentTreeType.Sum);

            //Build tree by input array
            tree1.BuildTree(arrayData);
            tree2.BuildTree(arrayData);

            //Find SUM value in [N,M] section
            int start = 4, end = 7;
            int target1 = tree1.Query(start, end);
            int target1_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target1}");
            Console.WriteLine($"{tree2.SegmentTreeType.ToString()} value of [{start}, {end}] is {target1_2}");

            //Update Nth element to new value
            tree1.Update(3, 123);
            tree2.Update(3, 123);

            start = 2; end = 6;
            int target2 = tree1.Query(start, end);
            int target2_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target2}");
            Console.WriteLine($"{tree2.SegmentTreeType.ToString()} value of [{start}, {end}] is {target2_2}");

            start = 1; end = 5;
            int target3 = tree1.Query(start, end);
            int target3_2 = tree2.Query(start, end);
            Console.WriteLine($"{tree1.SegmentTreeType.ToString()} value of [{start}, {end}] is {target3}");
            Console.WriteLine($"{tree2.SegmentTreeType.ToString()} value of [{start}, {end}] is {target3_2}");
            Console.WriteLine("<================================================>\r\n");
        }

        static void BTreeTest()
        {
            Console.WriteLine("<================================================>");
            var arrayData = new int[] { 6, 2, 3, 1, 7, 14, 5, 8, 20,35,19,44,27 };
            //BTree
            //Online visualize demo about how to build BTree: https://www.cs.usfca.edu/~galles/visualization/BTree.html
            BTree bTree = new BTree(4);
            //bTree.Insert(6);
            //bTree.Insert(2);
            //bTree.Insert(3);
            //bTree.Insert(1);
            //bTree.Insert(7);
            //bTree.Insert(14);
            //bTree.Insert(5);
            //bTree.Insert(8);
            //bTree.Insert(20);
            //bTree.Insert(35);
            //bTree.Insert(19);
            //bTree.Insert(44);
            //bTree.Insert(27);
            bTree.BuildTree(arrayData);
            bTree.Travel();

            Console.WriteLine("<================================================>\r\n");
        }
    }

    public class ThreeSumClosestHelper
    {
        private bool[] vis;
        private int[] data;
        private int tmp;
        private int result;
        private bool match = false;
        private readonly int NSUM = 3;
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length < NSUM)
                return 0;

            vis = new bool[NSUM + 1];
            data = new int[NSUM];
            for (int i = 0; i < NSUM; i++)
            {
                data[i] = -1;
            }
            _answer(0, 0, nums, target);
            return result;
        }

        public void _answer(int step, int index, int[] nums, int target)
        {
            if (step >= NSUM)
            {
                int total = data[0] + data[1] + data[2];
                int diff = total > target ? (total - target) : (target - total);
                if (diff == 0)
                {
                    match = true;
                    result = total;
                }
                else if (diff < tmp)
                {
                    tmp = diff;
                    result = total;
                }
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!vis[step])
                {
                    vis[step] = true;
                    data[step] = i;
                    _answer(step + 1, i, nums, target);
                    vis[step] = false;
                }
            }
        }
    }

    public class ListNode
    {
        public ListNode(int x)
        {
            val = x;
        }
        public int val { get; set; }
        public ListNode next { get; set; }
    }
}
