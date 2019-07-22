namespace InterviewQuestions.Common
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node(T value = default)
        {
            Value = value;
        }
    }
}
