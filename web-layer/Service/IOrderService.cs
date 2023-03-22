using web_layer.Entity;
using web_layer.Service.Filter;

namespace web_layer.Service
{
	public interface IOrderService
	{
		public OrderEntity? GetOrderById(int id);
		public Result CreateOrder(OrderEntity order);
		public Result UpdateOrder(OrderEntity order);
		public List<OrderEntity> GetOrders();
		public List<OrderEntity> GetOrders(OrderFilteringObject filteringObject);
	}
}
