namespace BuilderExample
{
    public class OrderBuilderTwo
    {
        private Order _order;

        private OrderBuilderTwo()
        {
            _order = new Order();
        }

        public static OrderBuilderTwo StartBuild()
        {
            return new OrderBuilderTwo();
        }

        public OrderBuilderTwo SetUsername(string name)
        {
            _order.SetCustomerName(name);
            return this;
        }

        public OrderBuilderTwo SetProductName(string name)
        {
            _order.SetProductName(name);
            return this;
        }

        public OrderBuilderTwo SetProductPrice(double price)
        {
            _order.SetProductPrice(price);
            return this;
        }
    }
}
