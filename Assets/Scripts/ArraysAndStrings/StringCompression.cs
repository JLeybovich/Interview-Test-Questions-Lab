namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static string Compress(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return str;
            }

            string compressed = string.Empty;
            int consecutiveCount = 0, nextIdx = 0;
            char runningChar;
            int strLength = str.Length;

            for(int i = 0; i < strLength; ++i)
            {
                runningChar = str[i];
                consecutiveCount++;
                nextIdx = i + 1;

                if(nextIdx == strLength || runningChar != str[nextIdx])
                {
                    compressed += string.Format("{0}{1}", runningChar, 
                        consecutiveCount > 1 ? consecutiveCount.ToString() : "");
                    consecutiveCount = 0;
                }
            }

            return compressed.Length < strLength ? compressed : str;
        }
    }
}