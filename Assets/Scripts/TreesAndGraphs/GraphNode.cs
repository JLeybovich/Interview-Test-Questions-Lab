using System.Collections.Generic;
using System.Linq;
using InterviewQuestions.Common;

namespace InterviewQuestions.TreesAndGraphs
{
    public class GraphNode<T> : Node<T>
    {
        public List<GraphNode<T>> Adjacent { get; set; }

        public GraphNode(T value = default, params GraphNode<T>[] adjacent)
            : base(value)
        {
            if(adjacent != null)
            {
                Adjacent = adjacent.ToList();
            }
        }
    }
}
