using Algorithym.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    public class AVLTreeNode : TreeNode
    {
        public override void InsertTreeNode(TreeNode newNode)
        {
            base.InsertTreeNode(newNode);
            Balance();
        }

        private void Balance()
        {

        }
    }

    public class AVLTree
    {
        public AVLTree()
        {

        }

        public void Insert()
        {

        }

        public void Delete()
        {

        }

        public void Find()
        {

        }
    }
}
