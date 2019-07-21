using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class IsUniqueTests
    {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("Test", true)]
        [TestCase("a", true)]
        [TestCase("ab", true)]
        [TestCase("aab", false)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", true)]
        [TestCase("aAb", true)]
        public void IsUnique_ValidString_ExpectedResult(string str, bool expected)
        {
            var actual = StringExtensions.IsUnique(str);
            Assert.That(actual == expected);
        }
    }
}
