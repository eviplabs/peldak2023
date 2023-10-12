using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PersonGrower : IPersonModifier
    {
        public int N { get; set; }

        public void Modify(Person person)
        {
            person.Height += N;
        }
    }
}
