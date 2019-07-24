using System.Collections.Generic;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class TreeExtensions
    {
        public static List<LinkedList<TreeNode<T>>> CreateListOfDepths<T>(TreeNode<T> root)
        {
            if (root == null) return null;

            var result = new List<LinkedList<TreeNode<T>>>();

            var currentList = new LinkedList<TreeNode<T>>();
            currentList.AddLast(root);

            while(currentList.Count > 0)
            {
                result.Add(currentList);

                var parents = currentList;
                currentList = new LinkedList<TreeNode<T>>();

                foreach(var parent in parents)
                {
                    if(parent.Left != null)
                    {
                        currentList.AddLast(parent.Left);
                    }

                    if (parent.Right != null)
                    {
                        currentList.AddLast(parent.Right);
                    }
                }
            }

            return result;
        }
    }
}
