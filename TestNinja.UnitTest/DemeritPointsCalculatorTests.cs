using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
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
        [TestCase(-5)]
        [TestCase(335)]
        public void CalculateDemeritPoints_CheckIfNegative_ThrowOutOfRangeException(int speed)
        {
//            var demeritPoints = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
//            Assert.That(demeritPoints, Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }
        
//        [Test]
//        [TestCase(5)]
//        [TestCase(35)]
//        public void CalculateDemeritPoints_CheckIfLessThanOrEqualSpeedLimit_ReturnZero(int speed)
//        {
//            var demeritPoints = _demeritPointsCalculator.CalculateDemeritPoints(speed);
//            
//            Assert.That(demeritPoints, Is.EqualTo(0));
//        }
        
        [Test]
        [TestCase(70, 1)]
        [TestCase(35, 0)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_CheckSpeedLimit_DemeritPoints(int speed, int demerit)
        {
            var demeritPoints = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            
            Assert.That(demeritPoints, Is.EqualTo(demerit));
        }
        
    }
}