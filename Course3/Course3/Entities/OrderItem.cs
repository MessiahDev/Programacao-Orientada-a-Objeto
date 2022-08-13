using System.Globalization;

namespace Course3.Entities
{
    internal class OrderItem
    {
        CultureInfo CI = CultureInfo.CurrentCulture;

        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2", CI) + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2", CI);
        }
    }
}
