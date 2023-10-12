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
    }
}
