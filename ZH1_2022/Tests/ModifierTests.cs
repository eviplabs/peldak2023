using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ModifierTests
    {
        [Fact]
        public void TestGrowPerson()
        {
            var p = new Person("John:", 77, 170);
            var grower = new PersonGrower();
            grower.N = 5;
            grower.Modify(p);
            Assert.Equal(175, p.Height);
        }
    }
}
