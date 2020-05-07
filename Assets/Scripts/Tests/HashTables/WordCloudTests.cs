using NUnit.Framework;
using System.Collections.Generic;

namespace InterviewQuestions.HashTables.Tests
{
    public class WordCloudTests
    {
        [Test]
        public void SimpleSentenceTest()
        {
            var text = "I like cake";
            var expected = new Dictionary<string, int>() { { "I", 1 }, { "like", 1 }, { "cake", 1 } };
            var actual = new HashTableExtensions.WordCloudData(text);
            Assert.AreEqual(expected, actual.WordsToCounts);
        }

        [Test]
        public void LongerSentenceTest()
        {
            var text = "Chocolate cake for dinner and pound cake for dessert";
            var expected = new Dictionary<string, int>() { { "and", 1 }, { "pound", 1 }, { "for", 2 },
            { "dessert", 1 }, { "Chocolate", 1 }, { "dinner", 1 }, { "cake", 2 } };
            var actual = new HashTableExtensions.WordCloudData(text);
            Assert.AreEqual(expected, actual.WordsToCounts);
        }

        [Test]
        public void PunctuationTest()
        {
            var text = "Strawberry short cake? Yum!";
            var expected = new Dictionary<string, int>() { { "cake", 1 }, { "Strawberry", 1 },
            { "short", 1 }, { "Yum", 1 } };
            var actual = new HashTableExtensions.WordCloudData(text);
            Assert.AreEqual(expected, actual.WordsToCounts);
        }

        [Test]
        public void HyphenatedWordsTest()
        {
            var text = "Dessert - mille-feuille cake";
            var expected = new Dictionary<string, int>() { { "cake", 1 }, { "Dessert", 1 },
            { "mille-feuille", 1 } };
            var actual = new HashTableExtensions.WordCloudData(text);
            Assert.AreEqual(expected, actual.WordsToCounts);
        }

        [Test]
        public void EllipsesBetweenWordsTest()
        {
            var text = "Mmm...mmm...decisions...decisions";
            var expected = new Dictionary<string, int>() { { "mmm", 2 }, { "decisions", 2 } };
            var actual = new HashTableExtensions.WordCloudData(text);
            Assert.AreEqual(expected, actual.WordsToCounts);
        }

        [Test]
        public void ApostrophesTest()
        {
            var text = "Allie's Bakery: Sasha's Cakes";
            var expected = new Dictionary<string, int>() { { "Bakery", 1 }, { "Cakes", 1 },
            { "Allie's", 1 }, { "Sasha's", 1 } };
            var actual = new HashTableExtensions.WordCloudData(text);
            Assert.AreEqual(expected, actual.WordsToCounts);
        }
    }
}