using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestions.TreesAndGraphs
{
    public class Graph<T>
    {
        public List<GraphNode<T>> Nodes { get; set; }
            = new List<GraphNode<T>>();

        public Graph(params GraphNode<T>[] nodes)
        {
            if(nodes != null)
            {
                Nodes = nodes.ToList();
            }
        }

        public GraphNode<T> GetNode(T value)
        {
            return Nodes.FirstOrDefault(n => n.Value.Equals(value));
        }
    }
}
