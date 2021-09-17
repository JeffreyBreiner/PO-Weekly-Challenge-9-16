using System;
using System.Collections.Generic;

namespace PO_Weekly_Challenge_9_16
{
    class Program
    {
        private static bool isPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            else if (num <= 3)
            {
                return true;
            }
            else
            {
                for (int i = 2 ; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private static string expressFactor(int num)
        {
            List<int> primes = new List<int>();
            string result = "";

            for (int i = 2; i <= num; i++)
            {
                int power = 0;
                while (num % i == 0 && isPrime(i))
                {
                    num = num / i;
                    power++;
                    if (power == 1)
                    {
                        primes.Add(i);
                    }
                }

                if (power > 1)
                {
                    primes.Add(power * -1); //negative number indicates the power of the previous prime, not a new prime
                }
            }

            for (int i = 0; i < primes.Count; i++)
            {
                if (i == 0)
                {
                    result = $"{primes[i]}";
                }
                else if (primes[i] < 0)
                {
                    result += $"^{primes[i] * -1}";
                }
                else
                {
                    result += $" X {primes[i]}";
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(expressFactor(int.Parse(Console.ReadLine())));
        }
    }
}
