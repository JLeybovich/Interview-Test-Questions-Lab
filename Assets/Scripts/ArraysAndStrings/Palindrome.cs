using InterviewQuestions.Common;

namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static bool IsPalindromePermutation(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return true;
            }

            var bitVector = new BitVector();

            foreach(var ch in str)
            {
                bitVector.Toggle(ch);
            }

            return bitVector.ZeroOrOneSet;
        }
    }
}