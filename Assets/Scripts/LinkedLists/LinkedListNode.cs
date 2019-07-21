namespace InterviewQuestions.LinkedLists
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public LinkedListNode(T value = default, LinkedListNode<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
