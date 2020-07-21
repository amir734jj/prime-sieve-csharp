using System;
using System.Collections.Generic;
using System.Linq;
using Sieve;
using Xunit;

namespace App
{
    public class SieveTest
    {
        private const int N = 10;

        private readonly List<int> _primes;
        
        public SieveTest()
        {
            _primes = Enumerable.Range(2, N - 1)
                .AsParallel()
                .Where(i => Enumerable.Range(1, (int) Math.Sqrt(i)).All(j => j == 1 || i % j != 0))
                .OrderBy(x => x)
                .ToList();
        }
        
        [Fact]
        public void SieveOfEratosthenes()
        {
            var result = new SieveOfEratosthenes().Calculate(N);

            Assert.Equal(_primes, result);
        }
        
        [Fact]
        public void SieveOfEuler()
        {
            var result = new SieveOfEuler().Calculate(N);

            Assert.Equal(_primes, result);
        }
        
        [Fact]
        public void SieveOfSundaram()
        {
            var result = new SieveOfSundaram().Calculate(N);

            Assert.Equal(_primes, result);
        }
    }
}