using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sieve.Extensions;
using Sieve.Interfaces;

namespace Sieve
{
    /// <summary>
    /// Sieve of Sundaram
    /// https://en.wikipedia.org/wiki/Sieve_of_Sundaram
    /// </summary>
    public class SieveOfSundaram : ISieve
    {
        public IEnumerable<int> Calculate(int n)
        {
            var array = new BitArray(n, true) {[0] = false, [1] = false};

            for (var i = 1; i < n; i++)
            {
                var flag = true;

                for (var j = 1; j < n && flag; j++)
                {
                    var factor = i + j + 2 * i * j;

                    if (factor < n)
                    {
                        array[factor] = false;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }

            return new[] {2, 3}.Concat(array.CollectBitArray().Select(x => x * 2 + 1).TakeWhile(x => x < n));
        }
    }
}
