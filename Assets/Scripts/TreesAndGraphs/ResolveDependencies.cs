using System.Collections.Generic;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class GraphExtensions
    {
        public static List<char> ResolveDependencies(List<GraphNode<char>> graphNodes)
        {
            var resolvedList = new List<char>();
            var workingGraph = new List<GraphNode<char>>(graphNodes);

            while(workingGraph.Count > 0)
            {
                GraphNode<char> resolvedNode = null;

                foreach(var node in workingGraph)
                {
                    if(node.Adjacent.Count == 0)
                    {
                        resolvedNode = node;
                        resolvedList.Add(resolvedNode.Value);
                        break;
                    }
                }

                workingGraph.Remove(resolvedNode);

                foreach(var node in workingGraph)
                {
                    if(node.Adjacent.Contains(resolvedNode))
                    {
                        node.Adjacent.Remove(resolvedNode);
                    }
                }
            }

            return resolvedList;
        }
    }
}