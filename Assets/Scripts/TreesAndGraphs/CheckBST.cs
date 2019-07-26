namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class TreeExtensions
	{
        public static bool CheckBST(TreeNode<int> root)
        {
            return CheckBST(root, null, null);
        }

		public static bool CheckBST(TreeNode<int> root, int? min, int? max)
		{
            if (root == null) return true;

            if(min.HasValue && root.Value <= min)
            {
                return false;
            }

            if (max.HasValue && root.Value > max)
            {
                return false;
            }

            if(!CheckBST(root.Left, min, root.Value) || !CheckBST(root.Right, root.Value, max))
            {
                return false;
            }

            return true;
		}
	}
}