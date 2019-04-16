using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            var customer = new CustomerController();

            var result = customer.GetCustomer(0);
            
            Assert.That(result, Is.TypeOf<NotFound>());
            
//            Assert.That(result, Is.InstanceOf<NotFound>());
        }
    }
}