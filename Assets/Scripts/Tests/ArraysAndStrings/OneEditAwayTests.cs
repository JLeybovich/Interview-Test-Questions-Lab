using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class OneEditAwayTests
    {
        [TestCase(null, null, true)]
        [TestCase("", null, true)]
        [TestCase(null, "", true)]
        [TestCase("", "", true)]
        [TestCase("a", "", true)]
        [TestCase(null, "a", true)]
        [TestCase("", "ab", false)]
        [TestCase("ab", null, false)]
        [TestCase("a", "b", true)]
        [TestCase("ab", "bb", true)]
        [TestCase("ab", "cd", false)]
        [TestCase("abc", "ab", true)]
        [TestCase("abc", "ac", true)]
        [TestCase("abc", "bc", true)]
        [TestCase("bc", "abc", true)]
        [TestCase("ac", "abc", true)]
        [TestCase("ab", "abc", true)]
        public void IsOneEditAway_AnyStrings_ExpectedResult(string str1, string str2, bool expected)
        {
            var actual = StringExtensions.IsOneEditAway(str1, str2);
            Assert.AreEqual(expected, actual);
        }
    }
}
