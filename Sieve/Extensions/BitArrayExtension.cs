using System.Collections;
using System.Collections.Generic;

namespace Sieve.Extensions
{
    public static class BitArrayExtension
    {
        public static IEnumerable<int> CollectBitArray(this BitArray array)
        {
            for (var index = 0; index < array.Count; index++)
            {
                if (array[index])
                {
                    yield return index;
                }
            }
        }
    }
}