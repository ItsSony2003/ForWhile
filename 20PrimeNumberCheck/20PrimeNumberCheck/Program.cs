using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20PrimeNumberCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of prime numbers to display: ");
            int numbers = int.Parse(Console.ReadLine());

            int count = 0; // Counter for the number of primes found
            int N = 2;     // Starting value to check for primes

            Console.WriteLine($"The first {numbers} prime numbers are:");
            while (count < numbers)
            {
                if (IsPrime(N))
                {
                    Console.Write(N + " ");
                    count++;
                }
                N++;
            }
            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
