using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void Setup()
        {
            _logger = new ErrorLogger();    
        }
        
        [Test] 
        public void Log_WhenCalled_SetsLastError()
        {
            _logger.Log("abc");
            var result = _logger.LastError;
            
            Assert.That(result, Is.EqualTo("abc"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidLogMessage_ThrowsArgumentNullException(string error)
        {
            Assert.That(() => _logger.Log(""), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidLogMessage_EmitLogEvent()
        {
            var id = Guid.Empty;

            _logger.ErrorLogged += (sender, guid) => id = guid;
            
            _logger.Log("abc");
            
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}