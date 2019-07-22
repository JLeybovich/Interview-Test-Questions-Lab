using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class RouteBetweenNodesTests
    {
        private Graph<char> CreateGraph()
        {
            var a = new GraphNode<char>('a');
            var b = new GraphNode<char>('b');
            var c = new GraphNode<char>('c');
            var d = new GraphNode<char>('d');
            var e = new GraphNode<char>('e');
            var f = new GraphNode<char>('f');
            var g = new GraphNode<char>('g');

            a.Adjacent.Add(b);

            b.Adjacent.Add(c);
            b.Adjacent.Add(d);
            b.Adjacent.Add(e);

            c.Adjacent.Add(e);

            d.Adjacent.Add(e);

            e.Adjacent.Add(f);

            g.Adjacent.Add(d);

            var graph = new Graph<char>(a, b, c, d, e, f, g);
            return graph;
        }

        [Test]
        public void RouteBetweenNodes_NullGraph_False()
        {
            var actual = GraphExtensions.HasRouteBetweenNodes(null, 'a', 'a');
            Assert.AreEqual(false, actual);
        }

        [TestCase('a', 'a', true)]
        [TestCase('a', 'b', true)]
        [TestCase('a', 'c', true)]
        [TestCase('a', 'd', true)]
        [TestCase('a', 'e', true)]
        [TestCase('a', 'f', true)]
        [TestCase('a', 'g', false)]
        [TestCase('b', 'a', false)]
        [TestCase('b', 'b', true)]
        [TestCase('b', 'c', true)]
        [TestCase('b', 'd', true)]
        [TestCase('b', 'e', true)]
        [TestCase('b', 'f', true)]
        [TestCase('b', 'g', false)]
        [TestCase('c', 'a', false)]
        [TestCase('c', 'b', false)]
        [TestCase('c', 'c', true)]
        [TestCase('c', 'd', false)]
        [TestCase('c', 'e', true)]
        [TestCase('c', 'f', true)]
        [TestCase('c', 'g', false)]
        [TestCase('d', 'a', false)]
        [TestCase('d', 'b', false)]
        [TestCase('d', 'c', false)]
        [TestCase('d', 'd', true)]
        [TestCase('d', 'e', true)]
        [TestCase('d', 'f', true)]
        [TestCase('d', 'g', false)]
        [TestCase('e', 'a', false)]
        [TestCase('e', 'b', false)]
        [TestCase('e', 'c', false)]
        [TestCase('e', 'd', false)]
        [TestCase('e', 'e', true)]
        [TestCase('e', 'f', true)]
        [TestCase('e', 'g', false)]
        [TestCase('f', 'a', false)]
        [TestCase('f', 'b', false)]
        [TestCase('f', 'c', false)]
        [TestCase('f', 'd', false)]
        [TestCase('f', 'e', false)]
        [TestCase('f', 'f', true)]
        [TestCase('f', 'g', false)]
        [TestCase('g', 'a', false)]
        [TestCase('g', 'b', false)]
        [TestCase('g', 'c', false)]
        [TestCase('g', 'd', true)]
        [TestCase('g', 'e', true)]
        [TestCase('g', 'f', true)]
        [TestCase('g', 'g', true)]
        public void RouteBetweenNodes_ValidInput_ExpectedResult(char start,
            char end, bool expected)
        {
            var graph = CreateGraph();

            var actual = GraphExtensions.HasRouteBetweenNodes(graph, start, end);
            Assert.AreEqual(expected, actual);
        }
    }
}
