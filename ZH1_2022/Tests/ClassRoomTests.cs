using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ClassRoomTests
    {
        [Fact]
        public void TestAddition()
        {
            var classRoom = new ClassRoom();
            for(int i=0; i<3; i++)
            {
                classRoom.Add(Person.GetMe());
            }
            Assert.Equal(3, classRoom.Count());
        }

        [Fact]
        public void TestHeightInClass()
        {
            var p1 = new Person("Alfonz", 20, 160);
            var p2 = new Person("Bazalt", 21, 162);
            var c = new ClassRoom();
            c.Add(p1);
            c.Add(p2);
            Assert.Equal(p2, c.GetTallestPerson());
            var grower = new PersonGrower();
            grower.N = 5;
            grower.Modify(p1);
            Assert.Equal(p1, c.GetTallestPerson());
        }
    }
}
