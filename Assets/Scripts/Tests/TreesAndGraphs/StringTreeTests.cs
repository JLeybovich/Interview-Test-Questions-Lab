using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class StringTreeTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void TreeFromString_InvalidString_Null(string input)
        {
            var actual = StringExtensions.TreeFromString(input);
            Assert.AreEqual(null, actual);
        }

        [TestCase("a")]
        [TestCase("ab")]
        [TestCase("abc")]
        [TestCase("abcdefgh")]
        public void TreeFromString_ValidInput_ExpectedResult(string input)
        {
            var actual = StringExtensions.TreeFromString(input);

            var current = actual;
            bool toggle = false;
            for(int i = 0; i < input.Length; ++i)
            {
                int leftIndex = (2 * (i + 1)) - 1;

                if (leftIndex >= input.Length)
                {
                    //Assert.AreEqual(null, current.Left);
                    continue;
                }

                Assert.AreEqual(input[leftIndex], current.Left.Value);

                int rightIndex = leftIndex + 1;

                if (rightIndex >= input.Length)
                {
                   // Assert.AreEqual(null, actual.Right);
                    continue;
                }

                Assert.AreEqual(input[rightIndex], current.Right.Value);

                if(toggle)
                {
                    current = actual.Right;
                    actual = actual.Left;
                }
                else
                {
                    current = actual.Left;
                }

                toggle = !toggle;
            }
        }
    }
}
