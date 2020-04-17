namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static void ReverseWords(char[] message)
        {
            // Decode the message by reversing the words

            ReverseChars(message, 0, message.Length - 1);

            int currentWordStartIndex = 0;
            for (int i = 0; i <= message.Length; i++)
            {
                // Found the end of the current word!
                if (i == message.Length || message[i] == ' ')
                {
                    // If we haven't exhausted the array our
                    // next word's start is one character ahead
                    ReverseChars(message, currentWordStartIndex, i - 1);
                    currentWordStartIndex = i + 1;
                }
            }
        }

        public static void ReverseChars(char[] arrayOfChars, int headIdx, int tailIdx)
        {
            while (headIdx < tailIdx)
            {
                arrayOfChars[headIdx] ^= arrayOfChars[tailIdx];
                arrayOfChars[tailIdx] ^= arrayOfChars[headIdx];
                arrayOfChars[headIdx] ^= arrayOfChars[tailIdx];

                ++headIdx;
                --tailIdx;
            }
        }
    }
}