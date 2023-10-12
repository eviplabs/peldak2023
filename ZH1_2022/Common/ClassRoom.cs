using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Common
{
    public class ClassRoom
    {
        private List<Person> persons = new List<Person>();

        public void Add(Person person)
        {
            persons.Add(person);
        }

        public int Count()
        {
            return persons.Count;
        }

        public double AverageAge()
        {
            return persons.Average(p => p.Age);
        }

        public Person GetTallestPerson()
        {
            return persons.OrderByDescending(p => p.Height).First();
        }
    }
}
