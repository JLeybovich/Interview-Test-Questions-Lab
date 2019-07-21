namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class StringExtensions
    {
        public static string URLify(string str)
        {
            string result = str;
            if(string.IsNullOrEmpty(result))
            {
                return result;
            }

            // Remove from end
            int realLength = str.Length;
            int lastIndex = realLength - 1;
            int index = lastIndex;
            char charValue;
            for (; index >= 0; --index)
            {
                charValue = str[index];
                if(char.IsWhiteSpace(charValue))
                {
                    realLength--;
                }
                else
                {
                    break;
                }
            }

            result = result.Substring(0, realLength);

            for(index = realLength - 2; index >= 0; --index)
            {
                if(char.IsWhiteSpace(result[index]))
                {
                    int endIndex = index;
                    char wsCharValue;

                    for(int wsIndex = endIndex - 1; wsIndex >= 0; --wsIndex)
                    {
                        wsCharValue = result[wsIndex];
                        if (char.IsWhiteSpace(wsCharValue))
                        {
                            endIndex--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int range = index - endIndex;
                    result = result.Remove(endIndex, range + 1);

                    if(endIndex != 0)
                    {
                        result = result.Insert(endIndex, "%20");
                    }
                }
            }

            return result;
        }
    }
}