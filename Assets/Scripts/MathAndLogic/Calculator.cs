using System.Collections.Generic;

namespace InterviewQuestions.MathAndLogic
{
    public static partial class MathExtensions
    {
        public static int Calculate(string equation)
        {
            if (string.IsNullOrEmpty(equation)) return 0;
            int length = equation.Length;

            Stack<int> resultStack = new Stack<int>();

            int num = 0;
            char sign = '+';
            for (int i = 0; i < length; ++i)
            {
                char val = equation[i];

                if (char.IsDigit(val))
                {
                    num = num * 10 + val - '0';
                }

                if (!char.IsDigit(val) || i == length - 1)
                {
                    switch (sign)
                    {
                        case '-':
                            resultStack.Push(-num);
                            break;
                        case '+':
                            resultStack.Push(num);
                            break;
                        case '*':
                            resultStack.Push(resultStack.Pop() * num);
                            break;
                        case '/':
                            resultStack.Push(resultStack.Pop() / num);
                            break;
                        default:
                            break;
                    }

                    sign = val;
                    num = 0;
                }
            }

            int total = 0;
            while(resultStack.Count > 0)
            {
                total += resultStack.Pop();
            }

            return total;
        }
    }
}