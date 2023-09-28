using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        public class Person
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
            string jsonString = JsonSerializer.Serialize(persons);
            File.WriteAllText("persons.json", jsonString);

            XmlSerializer xs = new XmlSerializer(typeof(Person[]));
            using (StreamWriter wr = new StreamWriter("persons.xml"))
            {
                xs.Serialize(wr, persons);
            }

            string newJsonString = File.ReadAllText("persons.json");
            Person[] newPersons = JsonSerializer.Deserialize<Person[]>(newJsonString);

            using (StreamReader rd = new StreamReader("persons.xml"))
            {
                Person[] newPersonsFromXml = (Person[])xs.Deserialize(rd);
            }
        }
    }
}
