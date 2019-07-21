using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class PalindromeTests
    {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("Test", false)]
        [TestCase("a", true)]
        [TestCase("ab", false)]
        [TestCase("abb", true)]
        [TestCase("aabb", true)]
        [TestCase("abbc", false)]
        [TestCase("aabbccc", true)]
        [TestCase("aabbcc", true)]
        public void IsPalindromePermutation_AnyString_ExpectedResult(string str, bool expected)
        {
            var actual = StringExtensions.IsPalindromePermutation(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
