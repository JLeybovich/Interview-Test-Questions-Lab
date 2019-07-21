namespace InterviewQuestions.LinkedLists
{
    public static partial class LinkedListExtensions
    {
        public static T FindFromLast<T>(LinkedListNode<T> head, int k)
        {
            if (head == null) return default;

            LinkedListNode<T> peak = head;

            for(int i = 0; i < k; ++i)
            {
                peak = peak.Next;

                if(peak == null)
                {
                    return default;
                }
            }

            LinkedListNode<T> curr = head;
            LinkedListNode<T> prev = head;

            while (peak != null)
            {
                prev = curr;
                curr = curr.Next;
                peak = peak.Next;
            }

            return curr == null ? prev.Value : curr.Value;
        }
    }
}
