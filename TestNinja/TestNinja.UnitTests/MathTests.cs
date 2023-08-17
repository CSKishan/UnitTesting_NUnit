using NUnit.Framework;
using System.Collections.Generic;
using TestNinja.Fundamentals;
using System.Linq;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        // SetUp
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        // TearDown

        [Test]
        [Ignore("Because I wanted to")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsTheGreaterArgument(int a, int b, int expectedResult)
        {

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5, new int[] {1, 3, 5})]
        [TestCase(0, new int[] { })]
        [TestCase(-5, new int[] { })]
        public void GetOddNumbers_WhenCalled_ReturnsListOfOddNumbersUpToLimit(int a, int[] expectedResult)
        {
            var result = _math.GetOddNumbers(a);

            Assert.That(result, Is.EquivalentTo(expectedResult));
        }
    }
}
