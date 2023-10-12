using Enumerable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Take2Tests
    {
        [Fact]
        public void Basics()
        {
            var nums = NumberSources.GetNumbers(0);
            Assert.Equal(0,nums.Take2().Count());
        }

        [Fact]
        public void ReturnsSingleElement()
        {
            var nums = NumberSources.GetNumbers(1);
            Assert.Equal(1, nums.Take2().Count());
        }

    }
}
