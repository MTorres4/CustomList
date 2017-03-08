using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode root;

        public TreeNode()
        {
            root = null;
        }

        public void Add(int data)
        {
            TreeNode AddToNode = new TreeNode();
            AddToNode.Data = data;
            if(root == null)
            {
                root = AddToNode;
            }
            else
            {

            }
        }
    }
}
