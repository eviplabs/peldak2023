using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PersonAger : IPersonModifier
    {
        public void Modify(Person person)
        {
            person.Age += 1;
        }
    }
}
