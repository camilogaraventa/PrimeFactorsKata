using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        #region Methods

        public static List<Int32> Generate(Int32 number)
        {
            List<Int32> primes = new List<Int32>();
            Int32 candidate = 2;
            while (number > 1)
            {
                for (; number % candidate == 0; number /= candidate)
                {
                    primes.Add(candidate);
                }
                candidate++;
            }
            return primes;
        }

        #endregion
    }
}