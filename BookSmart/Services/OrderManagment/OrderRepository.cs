using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.OrderManagment
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string ordersPath;

        public OrderRepository()
        {
            ordersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "orders.txt");
        }

        public async Task<List<Order>> LoadOrdersAsync()
        {
            var orders = new List<Order>();

            if (!File.Exists(ordersPath))
                return orders;

            var lines = await File.ReadAllLinesAsync(ordersPath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 6)
                    continue;

                orders.Add(new Order(
                    parts[0],
                    new Customer(parts[1]),
                    parts[2],
                    parts[3],
                    DateTime.Parse(parts[4]),
                    DateTime.Parse(parts[5])
                ));
            }

            return orders;
        }

        public async Task SaveOrdersAsync(List<Order> orders)
        {
            var lines = orders.Select(o =>
                $"{o.OrderId};{o.Customer.Name};{o.RequestedTitle};{o.RequestedAuthor};{o.OrderDate};{o.EstimatedArrivalDate}"
            );

            await File.WriteAllLinesAsync(ordersPath, lines);
        }
    }
}
