namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static bool ArePermutations(string str1, string str2)
        {
            if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return string.IsNullOrEmpty(str1) && string.IsNullOrEmpty(str2);
            }

            int length = str1.Length;
            if (length != str2.Length)
            {
                return false;
            }

            int[] charCount = new int[char.MaxValue];
            
            for(int i = 0; i < length; ++i)
            {
                charCount[str1[i]]++;
            }

            for(int i = 0; i < length; ++i)
            {
                charCount[str2[i]]--;

                if (charCount[str2[i]] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}