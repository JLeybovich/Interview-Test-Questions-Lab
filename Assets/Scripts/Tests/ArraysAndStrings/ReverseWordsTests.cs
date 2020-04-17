using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class ReverseWordsTests
    {
        [Test]
        public void OneWordTest()
        {
            var expected = "vault".ToCharArray();
            var actual = "vault".ToCharArray();
            StringExtensions.ReverseWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwoWordsTest()
        {
            var expected = "cake thief".ToCharArray();
            var actual = "thief cake".ToCharArray();
            StringExtensions.ReverseWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThreeWordsTest()
        {
            var expected = "get another one".ToCharArray();
            var actual = "one another get".ToCharArray();
            StringExtensions.ReverseWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultipleWordsSameLengthTest()
        {
            var expected = "the cat ate the rat".ToCharArray();
            var actual = "rat the ate cat the".ToCharArray();
            StringExtensions.ReverseWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultipleWordsDifferentLengthsTest()
        {
            var expected = "chocolate bundt cake is yummy".ToCharArray();
            var actual = "yummy is cake bundt chocolate".ToCharArray();
            StringExtensions.ReverseWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EmptyStringTest()
        {
            var expected = "".ToCharArray();
            var actual = "".ToCharArray();
            StringExtensions.ReverseWords(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}