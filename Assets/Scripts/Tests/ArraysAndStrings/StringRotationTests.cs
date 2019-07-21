using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class StringRotationTests
    {
        [TestCase(null, null, true)]
        [TestCase("", "", true)]
        [TestCase("Test", "Test", true)]
        [TestCase("a", "a", true)]
        [TestCase("ab", "ba", true)]
        [TestCase("ab", "ab", true)]
        [TestCase("abba", "baab", true)]
        [TestCase("aaa", "a3", false)]
        [TestCase("aa", "a33", false)]
        [TestCase("baaab", "baab", false)]
        public void Rotate_ValidString_ExpectedResult(string str1, string str2, bool expected)
        {
            var actual = StringExtensions.IsRotation(str1, str2);
            Assert.AreEqual(expected, actual);
        }
    }
}
