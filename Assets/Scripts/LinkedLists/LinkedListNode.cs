using InterviewQuestions.Common;

namespace InterviewQuestions.LinkedLists
{
    public class LinkedListNode<T> : Node<T>
    {
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value = default, LinkedListNode<T> next = null)
            : base(value)
        {
            Next = next;
        }
    }
}
