using C_Sharp_Intermediate;

namespace C_Sharp_Intermediate.Tests
{
    public class OrderProcessorTests
    {
        [Fact]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            var order = new Order1
            {
                Shipment = new Shipment(),
                IsShipped = true
            };

            Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
        }

        [Fact]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order1();

            orderProcessor.Process(order);
            Assert.True(order.IsShipped);
            Assert.Equal(1, order.Shipment.Cost);
            Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }
    }
}