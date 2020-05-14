using NUnit.Framework;

namespace InterviewQuestions.MathAndLogic.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void NullInputTest()
        {
            var expected = 0;
            var actual = MathExtensions.Calculate(null);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShortInputTest()
        {
            var expected = 3;
            var actual = MathExtensions.Calculate("1+2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractionoTest()
        {
            var expected = -1;
            var actual = MathExtensions.Calculate("1+2-4");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplicationTest()
        {
            var expected = 30;
            var actual = MathExtensions.Calculate("2*3*5");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivisionTest()
        {
            var expected = 2;
            var actual = MathExtensions.Calculate("30/5/3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AllOperationsTest()
        {
            var expected = -1;
            var actual = MathExtensions.Calculate("1+2-4*5/5");
            Assert.AreEqual(expected, actual);
        }
    }
}