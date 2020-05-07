using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class FindRotationPointTests
    {
        [Test]
        public void SmallArrayTest()
        {
            var actual = ArrayExtensions.FindRotationPoint(new string[] { "cape", "cake" });
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MediumArrayTest()
        {
            var actual = ArrayExtensions.FindRotationPoint(new string[] { "grape", "orange", "plum", "radish",
            "apple" });
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LargeArrayTest()
        {
            var actual = ArrayExtensions.FindRotationPoint(
                new string[] { "ptolemaic", "retrograde", "supplant", "undulate", "xenoepist",
            "asymptote", "babka", "banoffee", "engender", "karpatka", "othellolagkage" });
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NotRotatedArrayTest()
        {
            var actual = ArrayExtensions.FindRotationPoint(new string[] { "apple", "grape", "orange", "plum",
            "radish" });
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}