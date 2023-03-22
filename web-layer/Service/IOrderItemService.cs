using web_layer.Entity;

namespace web_layer.Service
{
    public interface IOrderItemService
    {
        public Result CreateUpdateOrderItem(OrderItemEntity orderItem);
        public Result DeleteOrderItem(int id);
        public List<OrderItemEntity> GetOrderItems();
    }
}
