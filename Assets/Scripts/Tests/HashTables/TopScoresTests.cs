using NUnit.Framework;

namespace InterviewQuestions.HashTables.Tests
{
    public class TopScoresTests
    {
        [Test]
        public void NoScoresTest()
        {
            var scores = new int[] { };
            var expected = new int[] { };
            var actual = HashTableExtensions.SortScores(scores, 100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneScoreTest()
        {
            var scores = new int[] { 55 };
            var expected = new int[] { 55 };
            var actual = HashTableExtensions.SortScores(scores, 100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwoScoresTest()
        {
            var scores = new int[] { 30, 60 };
            var expected = new int[] { 60, 30 };
            var actual = HashTableExtensions.SortScores(scores, 100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ManyScoresTest()
        {
            var scores = new int[] { 37, 89, 41, 65, 91, 53 };
            var expected = new int[] { 91, 89, 65, 53, 41, 37 };
            var actual = HashTableExtensions.SortScores(scores, 100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RepeatedScoresTest()
        {
            var scores = new int[] { 20, 10, 30, 30, 10, 20 };
            var expected = new int[] { 30, 30, 20, 20, 10, 10 };
            var actual = HashTableExtensions.SortScores(scores, 100);
            Assert.AreEqual(expected, actual);
        }
    }
}