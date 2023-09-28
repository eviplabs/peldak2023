using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace RegexProbak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"Szoveg.txt";
            string[] lines = File.ReadAllLines(filePath);
            int sum = 0;
            var pattern = @"^(?:[^,]*,){10}(\d+)/(\d+)/(\d+),";
            var regex = new Regex(pattern);
            foreach (var line in lines)
            { 
                var match = regex.Match(line);
                sum += match.Success ? int.Parse(match.Groups[1].Value) : 0;
            }
            Console.WriteLine(sum);
        }
    }
}
