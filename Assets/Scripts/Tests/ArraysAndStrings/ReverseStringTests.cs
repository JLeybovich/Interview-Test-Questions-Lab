using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class ReverseStringTests
    {
        [Test]
        public void EmptyStringTest()
        {
            var expected = "".ToCharArray();
            var actual = "".ToCharArray();
            StringExtensions.Reverse(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleCharacterStringTest()
        {
            var expected = "A".ToCharArray();
            var actual = "A".ToCharArray();
            StringExtensions.Reverse(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongerStringTest()
        {
            var expected = "EDCBA".ToCharArray();
            var actual = "ABCDE".ToCharArray();
            StringExtensions.Reverse(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}