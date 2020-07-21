using System.Collections;
using System.Collections.Generic;
using Sieve.Extensions;
using Sieve.Interfaces;

namespace Sieve
{
    /// <summary>
    /// Sieve of Euler
    /// </summary>
    public class SieveOfEuler : ISieve
    {
        public IEnumerable<int> Calculate(int n)
        {
            var array = new BitArray(n, false) {[2] = true};
            for (var i = 3; i < n; i += 2) array[i] = true;

            for (var p = 3; p < n; p += 2)
            {
                if (!array[p]) continue;

                var maxQ = n / p;
                if (maxQ % 2 == 0) maxQ--;
                for (var q = maxQ; q >= p; q -= 2)
                {
                    if (array[q]) array[p * q] = false;
                }
            }

            return array.CollectBitArray();
        }
    }
}