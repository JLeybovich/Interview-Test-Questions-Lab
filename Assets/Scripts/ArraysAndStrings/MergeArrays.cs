namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static int[] MergeArraysMine(int[] myArray, int[] alicesArray)
        {
            // Combine the sorted arrays into one large sorted array
            // 1. Keep Indices of both
            // 2. While Indices are less the associated array lengths
            // 3. Compare values at indices
            // 4. Add whichever is less
            // 5. Increment the associatted index 
            // 6. Continue iteration
            // 7. Add any remaining elements for either array

            int[] mergedArray = new int[myArray.Length + alicesArray.Length];
            int myIndex = 0, alicesIndex = 0, mergedIndex = 0;
            while (myIndex < myArray.Length && alicesIndex < alicesArray.Length)
            {
                int myValue = myArray[myIndex];
                int alicesValue = alicesArray[alicesIndex];

                if (myValue < alicesValue)
                {
                    mergedArray[mergedIndex] = myValue;
                    ++myIndex;
                }
                else
                {
                    mergedArray[mergedIndex] = alicesValue;
                    ++alicesIndex;
                }

                ++mergedIndex;
            }

            while (myIndex < myArray.Length)
            {
                mergedArray[mergedIndex] = myArray[myIndex];
                ++myIndex;
                ++mergedIndex;
            }

            while (alicesIndex < alicesArray.Length)
            {
                mergedArray[mergedIndex] = alicesArray[alicesIndex];
                ++alicesIndex;
                ++mergedIndex;
            }

            return mergedArray;
        }

        public static int[] MergeArrays(int[] myArray, int[] alicesArray)
        {
            // Set up our mergedArray
            var mergedArray = new int[myArray.Length + alicesArray.Length];

            int currentIndexAlices = 0;
            int currentIndexMine = 0;
            int currentIndexMerged = 0;

            while (currentIndexMerged < mergedArray.Length)
            {
                bool isMyArrayExhausted = currentIndexMine >= myArray.Length;
                bool isAlicesArrayExhausted = currentIndexAlices >= alicesArray.Length;

                // Case: next comes from my array
                // My array must not be exhausted, and EITHER:
                // 1) Alice's array IS exhausted, or
                // 2) the current element in my array is less
                //    than the current element in Alice's array
                if (!isMyArrayExhausted && (isAlicesArrayExhausted
                        || (myArray[currentIndexMine] < alicesArray[currentIndexAlices])))
                {
                    mergedArray[currentIndexMerged] = myArray[currentIndexMine];
                    currentIndexMine++;
                }
                else
                {
                    // Case: next comes from Alice's array
                    mergedArray[currentIndexMerged] = alicesArray[currentIndexAlices];
                    currentIndexAlices++;
                }

                currentIndexMerged++;
            }

            return mergedArray;
        }
    }
}