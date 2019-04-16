using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15)]
        [TestCase(9)]
        [TestCase(30)]
        public void GetOutput_DivisibleByThreeAndFive_ReturnsZero(int number)
        {
            string result = FizzBuzz.GetOutput(number);
            
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        
        [Test]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(8)]
        public void GetOutput_DivisibleByThree_ReturnsZero(int number)
        {
            string result = FizzBuzz.GetOutput(number);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        [Test]
        [TestCase(10)]
        [TestCase(9)]
        [TestCase(25)]
        public void GetOutput_DivisibleByFive_ReturnsZero(int number)
        {
            string result = FizzBuzz.GetOutput(number);
            
            Assert.That(result, Is.EqualTo("Buzz"));
        }
    }
}