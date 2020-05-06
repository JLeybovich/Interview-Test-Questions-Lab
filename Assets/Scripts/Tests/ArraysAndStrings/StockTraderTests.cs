using NUnit.Framework;
using System;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class StockTraderTests
    {
        [Test]
        public void PriceGoesUpThenDownTest()
        {
            var actual = ArrayExtensions.GetMaxProfit(new int[] { 1, 5, 3, 2 });
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PriceGoesDownThenUpTest()
        {
            var actual = ArrayExtensions.GetMaxProfit(new int[] { 7, 2, 8, 9 });
            var expected = 7;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PriceGoesUpAllDayTest()
        {
            var actual = ArrayExtensions.GetMaxProfit(new int[] { 1, 6, 7, 9 });
            var expected = 8;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PriceGoesDownAllDayTest()
        {
            var actual = ArrayExtensions.GetMaxProfit(new int[] { 9, 7, 4, 1 });
            var expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PriceStaysTheSameAllDayTest()
        {
            var actual = ArrayExtensions.GetMaxProfit(new int[] { 1, 1, 1, 1 });
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptionWithOnePriceTest()
        {
            Assert.Throws<ArgumentException>(() => ArrayExtensions.GetMaxProfit(new int[] { 5 }));
        }

        [Test]
        public void ExceptionWithEmptyPricesTest()
        {
            Assert.Throws<ArgumentException>(() => ArrayExtensions.GetMaxProfit(new int[] { }));
        }
    }
}