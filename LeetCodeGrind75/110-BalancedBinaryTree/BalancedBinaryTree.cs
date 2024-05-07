using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._110_BalancedBinaryTree
{
	public class Solution110
	{
		public bool IsBalanced(TreeNode root)
		{
			if (root == null) return true;

			int leftHeight = getHeight(root.left);
			int rightHeight = getHeight(root.right);

			return (Math.Abs(leftHeight - rightHeight) <= 1) && IsBalanced(root.left) && IsBalanced(root.right);
		}
		public int getHeight(TreeNode node)
		{
			if (node == null) return 0;

			return 1 + Math.Max(getHeight(node.left), getHeight(node.right));
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
