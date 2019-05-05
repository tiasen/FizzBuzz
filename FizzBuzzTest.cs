using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void GetResultTest()
        {
            string resultFizz = FizzBuzz.GetResult(3);
            string resultBuzz = FizzBuzz.GetResult(5);
            string resultFizzBuzz = FizzBuzz.GetResult(15);
            string resuteNumber = FizzBuzz.GetResult(2);
            Assert.Equal("Fizz", resultFizz);
            Assert.Equal("Buzz", resultBuzz);
            Assert.Equal("FizzBuzz", resultFizzBuzz);
            Assert.Equal("2", resuteNumber);
        }
    }
}