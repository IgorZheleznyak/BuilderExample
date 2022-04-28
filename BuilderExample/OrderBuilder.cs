namespace BuilderExample
{
    public class OrderBuilder : ICustomerName, IProductName, IProductPrice, IBuild
    {
        private Order _order;

        private OrderBuilder()
        {
            _order = new Order();
        }

        public static ICustomerName StartBuild()
        {
            return new OrderBuilder();
        }

        public IProductName SetCustomerName(string name)
        {
            _order.SetCustomerName(name);
            return this;
        }

        public IProductPrice SetProductName(string name)
        {
            _order.SetProductName(name);
            return this;
        }

        public IBuild SetProductPrice(double price)
        {
            _order.SetProductPrice(price);
            return this;
        }

        public Order Build()
        {
            return _order;
        }
    }
}
