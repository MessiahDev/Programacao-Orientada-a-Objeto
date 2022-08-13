using System.Text;
using System.Globalization;
using Course3.Entities.Enums;

namespace Course3.Entities
{
    internal class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            {
                sb.AppendLine("Order momment: " + Momment.ToString("dd/mm/yyy HH:mm:ss"));
                sb.AppendLine("Order status: " + Status);
                sb.AppendLine("Client: " + Client);
                sb.AppendLine("Order intens:");                
                foreach (OrderItem item in Items)
                {
                    sb.AppendLine(item.ToString());
                }
                sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }  
    }
}
