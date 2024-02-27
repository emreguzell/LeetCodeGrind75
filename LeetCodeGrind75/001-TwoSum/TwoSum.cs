namespace LeetCodeGrind75._001_TwoSum
{
    public class Solution_001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return new int[] { };
        }

        //public static void TestTwoSum()
        //{
        //    var solution = new Solution_001();
        //    int[] nums = { 2, 7, 11, 15 };
        //    int target = 9;
        //    int[] result = solution.TwoSum(nums, target);

        //    Console.WriteLine($"Testing TwoSum with nums: [{string.Join(", ", nums)}] and target: {target}");
        //    if (result.Length > 0)
        //    {
        //        Console.WriteLine($"Result: Indices {result[0]} and {result[1]} add up to {target}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No solution found.");
        //    }
        //}
    }
}
