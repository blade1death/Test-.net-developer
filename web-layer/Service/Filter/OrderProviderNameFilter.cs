
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
   internal class OrderProviderNameFilter : IOrderFilter
   {
      private List<string> providerNames = new List<string>();

      public OrderProviderNameFilter(params string[] providerNames)
      {
         if (providerNames == null || providerNames.Length == 0)
            throw new ArgumentException($"{nameof(providerNames)} shouldn't be null or empty");

         this.providerNames.AddRange(providerNames);
      }

      public IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders)
      {
         return orders.Where(order => providerNames.Contains(order.ProviderEntity.Name));
      }
   }
}