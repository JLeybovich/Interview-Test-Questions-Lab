using NUnit.Framework;
using System;

namespace InterviewQuestions.MathAndLogic.Tests
{
    public class FibonacciTests
    {
        [Test]
        public void ZerothFibonacciTest()
        {
            var actual = MathExtensions.Fib(0);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FirstFibonacciTest()
        {
            var actual = MathExtensions.Fib(1);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SecondFibonacciTest()
        {
            var actual = MathExtensions.Fib(2);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThirdFibonacciTest()
        {
            var actual = MathExtensions.Fib(3);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FifthFibonacciTest()
        {
            var actual = MathExtensions.Fib(5);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TenthFibonacciTest()
        {
            var actual = MathExtensions.Fib(10);
            var expected = 55;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NegativeFibonacciTest()
        {
            Assert.Throws<ArgumentException>(() => MathExtensions.Fib(-1));
        }
    }
}