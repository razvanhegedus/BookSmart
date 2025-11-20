using System.Collections.Generic;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.OrderManagment
{
    public interface IOrderRepository
    {
        Task<List<Order>> LoadOrdersAsync();
        Task SaveOrdersAsync(List<Order> orders);
    }
}
