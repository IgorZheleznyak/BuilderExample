namespace BuilderExample
{
    public interface ICustomerName
    {
        IProductName SetCustomerName(string name);
    }

    public interface IProductName
    {
        IProductPrice SetProductName(string name);
    }

    public interface IProductPrice
    {
        IBuild SetProductPrice(double price);
    }

    public interface IBuild
    {
        Order Build();
    }
}
