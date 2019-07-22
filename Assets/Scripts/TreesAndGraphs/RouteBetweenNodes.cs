using System.Collections.Generic;
using InterviewQuestions.Common;

namespace InterviewQuestions.TreesAndGraphs
{
    public static partial class GraphExtensions
    {
        public static bool HasRouteBetweenNodes<T>(Graph<T> graph, T start, T end)
        {
            if (graph == null) return false;

            var startNode = graph.GetNode(start);
            if (startNode == null) return false;

            var nodes = graph.Nodes;
            var traversalQueue = new Queue<GraphNode<T>>();
            var visitedMap = new Dictionary<GraphNode<T>, TraversalState>();

            foreach(var node in nodes)
            {
                visitedMap[node] = TraversalState.Unvisited;
            }

            traversalQueue.Enqueue(startNode);
            while(traversalQueue.Count > 0)
            {
                var curr = traversalQueue.Dequeue();

                if(visitedMap[curr] == TraversalState.Unvisited)
                {
                    if(curr.Value.Equals(end))
                    {
                        return true;
                    }

                    foreach(var adj in curr.Adjacent)
                    {
                        traversalQueue.Enqueue(adj);
                    }

                    visitedMap[curr] = TraversalState.Visiting;
                }

                visitedMap[curr] = TraversalState.Visited;
            }

            return false;
        }
    }
}
