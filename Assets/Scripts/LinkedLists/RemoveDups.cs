namespace InterviewQuestions.LinkedLists
{
    public static partial class LinkedListExtensions
    {
        public static void DeleteDups<T>(ref LinkedListNode<T> head)
        {
            var current = head;

            while(current != null)
            {
                var runner = current;

                while(runner.Next != null)
                {
                    if(runner.Next.Value.Equals(current.Value))
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }
    }
}