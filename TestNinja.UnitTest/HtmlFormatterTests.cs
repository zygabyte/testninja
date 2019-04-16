using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_MakeStringBold_ReturnBoldMarkup()
        {
            var htmlFormatter = new HtmlFormatter();

            var result = htmlFormatter.FormatAsBold("C# unit test");
            
            // more specific
            Assert.That(result, Is.EqualTo("<strong>C# unit test</strong>").IgnoreCase);
            
            // more general way of testing. best for error messages
//            Assert.That(result, Does.StartWith("<strong>"));
//            Assert.That(result, Does.EndWith("</strong>"));
//            Assert.That(result, Does.Contain("C# unit test"));
        } 
    }
}