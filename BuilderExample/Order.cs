using System;

namespace BuilderExample
{
    public class Order
    {
        private string? _customerName;
        private string? _productName;
        private double _productPrice;

        internal void SetCustomerName(string productName)
        {
            _customerName = productName;
        }

        internal void SetProductName(string productName)
        {
            _productName = productName;
        }

        internal void SetProductPrice(double productPrice)
        {
            _productPrice = productPrice;
        }

        internal string GetCustomerName()
        {
            if (_customerName != null)
                return _customerName;
            else
                throw new Exception("Error: Order._customerName is null");
        }

        internal string GetProductName()
        {
            if (_productName != null)
                return _productName;
            else
                throw new Exception("Error: Order._productName is null");
        }

        internal double GetProductPrice()
        {
            if (_productPrice > 0)
                return _productPrice;
            else
                throw new Exception("Error: Order._productPrice equals zero or less");
        }
    }
}
