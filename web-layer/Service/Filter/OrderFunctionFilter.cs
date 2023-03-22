
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
   internal class OrderFunctionFilter : IOrderFilter
   {
      private Func<IQueryable<OrderEntity>, IQueryable<OrderEntity>> func;

      public OrderFunctionFilter(Func<IQueryable<OrderEntity>, IQueryable<OrderEntity>> func)
      {
         ArgumentNullException.ThrowIfNull(func, nameof(func));

         this.func = func;
      }

      public IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders) => func(orders);
   }
}