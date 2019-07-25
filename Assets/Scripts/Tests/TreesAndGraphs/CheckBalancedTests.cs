using NUnit.Framework;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class CheckBalancedTests
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

        private TreeNode<int> CreateTwoLevelsUnbalanced()
        {
            var root = new TreeNode<int>(0);
            var left = new TreeNode<int>(1);
            var left2 = new TreeNode<int>(2);
            root.Left = left;
            left.Left = left2;

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

        private TreeNode<int> CreateThreeLevelsUnbalanced()
        {
            var root = new TreeNode<int>(0);
            var left = new TreeNode<int>(1);
            var right = new TreeNode<int>(2);
            var right2 = new TreeNode<int>(3);
            var right3 = new TreeNode<int>(5);
            var right4 = new TreeNode<int>(6);

            root.Left = left;
            root.Right = right;

            left.Right = right2;
            right.Right = right3;

            right2.Right = right4;

            return root;
        }

        [Test]
        public void CheckHeight_Null_NegativeOne()
        {
            var actual = TreeExtensions.CheckHeight<int>(null);
            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void CheckHeight_Balanced_Zero()
        {
            var actual = TreeExtensions.CheckHeight(CreateOneNode());
            Assert.AreEqual(0, actual);

            actual = TreeExtensions.CheckHeight(CreateTwoLevels());
            Assert.AreEqual(1, actual);

            actual = TreeExtensions.CheckHeight(CreateThreeLevels());
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void CheckHeight_Unbalanced_MinValue()
        {
            var actual = TreeExtensions.CheckHeight(CreateTwoLevelsUnbalanced());
            Assert.AreEqual(int.MinValue, actual);

            actual = TreeExtensions.CheckHeight(CreateThreeLevelsUnbalanced());
            Assert.AreEqual(int.MinValue, actual);
        }

        [Test]
        public void IsBalanced_Unbalanced_False()
        {
            var actual = TreeExtensions.IsBalanced(CreateTwoLevelsUnbalanced());
            Assert.AreEqual(false, actual);

            actual = TreeExtensions.IsBalanced(CreateThreeLevelsUnbalanced());
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsBalanced_Balanced_True()
        {
            var actual = TreeExtensions.IsBalanced(CreateOneNode());
            Assert.AreEqual(true, actual);

            actual = TreeExtensions.IsBalanced(CreateTwoLevels());
            Assert.AreEqual(true, actual);

            actual = TreeExtensions.IsBalanced(CreateThreeLevels());
            Assert.AreEqual(true, actual);
        }
    }
}