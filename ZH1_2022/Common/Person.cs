using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Person(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;

            Regex regex = new Regex("^[a-zA-Z -]+$");
            bool result = regex.IsMatch(name);
            if (result == false)
            {
                throw new ArgumentException("A név csak betűket, szóközt és kötőjelet tartalmazhat!");
            }
        }

        public static Person GetMe()
        {
            return new Person("Sample Squirrel", 25, 180);
        }

        public string GetDescription()
        {
            return $"{Name} ({Height} cm magas), kora {Age}.";
        }
    }
}
