namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static bool IsRotation(string str1, string str2)
        {
            if(string.IsNullOrEmpty(str1))
            {
                return string.IsNullOrEmpty(str2);
            }
            
            if(string.IsNullOrEmpty(str2))
            {
                return string.IsNullOrEmpty(str1);
            }

            var s1s1 = str1 + str1;

            return s1s1.Contains(str2);
        }
    }
}
