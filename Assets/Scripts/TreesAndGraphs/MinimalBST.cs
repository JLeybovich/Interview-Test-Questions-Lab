namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class ArrayExtensions
    {
        public static TreeNode<int> CreateMinimalBST(int[] array)
        {
            if (array == null) return null;
            return CreateMinimalBST(array, 0, array.Length - 1);
        }

        public static TreeNode<int> CreateMinimalBST(int[] array, int start,
            int end)
        {
            if (array == null || end < start || start < 0 || end < 0
                || start >= array.Length || end >= array.Length)
            {
                return null;
            }

            int mid = (start + end) / 2;
            var node = new TreeNode<int>(array[mid]);

            node.Left = CreateMinimalBST(array, start, mid - 1);
            node.Right = CreateMinimalBST(array, mid + 1, end);

            return node;
        }
    }
}
