using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
	public class CheckBSTTests
	{
		private TreeNode<int> CreateOneNode()
		{
			return new TreeNode<int>(0);
		}

		private TreeNode<int> CreateTwoLevels()
		{
			var root = new TreeNode<int>(1);
			var left = new TreeNode<int>(0);
			var right = new TreeNode<int>(2);
			root.Left = left;
			root.Right = right;

			return root;
		}

        private TreeNode<int> CreateTwoLevelsNonBST()
        {
            var root = new TreeNode<int>(0);
            var left = new TreeNode<int>(1);
            var right = new TreeNode<int>(1);
            root.Left = left;
            root.Right = right;

            return root;
        }

        private TreeNode<int> CreateThreeLevels()
		{
			var root = new TreeNode<int>(2);
			var left = new TreeNode<int>(0);
			var right = new TreeNode<int>(4);
			var left2 = new TreeNode<int>(3);
			var right2 = new TreeNode<int>(1);

			root.Left = left;
			root.Right = right;

			left.Right = right2;
			right.Left = left2;

			return root;
		}

        private TreeNode<int> CreateThreeLevelsNonBST()
        {
            var root = new TreeNode<int>(1);
            var left = new TreeNode<int>(0);
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
        public void CheckBST_Null_True()
        {
            var actual = TreeExtensions.CheckBST(null);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void CheckBST_BST_True()
        {
            var actual = TreeExtensions.CheckBST(CreateOneNode());
            Assert.AreEqual(true, actual);

            actual = TreeExtensions.CheckBST(CreateTwoLevels());
            Assert.AreEqual(true, actual);

            actual = TreeExtensions.CheckBST(CreateThreeLevels());
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void CheckBST_NonBST_False()
        {
            var actual = TreeExtensions.CheckBST(CreateTwoLevelsNonBST());
            Assert.AreEqual(false, actual);

            actual = TreeExtensions.CheckBST(CreateThreeLevelsNonBST());
            Assert.AreEqual(false, actual);
        }
    }
}
