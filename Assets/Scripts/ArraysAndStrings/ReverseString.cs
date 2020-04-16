namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static void Reverse(char[] arrayOfChars)
        {
            // Reverse input array of characters in place
            // 1. Start with indices at beginning and end
            // 2. Loop till we reach the middle
            // 3. Swap the characters at the indices

            for (int headIdx = 0, tailIdx = arrayOfChars.Length - 1;
                headIdx < tailIdx; ++headIdx, --tailIdx)
            {
                arrayOfChars[headIdx] ^= arrayOfChars[tailIdx];
                arrayOfChars[tailIdx] ^= arrayOfChars[headIdx];
                arrayOfChars[headIdx] ^= arrayOfChars[tailIdx];
            }
        }
    }
}