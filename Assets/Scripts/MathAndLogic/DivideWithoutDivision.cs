using System;

namespace InterviewQuestions.MathAndLogic
{
    public static partial class MathExtensions
    {
        public static long DivideWithoutDivision(long numerator, long denomenator)
        {
            if (denomenator == 0) return 0;

            // Calculate sign of divisor i.e., 
            // sign will be negative only if 
            // either one of them is negative 
            // otherwise it will be positive 
            long sign = numerator < 0 || denomenator < 0 ? -1 : 1;

            // Update both divisor and 
            // dividend positive 
            numerator = Math.Abs(numerator);
            denomenator = Math.Abs(denomenator);

            // Initialize the quotient 
            long quotient = 0;

            //while (numerator >= denomenator)
            //{
            //    numerator -= denomenator;
            //    ++quotient;
            //}

            // test down from the highest  
            // bit and accumulate the  
            // tentative value for 
            // valid bit 
            long temp = 0;
            for (int i = 31; i >= 0; --i)
            {
                if (temp + (denomenator << i) <= numerator)
                {
                    temp += denomenator << i;
                    quotient |= 1 << i;
                }
            }

            return sign * quotient;
        }
    }
}
