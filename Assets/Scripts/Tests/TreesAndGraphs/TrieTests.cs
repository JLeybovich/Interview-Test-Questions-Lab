using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class TrieTests
    {
        [Test]
        public void TrieTest()
        {
            var trie = new Trie();

            var result = trie.AddWord("catch");
            Assert.True(result);

            result = trie.AddWord("cakes");
            Assert.True(result);

            result = trie.AddWord("cake");
            Assert.True(result);

            result = trie.AddWord("cake");
            Assert.False(result);

            result = trie.AddWord("caked");
            Assert.True(result);

            result = trie.AddWord("catch");
            Assert.False(result);

            result = trie.AddWord("");
            Assert.True(result);

            result = trie.AddWord("");
            Assert.False(result);
        }
    }
}