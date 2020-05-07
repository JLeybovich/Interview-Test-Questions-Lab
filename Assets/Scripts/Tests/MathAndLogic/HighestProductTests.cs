using NUnit.Framework;
using System;

namespace InterviewQuestions.MathAndLogic.Tests
{
    public class HighestProductTests
    {
        [Test]
        public void ShortArrayTest()
        {
            var actual = MathExtensions.HighestProductOf3(new int[] { 1, 2, 3, 4 });
            var expected = 24;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongerArrayTest()
        {
            var actual = MathExtensions.HighestProductOf3(new int[] { 6, 1, 3, 5, 7, 8, 2 });
            var expected = 336;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayHasOneNegativeTest()
        {
            var actual = MathExtensions.HighestProductOf3(new int[] { -5, 4, 8, 2, 3 });
            var expected = 96;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayHasTwoNegativesTest()
        {
            var actual = MathExtensions.HighestProductOf3(new int[] { -10, 1, 3, 2, -10 });
            var expected = 300;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayHasAllNegativesTest()
        {
            var actual = MathExtensions.HighestProductOf3(new int[] { -5, -1, -3, -2 });
            var expected = -6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptionWithEmptyArrayTest()
        {
            Assert.Throws<ArgumentException>(() => MathExtensions.HighestProductOf3(new int[] { }));
        }

        [Test]
        public void ExceptionWithOneNumberTest()
        {
            Assert.Throws<ArgumentException>(() => MathExtensions.HighestProductOf3(new int[] { 1 }));
        }

        [Test]
        public void ExceptionWithTwoNumbersTest()
        {
            Assert.Throws<ArgumentException>(() => MathExtensions.HighestProductOf3(new int[] { 1, 1 }));
        }
    }
}