namespace Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers(10);
            foreach(var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }

        static public int[] GetNumbers(int count)
        {
            int[] numbers = new int[count];
            for(int i = 0; i < count; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }
    }
}