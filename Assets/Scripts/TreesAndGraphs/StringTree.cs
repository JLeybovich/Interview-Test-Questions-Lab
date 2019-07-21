using System.Collections.Generic;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class StringExtensions
    {
        public static TreeNode<char> TreeFromString(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return null;
            }

            var nodes = new List<TreeNode<char>>();

            foreach(var ch in str)
            {
                var node = new TreeNode<char>(ch);
                nodes.Add(node);
            }

            for(var i = 0; i < str.Length; ++i)
            {
                var node = nodes[i];

                var leftIndex = (2 * (i + 1)) - 1;
                if (leftIndex < str.Length)
                {
                    node.Left = nodes[leftIndex];
                }

                var rightIndex = leftIndex + 1;
                if (rightIndex < str.Length)
                {
                    node.Right = nodes[rightIndex];
                }
            }

            return nodes[0];
        }
    }
}
