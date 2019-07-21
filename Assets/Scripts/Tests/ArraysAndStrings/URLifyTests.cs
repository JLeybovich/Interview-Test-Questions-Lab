using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class URLifyTests
    {
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase("Test", "Test")]
        [TestCase("This is a test.", "This%20is%20a%20test.")]
        [TestCase("  This is a test. ", "This%20is%20a%20test.")]
        [TestCase(" This is a test.  ", "This%20is%20a%20test.")]
        [TestCase(" This is a test. ", "This%20is%20a%20test.")]
        [TestCase("  This is a test.  ", "This%20is%20a%20test.")]
        [TestCase("This is a test. ", "This%20is%20a%20test.")]
        [TestCase("This is a test.  ", "This%20is%20a%20test.")]
        [TestCase(" This is a test.", "This%20is%20a%20test.")]
        [TestCase("  This is a test.", "This%20is%20a%20test.")]
        [TestCase("  SpacesInFront", "SpacesInFront")]
        [TestCase(" SpaceInFront", "SpaceInFront")]
        [TestCase("SpaceInBack ", "SpaceInBack")]
        [TestCase("SpacesInBack  ", "SpacesInBack")]
        [TestCase(" Spaces ", "Spaces")]
        [TestCase("  Spaces  ", "Spaces")]
        [TestCase("\tTabs\t\t\t", "Tabs")]
        [TestCase("\t\t\tTabs\t", "Tabs")]
        [TestCase("\n\t\nMix\t\n", "Mix")]
        [TestCase("\n\t\tMix\t\n", "Mix")]
        public void URLify_AnyString_ExpectedResult(string str, string expected)
        {
            var actual = StringExtensions.URLify(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
