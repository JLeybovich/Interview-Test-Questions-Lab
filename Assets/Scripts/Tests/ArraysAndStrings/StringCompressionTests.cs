using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class StringCompressionTests
    {
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase("Test", "Test")]
        [TestCase("a", "a")]
        [TestCase("ab", "ab")]
        [TestCase("aab", "aab")]
        [TestCase("aaa", "a3")]
        [TestCase("aaab", "a3b")]
        [TestCase("aaabb", "a3b2")]
        public void Compress_ValidString_ExpectedResult(string str, string expected)
        {
            var actual = StringExtensions.Compress(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
