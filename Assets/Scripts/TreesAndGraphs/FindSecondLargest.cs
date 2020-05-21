using System;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class TreeExtensions
    {
        public static T FindLargest<T>(TreeNode<T> rootNode)
        {
            var current = rootNode;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }

        public static T FindSecondLargest<T>(TreeNode<T> rootNode)
        {
            // Find the second largest item in the binary search tree
            if (rootNode == null
                || (rootNode.Left == null && rootNode.Right == null))
            {
                throw new ArgumentException("Tree must have at least 2 nodes",
                    nameof(rootNode));
            }

            var current = rootNode;

            while (true)
            {
                // Case: current is largest and has a left subtree
                // 2nd largest is the largest in that subtree
                if (current.Left != null && current.Right == null)
                {
                    return FindLargest(current.Left);
                }

                // Case: current is parent of largest, and largest has no children,
                // so current is 2nd largest
                if (current.Right != null
                    && current.Right.Left == null
                    && current.Right.Right == null)
                {
                    return current.Value;
                }

                current = current.Right;
            }
        }
    }
}