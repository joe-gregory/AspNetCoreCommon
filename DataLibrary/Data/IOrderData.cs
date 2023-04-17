using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface IOrderData
    {
        Task<int> CreateORder(OrderModel order);
        Task<int> DeleteOrder(int orderId);
        Task<OrderModel> GetOrderById(int orderId);
        Task<int> UpdateOrderName(int orderId, string orderName);
    }
}