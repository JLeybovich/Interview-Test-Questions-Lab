using System;

namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static int GetMaxProfit(int[] stockPrices)
        {
            if (stockPrices == null || stockPrices.Length < 2)
            {
                throw new ArgumentException();
            }

            // We'll greedily update minPrice and maxProfit, so we initialize
            // them to the first price and the first possible profit
            int minPrice = stockPrices[0];
            int maxProfit = stockPrices[1] - stockPrices[0];

            // Start at the second (index 1) time.
            // We can't sell at the first time, since we must buy first,
            // and we can't buy and sell at the same time!
            // If we started at index 0, we'd try to buy *and* sell at time 0.
            // This would give a profit of 0, which is a problem if our
            // maxProfit is supposed to be *negative*--we'd return 0.
            for (int i = 1; i < stockPrices.Length; i++)
            {
                int currentPrice = stockPrices[i];

                // See what our profit would be if we bought at the
                // min price and sold at the current price
                int potentialProfit = currentPrice - minPrice;

                // Update maxProfit if we can do better
                maxProfit = Math.Max(maxProfit, potentialProfit);

                // Update minPrice so it's always
                // the lowest price we've seen so far
                minPrice = Math.Min(minPrice, currentPrice);
            }

            return maxProfit;
        }
    }
}