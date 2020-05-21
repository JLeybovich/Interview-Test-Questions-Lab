using InterviewQuestions.Common;

namespace InterviewQuestions.TreesAndGraphs
{
    public class TreeNode<T> : Node<T>
    {
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value = default, TreeNode<T> left = null,
            TreeNode<T> right = null) : base(value)
        {
            Left = left;
            Right = right;
        }

        public static implicit operator TreeNode<T>(T v)
        {
            return new TreeNode<T>(v);
        }
    }
}
