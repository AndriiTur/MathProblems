using static MathsProblems.MathProblemsLibrary;

namespace MathsProblems
{
    internal class Problem3
    {
        private const long n = 600851475143;


        internal static string Largest_prime_factor()
        {
            var primes = Divisors.GetPrimeList(n);
            foreach (var prime in primes)
                MathsProblemsForm.Log(prime.ToString());
            var maxPrime = primes[primes.Count - 1];
            return maxPrime.ToString();
        }
    }

}