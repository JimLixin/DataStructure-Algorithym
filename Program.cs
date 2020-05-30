using Algorithym.LeetCode;
using Algorithym.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithym.LeetCode.Dynamic_Progamming;
using Algorithym.LeetCode.Topics;
using Algorithym.Sorting;

namespace Algorithym
{
    class Program
    {
        public static int binarySearch(int[] nums, int start, int end, int target)
        {
            
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] > target)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[][] people = new int[][] { new int[] { 7,0}, new int[] { 4, 4 }, new int[] { 7, 1 }, 
                new int[] { 5, 0 }, new int[] { 6, 1 },new int[] { 5,2} };

            var sorted = people.OrderByDescending(i => i[0]).ThenBy(i => i[1]).ToArray();
            SortedList<int, int> sortedList = new SortedList<int, int>();
            HashSet<int> map = new HashSet<int>();
            StringBuilder sb = new StringBuilder("Hello");
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] >= 65 && sb[i] <= 90)
                    sb[i] = (char)(sb[i] + 32);
            }
            int[] arrayForSort = new int[] { -10, 2, 1, 9, -6, 44, 0, 3, -17, 8 };
            BubleSort.Sort(arrayForSort, false);
            int[] nums2 = new int[] { 0, 1, 2 ,4, 5, 6, 7,9};
            var binRes = binarySearch(nums2, 0 , nums2.Length - 1, 0);

            List<int> list = new List<int>(new int[] { 1,3,5,7,9});
             var biRes = list.BinarySearch(4);
            int[] nums = new int[] {3,0,1};
            (new missing_number()).MissingNumber(nums);


            int seed = 0;
            var xor = nums.Aggregate(seed++, (x, y) => x ^ y);

            xor = Enumerable.Range(1, 4).Aggregate((x, y) => x ^ y);

            (new Swapping_two_integer_variables_without_an_intermediary_variable()).swapArray(nums, 0, 2);
            ListNode head = new ListNode(0);
            ListNode pre = head;
            for (int i = 1; i < 10; i++)
            {
                ListNode tmp = new ListNode(i);
                pre.next = tmp;
                pre = pre.next;
            }
            var bst = (new convert_sorted_list_to_binary_search_treeV2()).SortedListToBST(head);

            LeetCode.TreeNode node = new LeetCode.TreeNode(1);
            LeetCode.TreeNode node1 = new LeetCode.TreeNode(2);
            LeetCode.TreeNode node12 = new LeetCode.TreeNode(5);
            node.left = node1;
            node.right = node12;
            LeetCode.TreeNode node21 = new LeetCode.TreeNode(3);
            LeetCode.TreeNode node22 = new LeetCode.TreeNode(4);
            node1.left = node21;
            node1.right = node22;
            LeetCode.TreeNode node31 = new LeetCode.TreeNode(6);
            node12.right = node31;

            (new flatten_binary_tree_to_linked_list()).Flatten(node);

            (new construct_binary_tree_from_preorder_and_inorder_traversalV2()).BuildTree(
                    new int[] { 3, 9, 20, 15, 7 },
                    new int[] { 9, 3, 15, 20, 7 }
                );

            IList<IList<int>> result2 = new List<IList<int>>(); 
            result2.Add(new int[] { 1,2,3}.Concat(new int[] { 4,5,6}).ToArray());
            List<int[]> _matrix = new List<int[]>();
            _matrix.Add(new int[] { 1, 2, 0, 4});
            _matrix.Add(new int[] { 5, 6, 7, 8});
            _matrix.Add(new int[] { 9, 10, 11, 12 });

            var matrix = _matrix.ToArray();

            var row1 = matrix[0];
            var bol = Enumerable.Any(row1, i => i == 0);
            for (int i = 0; i < 4; i++)
            {
                matrix[0][i] = 0;
            }

            //int n = 3;
            //int[][] matrix = new int[n][];
            //for (int i = 0; i < n; i++)
            //{
            //    matrix[i] = new int[n];
            //}
            //List<int[]> positions = new List<int[]>();
            //int top = 0, left = 0, count = 1;
            //while (n > 0)
            //{
            //    if (n == 1)
            //    {
            //        (positions as List<int[]>).Add(new int[] { top, left });
            //        break;
            //    }
            //    (positions as List<int[]>).AddRange(Enumerable.Range(left, n - 1).Select(i => new int[] { top, i }));
            //    (positions as List<int[]>).AddRange(Enumerable.Range(top, n - 1).Select(i => new int[] { i, (left + n - 1) }));
            //    (positions as List<int[]>).AddRange(Enumerable.Range(left + 1, n - 1).Reverse().Select(i => new int[] { (top + n - 1), i }));
            //    (positions as List<int[]>).AddRange(Enumerable.Range(top + 1, n - 1).Reverse().Select(i => new int[] { i, left }));
            //    top++;
            //    left++;
            //    n -= 2;
            //}

            //Array.ForEach(positions.ToArray(), i => {
            //    matrix[i[0]][i[1]] = count;
            //    count++;
            //    Console.WriteLine($"[{i[0]},{i[1]}] - {matrix[i[0]][i[1]]}");
            //});


            //int[][] matrix2 = new int[2][];
            //IList<int[]> resti = new List<int[]>();
            //int width =3, height = 3, top = 1, left = 1;
            //(resti as List<int[]>).AddRange(Enumerable.Range(left, width - 1).Select(i => new int[] { top, i }).ToArray());
            //(resti as List<int[]>).AddRange(Enumerable.Range(top, height - 1).Select(i => new int[] { i, (left + width - 1) }).ToArray());
            //(resti as List<int[]>).AddRange(Enumerable.Range(left + 1, width - 1).Reverse().Select(i => new int[] { (top + height - 1), i }).ToArray());
            //(resti as List<int[]>).AddRange(Enumerable.Range(top + 1, height - 1).Reverse().Select(i => new int[] { i, left }).ToArray());
            //var qwe = resti.Select(i => matrix2[i[0]][i[1]]).ToList();

            //ListNode head = new ListNode(1);
            //ListNode node1 = new ListNode(4);
            //ListNode node2 = new ListNode(3);
            //ListNode node3 = new ListNode(2);
            //ListNode node4 = new ListNode(5);
            //ListNode node5 = new ListNode(2);
            //head.next = node1;
            //node1.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node5;

            //var head2 = (new partition_list()).Partition(head, 3);
            var data1 = (new permutation_sequenceV2()).GetPermutation(4, 10);
            int[] arr1 = new int[] { 0,0,3,0,0,0,0,0,0};
            int[] arr2 = new int[] { -1,1,1,1,2,3 };

            (new merge_sorted_array()).MergeV2(arr1, 3, arr2, 6);
            var car = (new CarPlateNumber()).Generate();
            int rob = (new house_robber_ii()).Rob(new int[] { 1, 2, 1, 1 });
            int[] arr = Enumerable.Repeat(int.MinValue, 4).ToArray();
            var perm = (new permutations()).Permute(new int[] { 1,1,2});
            var solutions = (new n_queens()).SolveNQueens(4);

            IList<IList<string>> list2 = new List<IList<string>>();
            for (int i = 0; i < 8; i++)
            {
                list2.Add(Enumerable.Repeat<string>(".", 8).ToList());
            }
            list2[0][0] = "change";
            

            Dictionary<string, IList<int>> res3 = new Dictionary<string, IList<int>>();
            var res4 = res3.Values.ToList();

            var res = combination_sum.Answer(new int[] { 2, 3, 4 }, 24);

            List<char[]> board = new List<char[]>();
            board.Add(new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' });
            board.Add(new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' });
            board.Add(new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' });
            board.Add(new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' });
            board.Add(new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' });
            board.Add(new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' });
            board.Add(new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' });
            board.Add(new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' });
            board.Add(new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' });

            var valid = valid_sudoku.Answer(board.ToArray());


            var answer = find_first_and_last_position_of_element_in_sorted_array.Answer(new int[] { 1,2,3,4,5,6,7,8}, 9);

            var ans3 = Problem3.Answer(new int[,] { { 1, 3, 1, 2, 9, 4 }, { 1, 5, 1, 2, 6, 1 }, { 4, 2, 1, 2, 8, 3 }, { 6, 1, 4, 3, 1, 1 } });
            var ans32 = Problem3.ImporvedAnswer(new int[,] { { 1, 3, 1, 2, 9, 4 }, { 1, 5, 1, 2, 6, 1 }, { 4, 2, 1, 2, 8, 3 }, { 6, 1, 4, 3, 1, 1 } });
            var ans = Problem2.Answer(4,6);
            var ans2 = Problem2.ImporvedAnswer(4, 6);


            var answer1 = Problem1.Answer1(10);
            var answer11 = Problem1.ImprovedAnswer1(10);
            var answer2 = Problem1.Answer2(10);
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

    public class CarPlateNumber
    {
        int len = 5;
        char[] alpha = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S' };
        char[] digit = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] alphaDigit = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] data;
        bool[] vis;
        private IList<string> result;
        public IList<string> Generate()
        {
            result = new List<string>();
            data = new char[5];
            vis = new bool[5];
            _dfs(0);
            return result;
        }

        private void _dfs(int step)
        {
            if (step >= len)
            {
                result.Add(new string(data));
                return;
            }
            int n = (step == 1 ? alpha.Length : digit.Length);
            char[] target = (step == 1 ? alpha : digit);
            for (int i = 0; i < n; i++)
            {
                if (!vis[step])
                {
                    vis[step] = true;
                    data[step] = target[i];
                    _dfs(step + 1);
                    vis[step] = false;
                }
            }
        }
    }
}

