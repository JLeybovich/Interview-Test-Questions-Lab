namespace InterviewQuestions.LinkedLists
{
    public static partial class LinkedListExtensions
    {
        public static LinkedListNode<T>[] ValuesToLinkedListNodes<T>(T[] values)
        {
            var nodes = new LinkedListNode<T>[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                nodes[i] = new LinkedListNode<T>(values[i]);
                if (i > 0)
                {
                    nodes[i - 1].Next = nodes[i];
                }
            }
            return nodes;
        }
    }
}