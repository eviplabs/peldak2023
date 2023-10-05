namespace Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers(10);
            var enumerator = numbers.GetEnumerator();
            //foreach(var number in numbers)
            //{
            //    System.Console.WriteLine(number);
            //}
            while(enumerator.MoveNext())
            {
                var number = enumerator.Current;
                Console.WriteLine(number);
            }
        }

        static public IEnumerable<int> GetNumbers(int count)
        {
            for(int i = 0; i < count; i++)
            {
                yield return i;
            }
        }
    }
}