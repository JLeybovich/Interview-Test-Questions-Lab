using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
	public class ListOfDepthsTests
	{
        private TreeNode<int> CreateOneNode()
		{
			return new TreeNode<int>(0);
		}

        private TreeNode<int> CreateTwoLevels()
        {
            var root = new TreeNode<int>(0);
            var left = new TreeNode<int>(1);
            var right = new TreeNode<int>(2);
            root.Left = left;
            root.Right = right;

            return root;
        }

        private TreeNode<int> CreateThreeLevels()
        {
            var root = new TreeNode<int>(0);
            var left = new TreeNode<int>(1);
            var right = new TreeNode<int>(2);
            var left2 = new TreeNode<int>(3);
            var right2 = new TreeNode<int>(4);

            root.Left = left;
            root.Right = right;

            left.Right = right2;
            right.Left = left2;

            return root;
        }

        [Test]
        public void ListOfDepths_Null_Null()
		{
			var actual = TreeExtensions.CreateListOfDepths<int>(null);
			Assert.AreEqual(null, actual);
		}

		[Test]
		public void ListOfDepths_OneNode_One()
		{
			var tree = CreateOneNode();

			var actual = TreeExtensions.CreateListOfDepths(tree);

			Assert.AreEqual(1, actual.Count);
			Assert.AreEqual(0, actual[0].First.Value.Value);
		}

        [Test]
        public void ListOfDepths_TwoLevels_ExpectedResult()
        {
            var tree = CreateTwoLevels();

            var actual = TreeExtensions.CreateListOfDepths(tree);

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual(0, actual[0].First.Value.Value);
            Assert.AreEqual(1, actual[1].First.Value.Value);
            Assert.AreEqual(2, actual[1].First.Next.Value.Value);
        }

        [Test]
        public void ListOfDepths_ThreeLevels_ExpectedResult()
        {
            var tree = CreateThreeLevels();

            var actual = TreeExtensions.CreateListOfDepths(tree);

            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(0, actual[0].First.Value.Value);
            Assert.AreEqual(1, actual[1].First.Value.Value);
            Assert.AreEqual(2, actual[1].First.Next.Value.Value);
            Assert.AreEqual(4, actual[2].First.Value.Value);
            Assert.AreEqual(3, actual[2].First.Next.Value.Value);
        }
    }
}