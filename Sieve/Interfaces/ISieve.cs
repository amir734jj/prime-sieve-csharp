using System.Collections.Generic;

namespace Sieve.Interfaces
{
    public interface ISieve
    {
        IEnumerable<int> Calculate(int n);
    }
}