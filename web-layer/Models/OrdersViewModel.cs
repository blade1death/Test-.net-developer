
using web_layer.Entity;

namespace web_layer.Models
{
   public class OrdersViewModel
   {
      public OrderViewModel[] Orders { get; init; }

      public OrdersViewModel(List<OrderEntity> orderEntities)
      {
         Orders = orderEntities.Select(entity => new OrderViewModel()
         {
            Id = entity.Id,
            Number = entity.Number,
            Date = entity.Date,
            ProviderName = entity.ProviderEntity.Name
         }).ToArray();
      }
   }
}