using System.Runtime.Serialization.Formatters;

namespace task11._1
{
    internal static class MathUtils
    {
        public static void IsPrime(double number)
        {
            int count = 0;
            for (int i = 1 ; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine($"{number} is prime");
            }
            else
            {
                Console.WriteLine($"{number} is not prime");
            }
        }
    }
}
