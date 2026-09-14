public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0, buy = prices[0], sell = prices[0];
        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i] < buy)
            {
                buy = prices[i]; sell = prices[i];
            }
            else if(prices[i] > sell)
            {
                sell = prices[i];
            }
            if(sell - buy > profit)
                profit = sell - buy;
        }
        return profit;
    }
}
