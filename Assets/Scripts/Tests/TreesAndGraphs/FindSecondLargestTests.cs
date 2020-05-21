using NUnit.Framework;
using System;

namespace InterviewQuestions.TreesAndGraphs.Tests
{
    public class FindSecondLargestTests
    {
        [Test]
        public void FindSecondLargestTest()
        {
            var root = new TreeNode<int>(50);
            var a = root.Left = new TreeNode<int>(30);
            a.Left = 10;
            a.Right = 40;
            var b = new TreeNode<int>(70);
            root.Right = b;
            b.Left = 60;
            b.Right = 80;
            var actual = TreeExtensions.FindSecondLargest(root);
            var expected = 70;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LargestHasLeftChildTest()
        {
            var root = new TreeNode<int>(50);
            var a = new TreeNode<int>(30);
            root.Left = a;
            a.Left = 10;
            a.Right = 40;
            root.Right = 70;
            root.Right.Left = 60;
            var actual = TreeExtensions.FindSecondLargest(root);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LargestHasLeftSubtreeTest()
        {
            var root = new TreeNode<int>(50);
            var a = root.Left = 30;
            a.Left = 10;
            a.Right = 40;
            root.Right = 70;
            var b = root.Right.Left = 60;
            b.Left = 55;
            b.Left.Right = 58;
            b.Right = 65;
            var actual = TreeExtensions.FindSecondLargest(root);
            var expected = 65;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SecondLargestIsRootNodeTest()
        {
            var root = new TreeNode<int>(50);
            var a = root.Left = 30;
            a.Left = 10;
            a.Right = 40;
            root.Right = 70;
            var actual = TreeExtensions.FindSecondLargest(root);
            var expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DescendingLinkedListTest()
        {
            var root = new TreeNode<int>(50);
            root.Left = 40;
            root.Left.Left = 30;
            root.Left.Left.Left = 20;
            var actual = TreeExtensions.FindSecondLargest(root);
            var expected = 40;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AscendingLinkedListTest()
        {
            var root = new TreeNode<int>(50);
            root.Right = 60;
            root.Right.Right = 70;
            root.Right.Right.Right = 80;
            var actual = TreeExtensions.FindSecondLargest(root);
            var expected = 70;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptionWithTreeThatHasOneNodeTest()
        {
            var root = new TreeNode<int>(50);
            Assert.Throws<ArgumentException>(() => TreeExtensions.FindSecondLargest(root));
        }

        [Test]
        public void ExceptionWithEmptyTreeTest()
        {
            Assert.Throws<ArgumentException>(() => TreeExtensions.FindSecondLargest<int>(null));
        }
    }
}