namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        private const ulong uOne = 1;

        public static bool IsUnique(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return true;
            }

            ulong checker = 0, charVisitedCheck = 0, charMask = 0;
            bool hasSeenChar = false;

            foreach(var charVal in str)
            {
                charMask = uOne << charVal;
                charVisitedCheck = checker & charMask;
                hasSeenChar = charVisitedCheck > 0;
                if (hasSeenChar)
                {
                    return false;
                }

                checker |= charMask;
            }

            return true;
        }
    }
}