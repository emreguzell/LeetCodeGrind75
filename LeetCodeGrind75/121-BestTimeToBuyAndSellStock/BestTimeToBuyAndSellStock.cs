namespace LeetCodeGrind75._121_BestTimeToBuyAndSellStock
{
    public class Solution121
    {
        public int MaxProfit(int[] prices)
        {
            int boughtDay = 0;
            int soldDay = 1;
            int maxProfit = 0;
            while (soldDay < prices.Length)
            {
                //if profitable?
                if (prices[boughtDay] < prices[soldDay])
                {
                    int profit = prices[soldDay] - prices[boughtDay];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    boughtDay = soldDay;
                }
                soldDay++;
            }
            return maxProfit;
        }
    }
}
