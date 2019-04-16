using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(5, 8, 8)]
        [TestCase(4, 4, 4)]
        public void CompareTwoNumber_IsGreatest_ReturnGreatest(int a, int b, int greatest)
        {
            var result = _math.Max(a, b);
            
            Assert.That(result, Is.EqualTo(greatest));
        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            
            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));
//            Assert.That(result, Is.Ordered); // making sure its ordered
//            Assert.That(result, Is.Unique); //  making sure array has unique values
        }
    }
}