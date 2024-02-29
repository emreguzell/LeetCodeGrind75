using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._021_MergeTwoSortedLists
{
    public class Solution021
    {
        
        //Definition for singly-linked list.
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
        
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = null;
            if (list1 == null && list2 == null) return null;
            if (list1 == null || list2 == null)
            {
                head = (list1 == null) ? list2 : list1;
                return head;
            }

            // Assigning into head
            if (list1.val < list2.val)
            {
                head = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                head = new ListNode(list2.val);
                list2 = list2.next;
            }

            ListNode sortedList = head;
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    head.next = list2;
                    return sortedList;
                }
                if (list2 == null)
                {
                    head.next = list1;
                    return sortedList;
                }
                if (list1.val < list2.val)
                {
                    head.next = new ListNode(list1.val);
                    head = head.next;
                    list1 = list1.next;
                }
                else
                {
                    head.next = new ListNode(list2.val);
                    head = head.next;
                    list2 = list2.next;
                }
            }
            return sortedList;
        }
    }
}