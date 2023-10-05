namespace Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = NumberSources.GetPrimes(10);
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
    }
}