using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeGrind75._021_MergeTwoSortedLists.Solution021;

namespace LeetCodeGrind75._141_LinkedListCycle
{
	public class Solution141
	{

		public bool HasCycle(ListNode head)
		{
			HashSet<ListNode> seenNodes = new HashSet<ListNode>();
			while (head != null)
			{
				if (seenNodes.Contains(head))
				{
					return true;
				}
				seenNodes.Add(head);
				head = head.next;
			}
			return false;
		}
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x)
			{
				val = x;
				next = null;
			}
		}
	}
}
