using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._226_InvertBinaryTree
{
    public class Solution226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            if (root.left == null && root.right == null) return root;

            InvertTree(root.left);
            InvertTree(root.right);

            TreeNode tempNode = root.left;
            root.left = root.right;
            root.right = tempNode;
            return root;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
