namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static bool IsFirstComeFirstServed(int[] takeOutOrders, int[] dineInOrders, int[] servedOrders)
        {
            int takeOutOrdersIndex = 0;
            int dineInOrdersIndex = 0;

            foreach (var order in servedOrders)
            {
                if (takeOutOrdersIndex < takeOutOrders.Length && order == takeOutOrders[takeOutOrdersIndex])
                {
                    // If we still have orders in takeOutOrders
                    // and the current order in takeOutOrders is the same
                    // as the current order in servedOrders
                    takeOutOrdersIndex++;
                }
                else if (dineInOrdersIndex < dineInOrders.Length && order == dineInOrders[dineInOrdersIndex])
                {
                    // If we still have orders in dineInOrders
                    // and the current order in dineInOrders is the same
                    // as the current order in servedOrders
                    dineInOrdersIndex++;
                }
                else
                {
                    // If the current order in servedOrders doesn't match the current
                    // order in takeOutOrders or dineInOrders, then we're not serving first-come,
                    // first-served
                    return false;
                }
            }

            // Check for any extra orders at the end of takeOutOrders or dineInOrders
            if (dineInOrdersIndex != dineInOrders.Length || takeOutOrdersIndex != takeOutOrders.Length)
            {
                return false;
            }

            // All orders in servedOrders have been "accounted for"
            // so we're serving first-come, first-served!
            return true;
        }
    }
}