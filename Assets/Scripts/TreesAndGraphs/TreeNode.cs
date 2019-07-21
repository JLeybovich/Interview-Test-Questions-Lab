namespace InterviewQuestions.TreesAndGraphs
{
    public class TreeNode<T>
    {
        public T Value { get; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode()
        {
        }

        public TreeNode(T value, TreeNode<T> left = null,
            TreeNode<T> right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
