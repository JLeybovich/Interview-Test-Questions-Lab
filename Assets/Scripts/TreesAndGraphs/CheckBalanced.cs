using System;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class TreeExtensions
    {
        public static int CheckHeight<T>(TreeNode<T> root)
        {
            if(root == null) return -1;

            int leftHeight = CheckHeight(root.Left);
            if (leftHeight == int.MinValue) return int.MinValue;

            int rightHeight = CheckHeight(root.Right);
            if (rightHeight == int.MinValue) return int.MinValue;

            int heightDiff = leftHeight - rightHeight;

            if (Math.Abs(heightDiff) > 1)
            {
                return int.MinValue;
            }

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public static bool IsBalanced<T>(TreeNode<T> root)
        {
            return CheckHeight(root) != int.MinValue;
        }
    }
}
