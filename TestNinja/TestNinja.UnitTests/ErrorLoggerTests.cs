using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;
        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
        
            _logger.Log("a");

            Assert.That(_logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            // Using delegates
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
            // Assert.That(() => _logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());

        }

        [Test]
        public void Log_ValidError_RaiseErrorLogEvent()
        {
            var id = Guid.Empty;
            _logger.ErrorLogged += (s, e) => { id = e; };

            _logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
