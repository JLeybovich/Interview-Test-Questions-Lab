using UnityEngine;

namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static bool IsOneEditAway(string str1, string str2)
        {
            if(string.IsNullOrEmpty(str1))
            {
                return string.IsNullOrEmpty(str2) || str2.Length == 1;
            }

            if (string.IsNullOrEmpty(str2))
            {
                return string.IsNullOrEmpty(str1) || str1.Length == 1;
            }

            if (Mathf.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }

            string shorterStr = str1.Length < str2.Length ? str1 : str2;
            string longerStr = str1.Length < str2.Length ? str2 : str1;

            int shorterIndex = 0, longerIndex = 0;
            bool foundDifference = false;

            while(longerIndex < longerStr.Length && shorterIndex < shorterStr.Length)
            {
                if(shorterStr[shorterIndex] != longerStr[longerIndex])
                {
                    if(foundDifference)
                    {
                        return false;
                    }
                    foundDifference = true;

                    if(shorterStr.Length == longerStr.Length)
                    {
                        shorterIndex++;
                    }
                }
                else
                {
                    shorterIndex++;
                }
                longerIndex++;
            }

            return true;
        }
    }
}