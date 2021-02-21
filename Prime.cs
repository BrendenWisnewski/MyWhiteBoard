using System;

namespace NewPrime
{
    public class Prime
    {
        static public bool IsPrime(int input)
        {
            //int MaxRange = (int)Math.Sqrt(input);
            bool prime = true;

            for (int i = 2; i < input - 1; i++)
            {
                if (input % i == 0) prime = false;

            }

            return prime;
        }

        public static int IsPrimeSum(int input)
        {

            int sum = 0;
            for (int i = 2; i <= input; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }


            }
            return sum;
        }
    }
}
