using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace RegexProbak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Szoveg.txt");

            Regex regex = new Regex(@"^BME.+,(\d+/\d+/\d+),.+$");
            foreach (var line in lines)
            {
                MatchCollection matches = regex.Matches(line);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups[1].Value);
                }
            }
        }
    }
}
