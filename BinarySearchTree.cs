using Algorithym.Shared;
using System;
using System.Linq;

namespace Algorithym
{
    /// <summary>
    /// BST
    /// </summary>
    public class BinarySearchTree
    {
        public BinarySearchTree() { }

        public BinarySearchTree(bool isAVLTree)
        {
            IsAVLTree = isAVLTree;
        }

        public TreeNode Root { get; private set; }

        public bool IsAVLTree { get; private set; }

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
                var insertedNode = Root.InsertTreeNode(new TreeNode(inputArray[i]));
                if (IsAVLTree)
                {
                    Balance(insertedNode);
                }
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

        public virtual TreeNode Insert(int newValue)
        {
            TreeNode returnNode = null;
            if (Root == null)
            {
                returnNode = new TreeNode(newValue);
                Root = returnNode;
            }
            else
            {
                returnNode = Root.InsertTreeNode(new TreeNode(newValue));
            }
            if (IsAVLTree)
            {
                Balance(returnNode);
            }
            return returnNode;
        }

        public virtual void Delete(int nodeValue)
        {
            var target = Find(nodeValue);
            if (target == null)
            {
                return;
            }
            var leftChild = target.GetLargestLeftChild();
            leftChild.Parent.RightChild = null;
            target.Value = leftChild.Value;
        }

        public TreeNode Find(int nodeValue)
        {
            TreeNode target = null;
            var currentNode = Root;
            while (currentNode != null)
            {
                if (currentNode.Value == nodeValue)
                {
                    target = currentNode;
                    break;
                }
                currentNode = (nodeValue > currentNode.Value ? currentNode.RightChild : currentNode.LeftChild);
            }
            return target;
        }

        private void Balance(TreeNode node)
        {
            TreeNode parent = node.Parent;
            while (parent != null)
            {
                int leftHeight = parent.LeftChild == null ? 0 : parent.LeftChild.GetHeight();
                int rightHeight = parent.RightChild == null ? 0 : parent.RightChild.GetHeight();
                if (leftHeight - rightHeight > 1)
                {
                    var newParent = parent.LeftChild;
                    if (parent.Parent != null)
                    {
                        if (parent.Parent.LeftChild != null)
                        {
                            parent.Parent.LeftChild = newParent;
                            newParent.Parent = parent.Parent;
                        }

                    }
                    else
                    {
                        //we are currently processing root node
                        Root = newParent;
                        newParent.Parent = null;
                    }
                    var originalRightTree = newParent.RightChild;
                    newParent.RightChild = parent;
                    parent.Parent = newParent;
                    parent.LeftChild = originalRightTree;
                }
                else if (leftHeight - rightHeight < -1)
                {
                    var newParent = parent.RightChild;
                    if (parent.Parent != null)
                    {
                        if (parent.Parent.RightChild != null)
                        {
                            parent.Parent.RightChild = newParent;
                            newParent.Parent = parent.Parent;
                        }
                    }
                    else
                    {
                        //we are currently processing root node
                        Root = newParent;
                        newParent.Parent = null;
                    }
                    var originalLeftTree = newParent.LeftChild;
                    newParent.LeftChild = parent;
                    parent.Parent = newParent;
                    parent.RightChild = originalLeftTree;
                }
                parent = parent.Parent;
            }
        }

        
    }
}
