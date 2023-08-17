using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;
        
        [SetUp]
        public void SetUp()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_CurrentSpeedIsBeyondLimits_ThrowArgumentOutOfRangeException(int a)
        {
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(a), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(50)]
        [TestCase(0)]
        [TestCase(60)]
        public void CalculateDemeritPoints_CurrentSpeedIsLessThanSpeedLimit_ReturnZero(int a)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(a);

            Assert.That(result, Is.Zero);
        }

        [Test]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_CurrentSpeedIsAboveSpeedLimit_ReturnDemeritPoints(int a, int expectedResult)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(a);

            Assert.That(result, Is.EqualTo(expectedResult));
        }


    }
}
