using Enumerable;

namespace Tests
{
    public class Basics
    {
        [Fact]
        public void GetNumbersReturnsCorrectNumberOfNumbers()
        {
            var nums = NumberSources.GetPrimes(1000);
            Assert.Equal(1000, nums.Count());
        }
    }
}