using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class PermutationTests
    {
        [TestCase(null, null, true)]
        [TestCase("", null, true)]
        [TestCase(null, "", true)]
        [TestCase("a", "a", true)]
        [TestCase("a", "ab", false)]
        [TestCase("ab", "a", false)]
        [TestCase("abba", "baab", true)]
        [TestCase("abba", "baaa", false)]
        public void ArePermutations_AnyStrings_ExpectedResult(string str1, string str2, bool expected)
        {
            var actual = StringExtensions.ArePermutations(str1, str2);
            Assert.That(actual == expected);
        }
    }
}
