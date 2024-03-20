using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._704_BinarySearch
{
    public class Solution704
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }
                // If target is greater, ignore left half
                else if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                // If target is smaller, ignore right half
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
