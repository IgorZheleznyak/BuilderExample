using NUnit.Framework;

namespace BuilderExample
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var orderBuilder = OrderBuilder.StartBuild().SetCustomerName("Andrew").SetProductName("B4B").SetProductPrice(20.5).Build();
            var orderBuilder2 = OrderBuilderTwo.StartBuild().SetProductName("").SetProductPrice(10).SetProductName("");
            Assert.Pass();
        }
    }
}