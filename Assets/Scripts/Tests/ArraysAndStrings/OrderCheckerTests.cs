using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class OrderCheckerTests
    {
        [Test]
        public void BothRegistersHaveSameNumberOfOrdersTest()
        {
            var takeOutOrders = new int[] { 1, 4, 5 };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.True(result);
        }

        [Test]
        public void RegistersHaveDifferentLengthsTest()
        {
            var takeOutOrders = new int[] { 1, 5 };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 1, 2, 6, 3, 5 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.False(result);
        }

        [Test]
        public void OneRegisterIsEmptyTest()
        {
            var takeOutOrders = new int[] { };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 2, 3, 6 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.True(result);
        }

        [Test]
        public void ServedOrdersIsMissingOrdersTest()
        {
            var takeOutOrders = new int[] { 1, 5 };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 1, 6, 3, 5 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.False(result);
        }

        [Test]
        public void ServedOrdersHasExtraOrders()
        {
            var takeOutOrders = new int[] { 1, 5 };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 1, 2, 3, 5, 6, 8 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.False(result);
        }

        [Test]
        public void OneRegisterHasExtraOrders()
        {
            var takeOutOrders = new int[] { 1, 9 };
            var dineInOrders = new int[] { 7, 8 };
            var servedOrders = new int[] { 1, 7, 8 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.False(result);
        }

        [Test]
        public void OneRegisterHasUnservedOrders()
        {
            var takeOutOrders = new int[] { 55, 9 };
            var dineInOrders = new int[] { 7, 8 };
            var servedOrders = new int[] { 1, 7, 8, 9 };
            var result = ArrayExtensions.IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Assert.False(result);
        }
    }
}