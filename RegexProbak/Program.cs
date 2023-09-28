using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace RegexProbak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"Szoveg.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                int sum = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var pattern = @"^(?:[^,]*,){10}(\d+)/(\d+)/(\d+),";
                    var regex = new Regex(pattern);
                    var match = regex.Match(line);
                    if (match.Success)
                    {
                        var studentCount = int.Parse(match.Groups[1].Value);
                        sum += studentCount;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
