using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class MinimalBSTTests
    {
        private int[] OneNode = { 0 };

        [Test]
        public void MinimalBST_Null_Null()
        {
            var actual = ArrayExtensions.CreateMinimalBST(null);
            Assert.AreEqual(null, actual);
        }

        [TestCase(-1, 0)]
        [TestCase(0, -1)]
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        public void MinimalBST_InvalidIndices_Null(int start, int end)
        {
            var actual = ArrayExtensions.CreateMinimalBST(OneNode, start, end);
            Assert.AreEqual(null, actual);
        }

        [TestCase(new int[] {0, 1, 2}, 1, new int [] {0}, new int[] {2})]
        [TestCase(new int[] {5, 10, 20, 50}, 10, new int [] {5}, new int[] {20, 50})]
        [TestCase(new int[] {6, 7, 8, 9, 10}, 8, new int [] {6, 7}, new int[] {9, 10})]
        public void MinimalBST_ValidInput_ExpectedResult(int[] input, int expectedFirst,
            int[] expectedLeft, int[] expectedRight)
        {
            var actual = ArrayExtensions.CreateMinimalBST(input);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedFirst, actual.Value);

            var curr = actual;
            curr = curr.Left;
            var index = 0;
            while (curr != null)
            {
                Assert.AreEqual(expectedLeft[index], curr.Value);
                curr = curr.Left;
                index++;
            }

            curr = actual;
            curr = curr.Right;
            index = 0;
            while (curr != null)
            {
                Assert.AreEqual(expectedRight[index], curr.Value);
                curr = curr.Right;
                index++;
            }
        }
    }
}
