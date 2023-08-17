

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0, "FizzBuzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(13, "13")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(-6, "Fizz")]
        [TestCase(-10, "Buzz")]
        [TestCase(-13, "-13")]
        [TestCase(-15, "FizzBuzz")]

        public void GetOutput_WhenCalled_ReturnsFizzBuzz(int a, string expectedResult)
        {

            Assert.That(FizzBuzz.GetOutput(a), Is.EqualTo(expectedResult));            

        }
    }
}
