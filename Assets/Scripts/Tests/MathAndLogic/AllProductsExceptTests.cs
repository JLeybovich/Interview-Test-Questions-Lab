using NUnit.Framework;
using System;

namespace InterviewQuestions.MathAndLogic.Tests
{
    public class AllProductsExceptTests
    {
        [Test]
        public void SmallArrayInputTest()
        {
            var expected = new int[] { 6, 3, 2 };
            var actual = MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { 1, 2, 3 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongArrayInputTest()
        {
            var expected = new int[] { 120, 480, 240, 320, 960, 192 };
            var actual = MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { 8, 2, 4, 3, 1, 5 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputHasOneZeroTest()
        {
            var expected = new int[] { 0, 0, 36, 0 };
            var actual = MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { 6, 2, 0, 3 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputHasTwoZerosTest()
        {
            var expected = new int[] { 0, 0, 0, 0, 0 };
            var actual = MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { 4, 0, 9, 1, 0 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputHasOneNegativeNumberTest()
        {
            var expected = new int[] { 32, -12, -24 };
            var actual = MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { -3, 8, 4 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AllNegativesInputTest()
        {
            var expected = new int[] { -8, -56, -14, -28 };
            var actual = MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { -7, -1, -4, -2 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptionWithEmptyInputTest()
        {
            Assert.Throws<ArgumentException>(() => MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { }));
        }

        [Test]
        public void ExceptionWithOneNumberInputTest()
        {
            Assert.Throws<ArgumentException>(() => MathExtensions.GetProductsOfAllIntsExceptAtIndex(new int[] { 1 }));
        }
    }
}