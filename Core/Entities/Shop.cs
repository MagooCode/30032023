using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Shop
    {

        private List<Order> _orders { get; set; }

        public Shop()
        {
            List<Order> _orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            //if (_orders[0] == null)
            //{
            //    _orders[0] = order;
            //}
            //else if (order is not null)
            //{
            _orders.Add(order);
            //}
            //else
            //{ 
            //    throw new ArgumentNullException(nameof(order));
            //}

        }

        public decimal GetOrdersAvg()
        {
            decimal AvgPrice = 0;
            foreach (Order order in _orders)
            {
                AvgPrice += order.TotalAmount / order.ProductCount;
            }
            return AvgPrice;
        }

        public void RemoveByNo(int inputNo)
        {
            foreach (var order in _orders)
            {
                if (order.No == inputNo)
                { 
                    _orders.Remove(order);
                }
            }
            throw new NotFiniteNumberException("Orders package doesn't contain order by this No");
        }

        public List<Order> FilterOrderByPrice(int minPrice, int maxPrice)
        { 
            List<Order> FilteredByPriceOrders = new List<Order>();
            foreach (var order in _orders)
            {
                if (order.TotalAmount >= minPrice && order.TotalAmount <= maxPrice)
                { 
                    FilteredByPriceOrders.Add(order);
                }
            }
            return FilteredByPriceOrders;
        }
    }
}
