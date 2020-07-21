using System;
using System.Collections;
using System.Collections.Generic;
using Sieve.Extensions;
using Sieve.Interfaces;

namespace Sieve
{
    /// <summary>
    /// Sieve of Eratosthenes
    /// </summary>
    public class SieveOfEratosthenes : ISieve
    {
        public IEnumerable<int> Calculate(int n)
        {
            var array = new BitArray(n, true) {[0] = false, [1] = false};

            for (var i = 2; i < Math.Sqrt(n); i++)
            {
                if (!array[i]) continue;

                for (var j = i * i; j < n; j += i)
                {
                    array[j] = false;
                }
            }

            return array.CollectBitArray();
        }
    }
}