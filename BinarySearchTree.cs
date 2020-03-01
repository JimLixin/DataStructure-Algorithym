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

        public BinarySearchTree(TreeType treeType)
        {
            TreeType = treeType;
        }

        public TreeNode Root { get; private set; }

        public TreeType TreeType { get; private set; }

        public TreeNode BuildTree(int[] inputArray)
        {
            if (inputArray == null || !inputArray.Any())
            {
                Console.WriteLine("Input array is empty, return without nothing...");
                return null;
            }
            Root = (TreeType == TreeType.RedBlack ? new RedBlackTreeNode(TreeNodeColor.Black, inputArray[0]) : new TreeNode(inputArray[0]));
            for (int i = 1; i < inputArray.Length; i++)
            {
                var insertedNode = Root.InsertTreeNode(TreeType == TreeType.RedBlack ? new RedBlackTreeNode(TreeNodeColor.Red, inputArray[i]) : new TreeNode(inputArray[i]));
                switch (TreeType)
                {
                    case TreeType.AVL:
                        BalanceAVL(insertedNode);
                        break;
                    case TreeType.RedBlack:
                        BalanceRedBlack(insertedNode as RedBlackTreeNode);
                        break;
                    case TreeType.Splay:
                        BalanceSplay(insertedNode);
                        break;
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
            if (TreeType == TreeType.AVL)
            {
                BalanceAVL(returnNode);
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
            if (target.LeftChild == null && target.RightChild == null)
            {
                //Delete a leaf node directly
                target.Parent.DeleteChild(target);
                return;
            }
            var biggestChildInLeftSubTree = GetLargestChild(target.LeftChild);
            int valueToCopy = biggestChildInLeftSubTree.Value;
            if (biggestChildInLeftSubTree.Value > biggestChildInLeftSubTree.Parent.Value)
            {
                //biggest child is a right child
                //It must be a right leaf node OR only have a left child
                biggestChildInLeftSubTree.Parent.RightChild = biggestChildInLeftSubTree.LeftChild;
            }
            else
            {
                //biggest child is a left child
                //It must be a left leaf node OR only have a left child
                biggestChildInLeftSubTree.Parent.LeftChild = biggestChildInLeftSubTree.LeftChild;
            }
            target.Value = valueToCopy;
            biggestChildInLeftSubTree = null;
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
            if (TreeType != TreeType.Splay)
                return target;
            else
            {
                var returnedNode = target.Clone();
                BalanceSplay(target);
                return returnedNode;
            }
        }

        private TreeNode GetLargestChild(TreeNode node)
        {
            if (node == null)
                return null;

            return node.RightChild == null ? node : GetLargestChild(node.RightChild);
        }

        private void BalanceAVL(TreeNode node)
        {
            TreeNode parent = node.Parent;
            while (parent != null)
            {
                int leftHeight = parent.LeftChild == null ? 0 : parent.LeftChild.GetHeight();
                int rightHeight = parent.RightChild == null ? 0 : parent.RightChild.GetHeight();
                if (leftHeight - rightHeight > 1)
                {
                    RotationRight(parent);
                }
                else if (leftHeight - rightHeight < -1)
                {
                    RotationLeft(parent);
                }
                parent = parent.Parent;
            }
        }

        private void BalanceRedBlack(RedBlackTreeNode node)
        {
            var parentNode = node.Parent as RedBlackTreeNode;
            if (parentNode == null)
            {
                //We are inserting root node
                node.Color = TreeNodeColor.Black;
            }
            else if (parentNode.Color != TreeNodeColor.Black)
            {
                //Note: parent's color is Red means there must be a grand parent there. 
                //Otherwise the parent will be the root node, 
                //it will break the rule: 'Root node is always Black'.
                //Parent is also Red, we need to look at Uncle's color
                var uncleNode = (RedBlackTreeNode)GetUncleTreeNode(node);
                var grandParent = parentNode.Parent as RedBlackTreeNode;
                if (uncleNode != null && uncleNode.Color != TreeNodeColor.Black)
                {
                    //New Node, parent and Uncle are both Red, push grand parent's color down
                    grandParent.Color = TreeNodeColor.Red;
                    uncleNode.Color = TreeNodeColor.Black;
                    parentNode.Color = TreeNodeColor.Black;
                    //When grand parent change its color, it may break the rule
                    //Still need to balance the tree from grand parent to top
                    BalanceRedBlack(grandParent);
                }
                else
                {
                    //New node and parent are both Red, make rotation based on below rules:
                    //If New node is a LEFT child and Parent node is a LEFT child
                    //If New node is a LEFT child and Parent node is a RIGHT child
                    //If New node is a RIGHT child and Parent node is a LEFT child
                    //If New node is a RIGHT child and Parent node is a RIGHT child
                    //Swap colors between parent and new node after rotation
                    if (node.Value < parentNode.Value)
                    {
                        if (parentNode.Value < grandParent.Value)
                        {
                            //LEFT + LEFT -> Right rotation
                            RotationRight(grandParent);
                        }
                        else
                        {
                            //LEFT + RIGHT -> Right rotation + Left rotation
                            RotationRight(parentNode);
                            RotationLeft(grandParent);
                        }
                    }
                    else
                    {
                        if (parentNode.Value > grandParent.Value)
                        {
                            //RIGHT + RIGHT -> Left rotation
                            RotationLeft(grandParent);
                        }
                        else
                        {
                            //RIGHT + LEFT -> Left rotation + Right rotation
                            RotationLeft(parentNode);
                            RotationRight(grandParent);
                        }
                    }
                    grandParent.Color = TreeNodeColor.Red;
                    (grandParent.Parent as RedBlackTreeNode).Color = TreeNodeColor.Black;
                }
            }
        }

        private void BalanceSplay(TreeNode node)
        {
            if (node.Parent == null)
                return;

            while (Root != node)
            {
                var parent = node.Parent;
                if (parent.Parent == null)
                {
                    if (node.Value > parent.Value)
                        RotationLeft(parent);
                    else
                        RotationRight(parent);
                }
                else
                {
                    var grandParent = parent.Parent;
                    if (parent.Value < grandParent.Value)
                    {
                        if (node.Value < parent.Value)
                        {
                            //Zig zig right
                            ZigZag(grandParent, Direction.Right, ZigZagType.ZigZig);
                        }
                        else
                        {
                            //Zig zag right
                            ZigZag(grandParent, Direction.Right, ZigZagType.ZigZag);
                        }
                    }
                    else
                    {
                        if (node.Value > parent.Value)
                        {
                            //zig zig left
                            ZigZag(grandParent, Direction.Left, ZigZagType.ZigZig);
                        }
                        else
                        {
                            //zig zag left
                            ZigZag(grandParent, Direction.Left, ZigZagType.ZigZag);
                        }
                    }
                }
            }
        }

        private void RotationLeft(TreeNode currentNode)
        {
            var newParent = currentNode.RightChild;
            if (currentNode.Parent != null)
            {
                if (currentNode.Value > currentNode.Parent.Value)
                {
                    //current node is a right child
                    currentNode.Parent.RightChild = newParent;
                    newParent.Parent = currentNode.Parent;
                }
                else
                {
                    currentNode.Parent.LeftChild = newParent;
                    newParent.Parent = currentNode.Parent;
                }
            }
            else
            {
                //we are currently processing root node
                Root = newParent;
                newParent.Parent = null;
            }
            var originalLeftTree = newParent.LeftChild;
            newParent.LeftChild = currentNode;
            currentNode.Parent = newParent;
            currentNode.RightChild = originalLeftTree;
            if (originalLeftTree != null)
            {
                originalLeftTree.Parent = currentNode;
            }
        }

        private void RotationRight(TreeNode currentNode)
        {
            var newParent = currentNode.LeftChild;
            if (currentNode.Parent != null)
            {
                if (currentNode.Value < currentNode.Parent.Value)
                {
                    //current node is left child
                    currentNode.Parent.LeftChild = newParent;
                    newParent.Parent = currentNode.Parent;
                }
                else
                {
                    currentNode.Parent.RightChild = newParent;
                    newParent.Parent = currentNode.Parent;
                }
            }
            else
            {
                //we are currently processing root node
                Root = newParent;
                newParent.Parent = null;
            }
            var originalRightTree = newParent.RightChild;
            newParent.RightChild = currentNode;
            currentNode.Parent = newParent;
            currentNode.LeftChild = originalRightTree;
            if (originalRightTree != null)
            {
                originalRightTree.Parent = currentNode;
            }
        }

        private void ZigZag(TreeNode rotationNode, Direction direction, ZigZagType zigZagType)
        {
            var isZigZag = (zigZagType == ZigZagType.ZigZag);
            var newParent = rotationNode
                .GetChild((Direction)((1 ^ (int)direction)))
                .GetChild((Direction)(zigZagType == ZigZagType.ZigZag ? (int)direction : (1 ^ (int)direction)));
            if (rotationNode.Parent != null)
            {
                if (rotationNode.Value > rotationNode.Parent.Value)
                {
                    //rotation node is a right child
                    rotationNode.Parent.RightChild = newParent;
                }
                else
                {
                    rotationNode.Parent.LeftChild = newParent;
                    
                }
                newParent.Parent = rotationNode.Parent;
            }
            else
            {
                //we are currently processing root node
                Root = newParent;
                newParent.Parent = null;
            }
            var originalLeftTree = newParent.LeftChild;
            var originalRightTree = newParent.RightChild;
            if (direction == Direction.Left)
            {
                newParent.LeftChild = (isZigZag ? rotationNode : rotationNode.RightChild);
                newParent.RightChild = isZigZag ? rotationNode.RightChild : newParent.RightChild;
                rotationNode.Parent = (isZigZag ? newParent : newParent.LeftChild);
                rotationNode.RightChild.Parent = newParent;
                if (isZigZag)
                {
                    //rotationNode.RightChild.LeftChild = originalRightTree;
                    //rotationNode.RightChild = originalLeftTree;
                    newParent.RightChild.LeftChild = originalRightTree;
                    newParent.LeftChild.RightChild = originalLeftTree;
                    if (originalRightTree != null)
                    {
                        originalRightTree.Parent = newParent.RightChild;
                    }
                    if (originalLeftTree != null)
                    {
                        originalLeftTree.Parent = newParent.LeftChild;
                    }
                }
                else
                {
                    rotationNode.RightChild.RightChild = originalLeftTree;
                    if (originalLeftTree != null)
                    {
                        originalLeftTree.Parent = rotationNode.RightChild;
                    }
                    //rotationNode.RightChild.LeftChild = rotationNode;
                    rotationNode.RightChild = newParent.LeftChild.LeftChild;
                    if (newParent.LeftChild.LeftChild != null)
                    {
                        newParent.LeftChild.LeftChild.Parent = rotationNode;
                    }
                    newParent.LeftChild.LeftChild = rotationNode;
                }
            }
            else
            {
                newParent.RightChild = (isZigZag ? rotationNode : rotationNode.LeftChild);
                newParent.LeftChild = isZigZag ? rotationNode.LeftChild : newParent.LeftChild;
                rotationNode.Parent = (isZigZag ? newParent : newParent.RightChild);
                rotationNode.LeftChild.Parent = newParent;
                if (isZigZag)
                {
                    //rotationNode.LeftChild.RightChild = originalLeftTree;
                    //rotationNode.LeftChild = originalRightTree;
                    newParent.LeftChild.RightChild = originalLeftTree;
                    newParent.RightChild.LeftChild = originalRightTree;
                    if (originalLeftTree != null)
                    {
                        originalLeftTree.Parent = newParent.LeftChild;
                    }
                    if (originalRightTree != null)
                    {
                        originalRightTree.Parent = newParent.RightChild;
                    }
                }
                else
                {
                    rotationNode.LeftChild.LeftChild = originalRightTree;
                    if (originalRightTree != null)
                    {
                        originalRightTree.Parent = rotationNode.LeftChild;
                    }
                    //rotationNode.LeftChild.RightChild = rotationNode;
                    rotationNode.LeftChild = newParent.RightChild.RightChild;
                    if (newParent.RightChild.RightChild != null)
                    {
                        newParent.RightChild.RightChild.Parent = rotationNode;
                    }
                    newParent.RightChild.RightChild = rotationNode;
                }
            }
        }

        private TreeNode GetUncleTreeNode(TreeNode node)
        {
            if (node == null || 
                node.Parent == null || 
                node.Parent.Parent == null || 
                //Grand parent node only have one child, means there is no uncle node
                node.Parent.Parent.LeftChild == null || node.Parent.Parent.RightChild == null)
                return null;
            var parentNode = node.Parent;
            var grandParentNode = parentNode.Parent;
            return grandParentNode.LeftChild.Value == parentNode.Value ? grandParentNode.RightChild : grandParentNode.LeftChild;
        }
    }
}
