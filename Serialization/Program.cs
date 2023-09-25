using System.Text.Json;

namespace Serialization
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private static Person[] persons = new Person[]
        {
            new Person { Name = "John", Age = 25 },
            new Person { Name = "Anna", Age = 18 },
            new Person { Name = "Maria", Age = 32 }
        };

        static void Main(string[] args)
        {
        }
    }
}