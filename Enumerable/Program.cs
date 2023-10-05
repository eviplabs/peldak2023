namespace Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetPrimes(10);
            //var enumerator = numbers.GetEnumerator();

            //ExtensionMethods.Take2(numbers);
            //numbers.Take2();
            foreach (var number in numbers.Take2())
            {
                System.Console.WriteLine(number);
            }

            Console.WriteLine( numbers.Sum() );

            Console.WriteLine(numbers.Take2().Sum());

        }

        static public IEnumerable<int> GetNumbers(int count)
        {
            for(int i = 0; i < count; i++)
            {
                yield return i;
            }
        }

        // GetPrimes
        static public IEnumerable<int> GetPrimes(int count)
        {
            int counter = 0;
            int current = 2;
            while(counter < count)
            {
                if (IsPrime(current))
                {
                    yield return current;
                    counter++;
                }
                current++;
            }
        }

        private static bool IsPrime(int i)
        {
            bool isPrime = true;

            if (i == 1 || i == 0)
            {
                isPrime = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}