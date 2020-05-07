namespace InterviewQuestions.LinkedLists
{
    public static partial class LinkedListExtensions
    {
        public static bool ContainsCycle<T>(LinkedListNode<T> firstNode)
        {
            // Start both runners at the beginning
            var slowRunner = firstNode;
            var fastRunner = firstNode;

            // Until we hit the end of the list
            while (fastRunner != null && fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;

                // Case: fastRunner is about to "lap" slowRunner
                if (fastRunner == slowRunner)
                {
                    return true;
                }
            }

            // Case: fastRunner hit the end of the list
            return false;
        }
    }
}