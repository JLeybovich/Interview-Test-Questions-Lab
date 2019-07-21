using NUnit.Framework;

namespace InterviewQuestions.MathAndLogic.Tests
{
    public class DivideWithoutDivisionTests
    {
        [TestCase(0, 0, 0)]
        public void DivideWithoutDivision_InvalidInput_ExpectedResult(int n, int d, int expected)
        {
            var actual = MathExtensions.DivideWithoutDivision(n, d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(1, -1)]
        [TestCase(2, 1)]
        [TestCase(50, 10)]
        [TestCase(-50, 10)]
        [TestCase(-73, 8)]
        public void DivideWithoutDivision_ValidInput_ExpectedResult(int n, int d)
        {
            var actual = MathExtensions.DivideWithoutDivision(n, d);
            Assert.AreEqual(n / d, actual);
        }
    }
}
